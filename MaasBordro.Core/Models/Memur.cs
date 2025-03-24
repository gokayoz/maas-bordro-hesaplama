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
        public Memur(string ad, decimal saatlikUcret, int calismaSaati, int derece) : base(ad, "Memur", saatlikUcret, calismaSaati)
        {
            if (saatlikUcret > 0)
            {
                SaatlikUcret = saatlikUcret;
            }
            else
            {
                SaatlikUcret = 500;
            }
            Derece = derece;

            SaatlikUcret += Derece * 10;
        }
        public int Derece { get; set; }
        public int _maksimumSaat = 180;
        public override decimal MaasHesapla()
        {
            decimal anaOdeme = 0;
            decimal mesaiUcreti = 0;

            if (CalismaSaati <= _maksimumSaat)
            {
                anaOdeme = SaatlikUcret * _maksimumSaat;
            }
            else
            {
                anaOdeme = SaatlikUcret * _maksimumSaat;
                int mesaiSaati = CalismaSaati - _maksimumSaat;
                mesaiUcreti = (SaatlikUcret * (decimal)1.5) * mesaiSaati;
            }

            return anaOdeme + mesaiUcreti;
        }
    }
}
