using MaasBordro.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MaasBordro.Core.Services
{
    public class MaasBordrosu
    {
        public void PersonelEkle(string ad, string unvan)
        {

            string dosyaYolu = "personeller.txt";
            List<object> personeller = new();

            if (File.Exists(dosyaYolu))
            {
                string mevcutIcerik = File.ReadAllText(dosyaYolu);
                if (!string.IsNullOrWhiteSpace(mevcutIcerik))
                {
                    personeller = JsonSerializer.Deserialize<List<object>>(mevcutIcerik);
                }
            }
            var personel = new
            {
                Ad = ad,
                Unvan = unvan
            };

            personeller.Add(personel);

            string guncelIcerik = JsonSerializer.Serialize(personeller, new JsonSerializerOptions { WriteIndented = true });

            File.WriteAllText(dosyaYolu, guncelIcerik);
        }

        public void MaasBordrosuKaydet(Personel personel, string klasorYolu)
        {
            Directory.CreateDirectory(klasorYolu);
            string dosyaYolu = Path.Combine(klasorYolu, $"Maas_Bordro_{DateTime.Now:MMMM_yyyy}.json");

            decimal maas = personel.MaasHesapla();

            object maasBordrosu;


            if (personel.Unvan == "Yonetici")
            {
                var yonetici = (Yonetici)personel;

                maasBordrosu = new
                {
                    PersonelIsmi = yonetici.Ad,
                    CalismaSaati = yonetici.CalismaSaati,
                    AnaOdeme = yonetici.CalismaSaati * yonetici.SaatlikUcret,
                    Bonus = yonetici.Bonus,
                    ToplamOdeme = maas
                };
            }
            else
            {
                var memur = (Memur)personel;

                decimal anaOdeme = memur.SaatlikUcret * (memur.CalismaSaati <= 180 ? memur.CalismaSaati : 180);
                decimal mesaiUcreti = memur.CalismaSaati > 180
                    ? (memur.CalismaSaati * 1.5m) * (memur.CalismaSaati - 180)
                    : 0;

                maasBordrosu = new
                {
                    PersonelIsmi = memur.Ad,
                    CalismaSaati = memur.CalismaSaati,
                    AnaOdeme = anaOdeme,
                    Mesai = mesaiUcreti,
                    ToplamOdeme = maas
                };
            }

            string jsonIcerik = JsonSerializer.Serialize(maasBordrosu, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(dosyaYolu, jsonIcerik);
        }

        public List<Personel> AzCalisanPersoneller(List<Personel> tumPersoneller)
        {
            return tumPersoneller.Where(p => p.CalismaSaati < 150).ToList();
        }
    }
}
