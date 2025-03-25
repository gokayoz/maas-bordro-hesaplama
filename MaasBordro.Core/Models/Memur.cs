using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MaasBordro.Core.Models
{
    public class Memur : Personel
    {
        public int Derece { get; set; }
        public Memur(string ad, decimal saatlikUcret, int calismaSaati, int derece) : base(ad, "Memur", saatlikUcret, calismaSaati)
        {
            Derece = derece;

            if (saatlikUcret <= 0)
            {
                SaatlikUcret = 500m;
            }
            SaatlikUcret = saatlikUcret + (Derece * 10);
        }
        public override decimal MaasHesapla()
        {
            decimal anaOdeme = Math.Min(CalismaSaati, 180) * SaatlikUcret;

            decimal mesaiUcreti = 0;
            if (CalismaSaati > 180)
            {
                int mesaiSaati = CalismaSaati - 180;
                mesaiUcreti = (SaatlikUcret * 1.5m) * mesaiSaati;

            }
            return anaOdeme + mesaiUcreti;
        }
    }
}
