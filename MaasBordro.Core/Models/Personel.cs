using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaasBordro.Core.Models
{
    public abstract class Personel
    {
        protected Personel(string ad, string unvan, decimal saatlikUcret, int calismaSaati)
        {
            Ad = ad;
            Unvan = unvan;
            SaatlikUcret = saatlikUcret;
            CalismaSaati = calismaSaati;
        }
        public string Ad { get; set; }
        public string Unvan { get; set; }
        public decimal SaatlikUcret { get; set; }
        public int CalismaSaati { get; set; }
        public abstract decimal MaasHesapla();
    }
}
