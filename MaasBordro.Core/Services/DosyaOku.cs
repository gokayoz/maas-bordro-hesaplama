using MaasBordro.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MaasBordro.Core.Services
{
    public class DosyaOku
    {
        public List<Personel> PersonelListesiOku(string dosyaYolu)
        {
            List<Personel> personeller = new();
            if (!File.Exists(dosyaYolu))
            {
                return personeller;
            }

            string jsonIcerik = File.ReadAllText(dosyaYolu);

            using (JsonDocument doc = JsonDocument.Parse(jsonIcerik))
            {
                JsonElement root = doc.RootElement;

                if (root.ValueKind == JsonValueKind.Array)
                {
                    foreach (JsonElement personelElement in root.EnumerateArray())
                    {
                        string ad = personelElement.GetProperty("Ad").GetString();
                        string unvan = personelElement.GetProperty("Unvan").GetString();

                        if (unvan == "Yonetici")
                        {
                            personeller.Add(new Yonetici(ad, 500, 0, 0));
                        }
                        else if (unvan == "Memur")
                        {
                            personeller.Add(new Memur(ad, 500, 0, 0));
                        }
                    }
                }
            }
            return personeller;
        }
    }
}
