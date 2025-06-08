using MaasBordroUygulama.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MaasBordroUygulama.Core.Services
{
    public class DosyaOku
    {
        public List<Personel> PersonelListesiOku(string dosyaYolu)
        {
            var personelListesi = new List<Personel>();
            if (!File.Exists(dosyaYolu))
            {
                return personelListesi;
            }

            string jsonIcerik = File.ReadAllText(dosyaYolu);
            var jsonlar = JsonSerializer.Deserialize<List<Dictionary<string, object>>>(jsonIcerik);

            foreach (var json in jsonlar)
            {
                string name = json["name"].ToString(); ;
                string title = json["title"].ToString(); ;
                decimal saatlikUcret = decimal.Parse(json["saatlikUcret"]?.ToString() ?? "500");
                int calismaSaati = int.Parse(json["calismaSaati"]?.ToString() ?? "0");

                if (title == "Yönetici")
                {
                    decimal bonus = decimal.Parse(json["bonus"]?.ToString() ?? "0");
                    personelListesi.Add(new Yonetici(name, saatlikUcret, calismaSaati, bonus));
                }
                else if (title == "Memur")
                {
                    int derece = int.Parse(json["derece"]?.ToString() ?? "0");
                    personelListesi.Add(new Memur(name, saatlikUcret, calismaSaati, derece));
                }
            }
            return personelListesi;
        }
    }
}