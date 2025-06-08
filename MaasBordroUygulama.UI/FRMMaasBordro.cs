using MaasBordroUygulama.Core.Models;
using MaasBordroUygulama.Core.Services;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.RegularExpressions;
using ClosedXML.Excel;
using iTextSharp.text.pdf;
using iTextSharp.text;
using Document = iTextSharp.text.Document;
using System.Net.Mail;
using System.Net;
using System.Reflection;

namespace MaasBordroUygulama.UI
{
    public partial class FRMMaasBordro : Form
    {
        private List<Personel> personelListesi = new();
        private MaasBordro maasBordro = new();
        private string olusturulanDosyaYolu = null;
        private LogService logger;
        private System.Windows.Forms.Timer timer;

        public FRMMaasBordro()
        {
            InitializeComponent();
            PersonelListesiniYukle();
            PersonelKolonlariEkle();
            PersonelKolonlariYenile();
            RaporKolonlariEkle();

            logger = LogService.Instance;
            logger.Log(new LogGiris(DateTime.Now, "INFO", "Uygulama baþlatýldý.", "Ana Ekran"));

            lblSaatTarih.Text = $"Tarih: {DateTime.Now:dd:MM:yyyy} | {DateTime.Now:HH:mm:ss}";

            timer = new System.Windows.Forms.Timer()
            {
                Interval = 1000,
            };
            timer.Tick += (s, e) => lblSaatTarih.Text = $"Tarih: {DateTime.Now:dd:MM:yyyy} | {DateTime.Now:HH:mm:ss}";
            timer.Start();
            FormClosing += (s, e) => timer.Stop();
        }
        private void PersonelListesiniYukle()
        {
            DosyaOku dosyaOku = new();
            string dosyaYolu = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"..\..\..\", "Data\\Personeller", "personeller.json");

            string klasorYolu = Path.GetDirectoryName(dosyaYolu);

            try
            {
                if (!Directory.Exists(klasorYolu))
                {
                    Directory.CreateDirectory(klasorYolu);
                }
                if (!File.Exists(dosyaYolu))
                {
                    File.WriteAllText(dosyaYolu, "[]");
                    MessageBox.Show("Personel bilgileri bulunamadý, yeni bir dosya oluþturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                personelListesi = dosyaOku.PersonelListesiOku(dosyaYolu);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Personeller yüklenirken bir hata oluþtu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void PersonelListesiniKaydet()
        {
            string dosyaYolu = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"..\..\..\", "Data\\Personeller", "personeller.json");
            try
            {
                string klasorYolu = Path.GetDirectoryName(dosyaYolu);
                if (!Directory.Exists(klasorYolu))
                {
                    Directory.CreateDirectory(klasorYolu);
                }
                var json = JsonSerializer.Serialize(personelListesi.Select(p => new
                {
                    name = p.Ad,
                    title = p.Unvan,
                    saatlikUcret = p.SaatlikUcret,
                    calismaSaati = p.CalismaSaati,
                    bonus = p is Yonetici y ? y.Bonus : 0,
                    derece = p is Memur m ? m.Derece : 0
                }), new JsonSerializerOptions { WriteIndented = true, Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping });
                File.WriteAllText(dosyaYolu, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Personel listesi kaydedilirken hata oluþtu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void PersonelKolonlariEkle()
        {
            dgvPersoneller.Columns.Clear();
            dgvPersoneller.Columns.Add("Ad", "Ad Soyad");
            dgvPersoneller.Columns.Add("Unvan", "Ünvan");
        }
        private void RaporKolonlariEkle()
        {
            dgvRapor.Columns.Clear();
            dgvRapor.Columns.Add("Ad", "Ad Soyad");
            dgvRapor.Columns.Add("Unvan", "Ünvan");
            dgvRapor.Columns.Add("CalismaSaati", "Çalýþma Saati");
            dgvRapor.Columns.Add("SaatlikUcret", "Saatlik Ücret");
            dgvRapor.Columns.Add("AnaOdeme", "Ana Ödeme");
            dgvRapor.Columns.Add("Mesai", "Mesai Ücreti");
            dgvRapor.Columns.Add("Bonus", "Yönetici Bonusu");
            dgvRapor.Columns.Add("Derece", "Memur Derecesi");
            dgvRapor.Columns.Add("ToplamOdeme", "Toplam Ödeme");
        }
        private void PersonelKolonlariYenile()
        {
            dgvPersoneller.Rows.Clear();

            foreach (var personel in personelListesi)
            {
                dgvPersoneller.Rows.Add(personel.Ad, personel.Unvan);
            }
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Regex.IsMatch(txtAd.Text.Trim(), @"^[a-zA-ZðüþöçýÝÐÜÞÖÇ\s]+$") || string.IsNullOrWhiteSpace(txtAd.Text))
                {
                    MessageBox.Show("Ad soyad boþ veya sayýlardan oluþamaz!", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    logger.Log(new LogGiris(DateTime.Now, "WARNING", "Geçersiz ad soyad giriþi", "Personel Ekleme"));
                    return;
                }

                decimal saatlikUcret = nudSaatlikUcret.Value;
                int calismaSaati = (int)nudCalismaSaati.Value;

                Personel personel;
                if (rbtnYonetici.Checked)
                {
                    if (saatlikUcret < 500)
                    {
                        MessageBox.Show("Yönetici saatlik ücreti 500Tl den az olamaz!", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    decimal bonus = nudYoneticiBonusu.Value;
                    personel = new Yonetici(txtAd.Text, saatlikUcret, calismaSaati, bonus);
                }
                else if (rbtnMemur.Checked)
                {
                    if (cmbDerece.SelectedIndex == -1)
                    {
                        MessageBox.Show("Lütfen memur için bir derece seçiniz!", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    int derece = int.Parse(cmbDerece.SelectedItem.ToString());
                    personel = new Memur(txtAd.Text, saatlikUcret, calismaSaati, derece);
                }
                else
                {
                    MessageBox.Show("Lütfen bir ünvan seçin!", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                personelListesi.Add(personel);
                string anaKlasor = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"..\..\..\", "Data\\Personeller");
                maasBordro.MaasBordrosuKaydet(personel, anaKlasor);

                PersonelListesiniKaydet();
                PersonelKolonlariYenile();
                Temizle();

                MessageBox.Show("Personel eklendi.", "Baþarýlý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                logger.Log(new LogGiris(DateTime.Now, "INFO", $"Personel eklendi: {personel.Ad}", "Personel Ekleme"));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Beklenmeyen bir hata oluþtu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                logger.Log(new LogGiris(DateTime.Now, "ERROR", $"Personel eklerken bir hata oluþtu: {ex.Message}", "Personel Ekleme"));
            }
        }
        private void Temizle()
        {
            txtAd.Clear();
            rbtnMemur.Checked = false;
            nudSaatlikUcret.Value = 0;
            nudCalismaSaati.Value = 0;
            nudYoneticiBonusu.Value = 0;
            rbtnYonetici.Checked = false;
            cmbDerece.SelectedIndex = -1;
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvPersoneller.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silinecek bir personel seçin!", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                logger.Log(new LogGiris(DateTime.Now, "WARNING", "Silme iþlemi için personel seçilmedi", "Personel Silme"));
                return;
            }

            int seciliIndex = dgvPersoneller.SelectedRows[0].Index;
            string personelAd = personelListesi[seciliIndex].Ad;

            DialogResult onay = MessageBox.Show
                ($"'{personelAd}' adlý personeli silmek istediðinize emin misiniz?", "Silme Onayý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (onay == DialogResult.Yes)
            {
                personelListesi.RemoveAt(seciliIndex);
                PersonelListesiniKaydet();
                PersonelKolonlariYenile();
                Temizle();
                MessageBox.Show("Personel silindi.", "Baþarýlý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                logger.Log(new LogGiris(DateTime.Now, "INFO", $"Personel silindi: {personelAd}", "Personel Silme"));
            }
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvPersoneller.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen güncellenecek bir personel seçiniz!", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                logger.Log(new LogGiris(DateTime.Now, "WARNING", "Güncelleme için personel seçilmedi", "Personel Güncelleme"));
                return;
            }
            try
            {
                if (!Regex.IsMatch(txtAd.Text.Trim(), @"^[a-zA-ZðüþöçýÝÐÜÞÖÇ\s]+$") || string.IsNullOrWhiteSpace(txtAd.Text))
                {
                    MessageBox.Show("Ad soyad boþ veya sayýlardan oluþamaz!", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal saatlikUcret = nudSaatlikUcret.Value;
                int calismaSaati = (int)nudCalismaSaati.Value;

                int seciliIndex = dgvPersoneller.SelectedRows[0].Index;
                Personel seciliPersonel = personelListesi[seciliIndex];

                seciliPersonel.Ad = txtAd.Text;
                seciliPersonel.SaatlikUcret = saatlikUcret;
                seciliPersonel.CalismaSaati = calismaSaati;

                string unvan = rbtnYonetici.Checked ? "Yönetici" : "Memur";

                if (seciliPersonel.Unvan == "Yönetici" && unvan == "Yönetici")
                {
                    ((Yonetici)seciliPersonel).Bonus = nudYoneticiBonusu.Value;
                }
                else if (seciliPersonel.Unvan == "Memur" && unvan == "Memur")
                {
                    int derece = int.Parse(cmbDerece.SelectedItem.ToString());
                    ((Memur)seciliPersonel).Derece = derece;
                    seciliPersonel.SaatlikUcret = saatlikUcret + (derece * 10);
                }
                else if (seciliPersonel.Unvan != unvan)
                {
                    personelListesi.RemoveAt(seciliIndex);
                    Personel personel = unvan == "Yönetici"
                        ? new Yonetici(txtAd.Text, saatlikUcret, calismaSaati, nudYoneticiBonusu.Value)
                        : new Memur(txtAd.Text, saatlikUcret, calismaSaati, int.Parse(cmbDerece.SelectedItem.ToString()));
                    personelListesi.Insert(seciliIndex, personel);
                    seciliPersonel = personel;
                }
                string anaKlasor = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"..\..\..\", "Data\\Personeller");
                maasBordro.MaasBordrosuKaydet(seciliPersonel, anaKlasor);

                PersonelListesiniKaydet();
                PersonelKolonlariYenile();
                Temizle();

                MessageBox.Show("Personel güncellendi.", "Baþarýlý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                logger.Log(new LogGiris(DateTime.Now, "INFO", $"Personel güncellendi: {seciliPersonel.Ad}", "Personel Güncelleme"));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Beklenmeyen bir hata oluþtu: {ex.Message}", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                logger.Log(new LogGiris(DateTime.Now, "ERROR", $"Personel güncellenirken hata: {ex.Message}", "Personel Güncelleme"));
            }
        }
        private void dgvPersoneller_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPersoneller.SelectedRows.Count > 0)
            {
                int seciliIndex = dgvPersoneller.SelectedRows[0].Index;
                Personel seciliPersonel = personelListesi[seciliIndex];

                txtAd.Text = seciliPersonel.Ad;
                nudSaatlikUcret.Value = seciliPersonel.SaatlikUcret;
                nudCalismaSaati.Value = seciliPersonel.CalismaSaati;

                if (seciliPersonel.Unvan == "Yönetici")
                {
                    rbtnYonetici.Checked = true;
                    var yonetici = (Yonetici)seciliPersonel;
                    nudYoneticiBonusu.Value = yonetici.Bonus;
                    cmbDerece.SelectedIndex = -1;
                }
                else if (seciliPersonel.Unvan == "Memur")
                {
                    rbtnMemur.Checked = true;
                    var memur = (Memur)seciliPersonel;
                    cmbDerece.SelectedItem = memur.Derece.ToString();
                    nudYoneticiBonusu.Value = 0;
                }
            }
        }
        private void btnRapor_Click(object sender, EventArgs e)
        {
            dgvRapor.Rows.Clear();
            try
            {
                foreach (var personel in personelListesi)
                {
                    decimal maas = personel.MaasHesapla();
                    decimal anaOdeme = 0;
                    decimal mesai = 0;
                    decimal bonus = 0;
                    int derece = 0;

                    if (personel.Unvan == "Yönetici")
                    {
                        anaOdeme = personel.SaatlikUcret * personel.CalismaSaati;
                        bonus = ((Yonetici)personel).Bonus;
                    }
                    else if (personel.Unvan == "Memur")
                    {
                        anaOdeme = Math.Min(personel.CalismaSaati, 180) * personel.SaatlikUcret;
                        mesai = personel.CalismaSaati > 180
                            ? (personel.CalismaSaati - 180) * personel.SaatlikUcret * 1.5m
                            : 0;
                        derece = ((Memur)personel).Derece;
                    }
                    dgvRapor.Rows.Add(personel.Ad, personel.Unvan, personel.CalismaSaati, personel.SaatlikUcret, anaOdeme, mesai, bonus, derece, maas);
                }

                var azCalisanlar = maasBordro.AzCalisanPersoneller(personelListesi);
                if (azCalisanlar.Count > 0)
                {
                    string mesaj = "150 saatten az çalýþanlar:\n" + string.Join("\n", azCalisanlar.Select(p => $"{p.Ad} - {p.CalismaSaati} saat"));
                    MessageBox.Show(mesaj, "Az Çalýþan Personeller", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                logger.Log(new LogGiris(DateTime.Now, "INFO", "Rapor oluþturuldu", "Raporlama"));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Beklenmeyen bir hata oluþtu: {ex.Message}", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                logger.Log(new LogGiris(DateTime.Now, "ERROR", $"Rapor oluþturulurken hata: {ex.Message}", "Raporlama"));
            }
        }
        private void rbtnYonetici_CheckedChanged(object sender, EventArgs e)
        {
            cmbDerece.Visible = false;
            lblDerece.Visible = false;
            nudYoneticiBonusu.Visible = true;
            lblBonus.Visible = true;
        }
        private void rbtnMemur_CheckedChanged(object sender, EventArgs e)
        {
            nudYoneticiBonusu.Visible = false;
            lblBonus.Visible = false;
            cmbDerece.Visible = true;
            lblDerece.Visible = true;
        }
        private void btnExcelOlustur_Click(object sender, EventArgs e)
        {
            try
            {
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.AddWorksheet("MaasBordroRaporu");

                    worksheet.Cell(1, 1).Value = "Ad Soyad";
                    worksheet.Cell(1, 2).Value = "Ünvan";
                    worksheet.Cell(1, 3).Value = "Çalýþma Saati";
                    worksheet.Cell(1, 4).Value = "Saatlik Ücret";
                    worksheet.Cell(1, 5).Value = "Ana Ödeme";
                    worksheet.Cell(1, 6).Value = "Mesai Ücreti";
                    worksheet.Cell(1, 7).Value = "Yönetici Bonusu";
                    worksheet.Cell(1, 8).Value = "Memur Derecesi";
                    worksheet.Cell(1, 9).Value = "Toplam Ödeme";

                    int satir = 2;

                    foreach (DataGridViewRow row in dgvRapor.Rows)
                    {
                        worksheet.Cell(satir, 1).Value = row.Cells["Ad"].Value?.ToString();
                        worksheet.Cell(satir, 2).Value = row.Cells["Unvan"].Value?.ToString();
                        worksheet.Cell(satir, 3).Value = row.Cells["CalismaSaati"].Value?.ToString();
                        worksheet.Cell(satir, 4).Value = row.Cells["SaatlikUcret"].Value?.ToString();
                        worksheet.Cell(satir, 5).Value = row.Cells["AnaOdeme"].Value?.ToString();
                        worksheet.Cell(satir, 6).Value = row.Cells["Mesai"].Value?.ToString();
                        worksheet.Cell(satir, 7).Value = row.Cells["Bonus"].Value?.ToString();
                        worksheet.Cell(satir, 8).Value = row.Cells["Derece"].Value?.ToString();
                        worksheet.Cell(satir, 9).Value = row.Cells["ToplamOdeme"].Value?.ToString();
                        satir++;
                    }

                    using (SaveFileDialog saveFileDialog = new())
                    {
                        saveFileDialog.Filter = "Excel Files|*.xlsx";
                        saveFileDialog.Title = "Excel Dosyasýný Kaydet";
                        saveFileDialog.FileName = $"MaasBordroRaporu_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx";

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            olusturulanDosyaYolu = saveFileDialog.FileName;
                            workbook.SaveAs(olusturulanDosyaYolu);
                            MessageBox.Show("Excel oluþturuldu.", "Baþarýlý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            logger.Log(new LogGiris(DateTime.Now, "INFO", $"Excel dosyasý oluþturuldu: {olusturulanDosyaYolu}", "Excel Oluþturma"));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Excel oluþturulurken hata oluþtu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                logger.Log(new LogGiris(DateTime.Now, "ERROR", $"Excel oluþturulurken hata oluþtu: {ex.Message}", "Excel Oluþturma"));
            }
        }
        private void btnPdfOlustur_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new();
                saveFileDialog.Filter = "PDF Dosyasý|*.pdf";
                saveFileDialog.Title = "PDF Dosyasýný Kaydet";
                saveFileDialog.FileName = $"MaasBordroRaporu_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Document document = new();
                    olusturulanDosyaYolu = saveFileDialog.FileName;
                    PdfWriter.GetInstance(document, new FileStream(olusturulanDosyaYolu, FileMode.Create));
                    document.Open();

                    PdfPTable pdfPTable = new PdfPTable(dgvRapor.Columns.Count);
                    pdfPTable.WidthPercentage = 100;

                    foreach (DataGridViewColumn column in dgvRapor.Columns)
                    {
                        PdfPCell pdfPCell = new PdfPCell(new Phrase(column.HeaderText));
                        pdfPCell.BackgroundColor = BaseColor.LIGHT_GRAY;
                        pdfPTable.AddCell(pdfPCell);
                    }

                    foreach (DataGridViewRow row in dgvRapor.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            pdfPTable.AddCell(cell.Value?.ToString() ?? "");
                        }
                    }
                    document.Add(pdfPTable);
                    document.Close();

                    MessageBox.Show("PDF oluþturuldu.", "Baþarýlý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Log(new LogGiris(DateTime.Now, "INFO", $"PDF dosyasý oluþturuldu", "PDF Oluþturma"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"PDF oluþurken hata oluþtu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                logger.Log(new LogGiris(DateTime.Now, "ERROR", $"PDF oluþturulurken hata: {ex.Message}", "PDF Oluþturma"));
            }
        }
        private void btnMailGonder_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMail.Text) || !MailAdresiGecerliMi(txtMail.Text))
                {
                    MessageBox.Show("Lütfen geçerli bir mail adresi giriniz!", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    logger.Log(new LogGiris(DateTime.Now, "WARNING", "Geçersiz mail adresi girildi", "Mail Gönderme"));
                    return;
                }

                if (string.IsNullOrEmpty(olusturulanDosyaYolu) || !File.Exists(olusturulanDosyaYolu))
                {
                    MessageBox.Show("Önce bir PDF veya Excel dosyasý oluþturmalýsýnýz!", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Log(new LogGiris(DateTime.Now, "WARNING", "Dosya oluþturulmadan mail gönderilmeye çalýþýldý", "Mail Gönderme"));
                    return;
                }

                string gondericiMaili = "denizgokay.yzlm@gmail.com";
                string sifre = "lwivyhxcxirhohjv";
                string aliciMaili = txtMail.Text.Trim();

                MailMessage mail = new();
                mail.From = new MailAddress(gondericiMaili);
                mail.To.Add(aliciMaili);
                mail.Subject = "Maaþ Bordro Raporu";
                mail.Body = "Merhaba,\n\nEk'te maaþ bordro raporunu bulabilirsiniz.\n\nÝyi günler, iyi çalýþmalar.";
                mail.Attachments.Add(new Attachment(olusturulanDosyaYolu));

                SmtpClient smtp = new("smtp.gmail.com", 587);
                smtp.EnableSsl = true;
                smtp.Credentials = new NetworkCredential(gondericiMaili, sifre);
                smtp.Send(mail);

                MessageBox.Show("Mail gönderildi.", "Baþarýlý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                logger.Log(new LogGiris(DateTime.Now, "INFO", $"Mail gönderildi: {txtMail.Text}", "Mail Gönderme"));
                txtMail.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Mail gönderilirken hata oluþtu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                logger.Log(new LogGiris(DateTime.Now, "ERROR", $"Mail gönderilirken hata: {ex.Message}", "Mail Gönderme"));
            }
        }
        private bool MailAdresiGecerliMi(string email)
        {
            try
            {
                var adres = new MailAddress(email);
                return adres.Address == email;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void btnGec_Click(object sender, EventArgs e)
        {
            tbcEkrani.SelectedIndex = 1;
        }
        private void btnRaporaGec_Click(object sender, EventArgs e)
        {
            tbcEkrani.SelectedIndex = 2;
        }
        private void btnAnasayfaDon_Click(object sender, EventArgs e)
        {
            tbcEkrani.SelectedIndex = 0;
        }
    }
}
