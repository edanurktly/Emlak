using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emlak
{
    public class Konut
    {
        public string IlanTuru { get; set; } //satılık - kiralık
        public int Fiyat { get; set; }
        public string metrkare { get; set; }
        public string odasalon { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }

        public string Adres { get; set; }
        public bool Takas { get; set; }
    }
}
