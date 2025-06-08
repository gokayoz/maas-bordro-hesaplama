using MaasBordroUygulama.Core.Models;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Reflection;

namespace MaasBordroUygulama.Core.Services
{
    public class MaasBordro
    {
        public void MaasBordrosuKaydet(Personel personel, string anaKlasor)
        {
            string yol = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"..\..\..\", "Data\\Personeller");

            if (!string.IsNullOrEmpty(anaKlasor))
            {
                yol = anaKlasor;
            }

            string klasorYolu = Path.Combine(yol, personel.Ad);
            Directory.CreateDirectory(klasorYolu);

            string dosyaYolu = Path.Combine(klasorYolu, $"personel_bordro.json");

            decimal maas = personel.MaasHesapla();
            string jsonIcerik;
            string tarih = $"{DateTime.Now:MMMMyyyy}";


            Yonetici yonetici = personel as Yonetici;
            Memur memur = personel as Memur;

            if (yonetici != null)
            {
                decimal anaOdeme = yonetici.SaatlikUcret * yonetici.CalismaSaati;
                decimal bonus = yonetici.Bonus;

                jsonIcerik = $@"
                {{
                    ""Maas Bordro, {tarih}"": {{
                    ""Personel Ismi"": ""{yonetici.Ad}"",
                    ""Calisma Saati"": {yonetici.CalismaSaati},
                    ""Ana Odeme"": ""₺{anaOdeme:N2}"",
                    ""Mesai"": ""₺{0}"",
                    ""Toplam Odeme"": ""₺{maas:N2}""
                    }}
               }}";
            }
            else if (memur != null)
            {
                decimal anaOdeme;
                decimal mesai = 0;

                if (memur.CalismaSaati > 180)
                {
                    anaOdeme = 180 * memur.SaatlikUcret;
                    mesai = (memur.CalismaSaati - 180) * memur.SaatlikUcret * 1.5m;
                }
                else
                {
                    anaOdeme = memur.CalismaSaati * memur.SaatlikUcret;
                }
                jsonIcerik = $@"
                {{
                    ""Maas Bordro, {tarih}"": {{
                    ""Personel Ismi"": ""{memur.Ad}"",
                    ""Calisma Saati"": {memur.CalismaSaati},
                    ""Ana Odeme"": ""₺{anaOdeme:N2}"",
                    ""Mesai"": ""₺{mesai:N2}"",
                    ""Toplam Odeme"": ""₺{maas:N2}""
                    }}
               }}";
            }
            else
            {
                throw new NotImplementedException();
            }

            var jsonObject = JsonSerializer.Deserialize<object>(jsonIcerik);
            string jsonHali = JsonSerializer.Serialize(jsonObject, new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            });
            File.WriteAllText(dosyaYolu, jsonHali);
        }
        public List<Personel> AzCalisanPersoneller(List<Personel> personelListesi)
        {
            return personelListesi.FindAll(p => p.CalismaSaati < 150);
        }
    }
}