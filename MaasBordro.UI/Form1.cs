using MaasBordro.Core.Models;
using MaasBordro.Core.Services;
using System.DirectoryServices.ActiveDirectory;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace MaasBordro.UI
{
    public partial class Form1 : Form
    {
        private List<Personel> personeller;
        private DosyaOku dosyaOku;
        private MaasBordrosu maasBordro;
        private string personelDosyaYolu = "personeller.txt";
        public Form1()
        {
            InitializeComponent();
            personeller = new();
            dosyaOku = new();
            maasBordro = new();
            PersonelleriGetir();

            txtSaatlikUcret.KeyPress += NumerikKontrol;
            txtCalismaSaati.KeyPress += NumerikKontrol;
            txtYoneticiBonusu.KeyPress += NumerikKontrol;
        }
        private void PersonelleriGetir()
        {
            if (!File.Exists(personelDosyaYolu))
            {
                File.WriteAllText(personelDosyaYolu, "[]");
            }
            personeller = dosyaOku.PersonelListesiOku(personelDosyaYolu);
            dgvPersoneller.Rows.Clear();

            foreach (var personel in personeller)
            {
                dgvPersoneller.Rows.Add(personel.Ad, personel.Unvan);
            }
        }
        private void NumerikKontrol(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.' && e.KeyChar != ','))
            {
                e.Handled = true;
            }

            TextBox textBox = (TextBox)sender;
            if ((e.KeyChar == '.' || e.KeyChar == ',') && textBox.Text.Contains(','))
            {
                e.Handled |= true;
            }
        }
        private bool AdSoyadHataliMi(string adSoyad)
        {
            if (string.IsNullOrWhiteSpace(adSoyad))
            {
                MessageBox.Show("Ad soyad bilgisi bo� b�rak�lamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (adSoyad.Length < 2)
            {
                MessageBox.Show("Ad soyad bilgisi en az 2 karakter olmal�d�r!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!Regex.IsMatch(adSoyad, @"^[a-zA-Z������������\s]+$"))
            {
                MessageBox.Show("Ad soyad sadece harflerden olu�abilir!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool CalismaSaatiHataliMi(string calismaSaati)
        {
            if (string.IsNullOrWhiteSpace(calismaSaati))
            {
                MessageBox.Show("�al��ma saati bo� olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!int.TryParse(calismaSaati, out int saat) || saat < 0 || saat > 360)
            {
                MessageBox.Show("L�tfen ge�erli bir �al��ma saati giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool SaatlikUcretHataliMi(string saatlikUcret)
        {
            if (string.IsNullOrWhiteSpace(saatlikUcret))
            {
                MessageBox.Show("Saatlik �cret bo� olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!decimal.TryParse(saatlikUcret, out decimal ucret) || ucret < 500)
            {
                MessageBox.Show("Minumum saatlik �cret 500TL dir!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool YoneticiBonusHataliMi(string bonus)
        {
            if (string.IsNullOrWhiteSpace(bonus))
            {
                MessageBox.Show("Y�netici bonusu bo� b�rak�lamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!double.TryParse(bonus, out double bonusMiktari) || bonusMiktari < 0)
            {
                MessageBox.Show("Ge�erli bir bonus miktar� giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool MemurDerecesiHataliMi()
        {
            if (rbtnMemur.Checked && cmbMemurDerecesi.SelectedIndex == -1)
            {
                MessageBox.Show("Memur derecesi se�iniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (!AdSoyadHataliMi(txtAdSoyad.Text) ||
                    !SaatlikUcretHataliMi(txtSaatlikUcret.Text) ||
                    !CalismaSaatiHataliMi(txtCalismaSaati.Text) ||
                    !MemurDerecesiHataliMi() ||
                    (rbtnYonetici.Checked && !YoneticiBonusHataliMi(txtYoneticiBonusu.Text))
                    )
                {
                    return;
                }

                string adSoyad = txtAdSoyad.Text.Trim();
                decimal saatlikUcret = decimal.Parse(txtSaatlikUcret.Text);
                int calismaSaati = int.Parse(txtCalismaSaati.Text);
                string unvan = rbtnYonetici.Checked ? "Yonetici" : "Memur";

                Personel personel;

                if (rbtnYonetici.Checked)
                {
                    double bonus = double.Parse(txtYoneticiBonusu.Text);
                    personel = new Yonetici(adSoyad, saatlikUcret, calismaSaati, bonus);
                }
                else
                {
                    int derece = int.Parse(cmbMemurDerecesi.Text);
                    personel = new Memur(adSoyad, saatlikUcret, calismaSaati, derece);
                }

                maasBordro.PersonelEkle(adSoyad, unvan);

                decimal maas = personel.MaasHesapla();
                MessageBox.Show($"Maa� Bilgisi:\n" +
                    $"{personel.Ad} - {maas:C2}", "Maa� Hesaplama", MessageBoxButtons.OK, MessageBoxIcon.Information);

                PersonelleriGetir();

                string klasorYolu = Path.Combine(Directory.GetCurrentDirectory(), personel.Ad);
                maasBordro.MaasBordrosuKaydet(personel, klasorYolu);

                Temizle();

                MessageBox.Show("Personel eklendi ve maa� bilgileri kaydedildi.", "Ba�ar�l�", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Beklenmeyen bir hata olu�tu!: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Temizle()
        {
            txtAdSoyad.Clear();
            txtCalismaSaati.Clear();
            txtSaatlikUcret.Clear();
            cmbMemurDerecesi.SelectedIndex = -1;
            txtYoneticiBonusu.Clear();
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvPersoneller.SelectedRows.Count > 0)
            {
                int seciliIndex = dgvPersoneller.SelectedRows[0].Index;

                DialogResult onay = MessageBox.Show(
                    $"{personeller[seciliIndex].Ad} adl� personeli silmek istedi�inize emin misiniz?", "Silme Onay�",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    );

                if (onay == DialogResult.Yes)
                {
                    dgvPersoneller.Rows.RemoveAt(seciliIndex);
                    personeller.RemoveAt(seciliIndex);

                    string guncelIcerik = JsonSerializer.Serialize(personeller.Select(p => new { Ad = p.Ad, Unvan = p.Unvan }), new JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText(personelDosyaYolu, guncelIcerik);

                    MessageBox.Show("Personel silindi.", "Ba�ar�l�", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("L�tfen silinecek bir personel se�iniz!", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvPersoneller.SelectedRows.Count > 0)
            {
                int seciliIndex = dgvPersoneller.SelectedRows[0].Index;
                Personel seciliPersonel = personeller[seciliIndex];

                if (!AdSoyadHataliMi(txtAdSoyad.Text) ||
                    !SaatlikUcretHataliMi(txtSaatlikUcret.Text) ||
                    !CalismaSaatiHataliMi(txtCalismaSaati.Text) ||
                    !MemurDerecesiHataliMi() ||
                    (rbtnYonetici.Checked && !YoneticiBonusHataliMi(txtYoneticiBonusu.Text)))
                {
                    return;
                }

                seciliPersonel.Ad = txtAdSoyad.Text.Trim();
                seciliPersonel.SaatlikUcret = decimal.Parse(txtSaatlikUcret.Text);
                seciliPersonel.CalismaSaati = int.Parse(txtCalismaSaati.Text);

                if (rbtnYonetici.Checked)
                {
                    ((Yonetici)seciliPersonel).Bonus = double.Parse(txtYoneticiBonusu.Text);
                }
                else
                {
                    ((Memur)seciliPersonel).Derece = int.Parse(cmbMemurDerecesi.Text);
                }

                PersonelleriGetir();
                MessageBox.Show("Personel bilgileri g�ncellendi.", "Ba�ar�l�", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("L�tfen g�ncellemek i�in bir personel se�iniz!", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }
        private void rbtnYonetici_CheckedChanged(object sender, EventArgs e)
        {
            cmbMemurDerecesi.Visible = false;
            lblMemur.Visible = false;
            txtYoneticiBonusu.Visible = true;
            lblYonetici.Visible = true;
        }
        private void rbtnMemur_CheckedChanged(object sender, EventArgs e)
        {
            txtYoneticiBonusu.Visible = false;
            lblYonetici.Visible = false;
            cmbMemurDerecesi.Visible = true;
            lblMemur.Visible = true;
        }

        private void dgvPersoneller_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPersoneller.SelectedRows.Count > 0)
            {
                int seciliIndex = dgvPersoneller.SelectedRows[0].Index;

                if (seciliIndex >= 0 && seciliIndex < personeller.Count)
                {
                    Personel seciliPersonel = personeller[seciliIndex];

                    txtAdSoyad.Text = seciliPersonel.Ad;
                    txtCalismaSaati.Text = seciliPersonel.CalismaSaati.ToString();
                    txtSaatlikUcret.Text = seciliPersonel.SaatlikUcret.ToString();

                    if (seciliPersonel.Unvan == "Yonetici")
                    {
                        rbtnYonetici.Checked = true;
                        var yonetici = (Yonetici)seciliPersonel;
                        txtYoneticiBonusu.Text = yonetici.Bonus.ToString();

                        txtYoneticiBonusu.Visible = true;
                        lblYonetici.Visible = true;

                        cmbMemurDerecesi.Visible = false;
                        lblMemur.Visible = false;
                    }
                    else if (seciliPersonel.Unvan == "Memur")
                    {
                        rbtnMemur.Checked = true;
                        var memur = (Memur)seciliPersonel;
                        cmbMemurDerecesi.Text = memur.Derece.ToString();

                        cmbMemurDerecesi.Visible = true;
                        lblMemur.Visible = true;

                        txtYoneticiBonusu.Visible = false;
                        lblYonetici.Visible = false;
                    }

                }
            }
        }

    }
}
