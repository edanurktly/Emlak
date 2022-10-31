using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emlak
{
    public class Arac
    {
        public  int IlanNo { get; set; }
        public string Marka { get; set; }
        public string Seri { get; set; }
        public string Model { get; set; }
        public string Yıl { get; set; }
        public string Renk { get; set; }
        public string km { get; set; }
        public string vites { get; set; }
        public string Durumu { get; set; } //sıfır- ikinci el 
    }
}
