using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaasBordroUygulama.Core.Models
{
    public class Yonetici : Personel
    {
        public decimal Bonus { get; set; }
        public Yonetici(string ad, decimal saatlikUcret, int calismaSaati, decimal bonus) : base(ad, "Yönetici", saatlikUcret, calismaSaati)
        {
            if (saatlikUcret < 500)
            {
                saatlikUcret = 500;
            }
            Bonus = bonus;
        }
        public override decimal MaasHesapla() => (SaatlikUcret * CalismaSaati) + Bonus;
    }
}