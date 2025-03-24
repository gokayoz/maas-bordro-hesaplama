using MaasBordro.Core.Models;

namespace MaasBordro.UI
{
    public partial class Form1 : Form
    {
        public List<Personel> personeller;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                string adSoyad = txtAdSoyad.Text;
                decimal saatlikUcret = decimal.Parse(txtSaatlikUcret.Text);
                int calismaSaati = int.Parse(txtCalismaSaati.Text);

                Personel personel;

                if (rbtnYonetici.Checked)
                {
                    double bonus = double.Parse(txtYoneticiBonusu.Text);
                    personel = new Yonetici(adSoyad, saatlikUcret, calismaSaati, bonus);
                }
                else if (rbtnMemur.Checked)
                {
                    int derece = int.Parse(cmbMemurDerecesi.Text);
                    personel = new Memur(adSoyad, saatlikUcret, calismaSaati, derece);
                }
                else
                {
                    MessageBox.Show("Lütfen bir ünvan seçiniz!");
                    return;
                }

                decimal maas = personel.MaasHesapla();
                dgvPersoneller.Rows.Add(personel.Ad, personel.Unvan, maas);

                MessageBox.Show("Personel eklendi ve maaþ bilgileri kaydedildi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAdSoyad.Clear();
            txtCalismaSaati.Clear();
            txtSaatlikUcret.Clear();
            cmbMemurDerecesi.Items.Clear();
            txtYoneticiBonusu.Clear();
            rbtnMemur.Enabled = true;
            rbtnYonetici.Enabled = true;
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvPersoneller.SelectedRows.Count > 0)
            {
                int seciliIndex = dgvPersoneller.SelectedRows[0].Index;
                dgvPersoneller.Rows.RemoveAt(seciliIndex);
                MessageBox.Show("Personel silindi.");
            }
            else
            {
                MessageBox.Show("Lütfen silinecek bir personel seçiniz!");
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
    }
}
