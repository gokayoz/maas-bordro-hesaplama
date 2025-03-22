using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaasBordro.Core.Models
{
    public abstract class Personel
    {
        public string Ad { get; set; }
        public decimal SaatlikUcret { get; set; }
        public int CalismaSaati { get; set; }
        public abstract decimal MaasHesapla();
    }
}
