using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaasBordroUygulama.Core.Models
{
    public abstract class Personel
    {
        public string Ad { get; set; }
        public string Unvan { get; set; }
        public decimal SaatlikUcret { get; set; }
        public int CalismaSaati { get; set; }
        protected Personel(string ad, string unvan, decimal saatlikUcret, int calismaSaati)
        {
            Ad = ad;
            Unvan = unvan;
            SaatlikUcret = saatlikUcret;
            CalismaSaati = calismaSaati;
        }
        public abstract decimal MaasHesapla();
    }
}