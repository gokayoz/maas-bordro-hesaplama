using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaasBordro.Core.Models
{
    public class Yonetici : Personel
    {
        public Yonetici(string ad, decimal saatlikUcret, int calismaSaati, double bonus) : base(ad, "Yonetici", saatlikUcret, calismaSaati)
        {
            if (saatlikUcret < 500)
            {
                saatlikUcret = 500;
            }
            SaatlikUcret = saatlikUcret;
            Bonus = bonus;
        }

        public double Bonus { get; set; }
        public override decimal MaasHesapla()
        {
            return (SaatlikUcret * CalismaSaati) + (decimal)Bonus;
        }
    }
}
