using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaasBordroUygulama.Core.Models
{
    public class Memur : Personel
    {
        public int Derece { get; set; }

        public Memur(string ad, decimal saatlikUcret, int calismaSaati, int derece) : base(ad, "Memur", saatlikUcret, calismaSaati)
        {
            Derece = derece;

            if (saatlikUcret <= 0)
            {
                SaatlikUcret = 500;
            }
            SaatlikUcret += Derece * 10;
        }
        public override decimal MaasHesapla()
        {
            decimal anaMaas = Math.Min(CalismaSaati, 180) * SaatlikUcret;
            decimal mesai = MesaiHesapla();

            return anaMaas + mesai;
        }
        private decimal MesaiHesapla()
        {
            return CalismaSaati > 180 ? (CalismaSaati - 180) * SaatlikUcret * 1.5m : 0;
        }
    }
}