using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoktaKenar
{
    public class Nokta
    {
        // iki adet auto-implement property.. özellik. uye değil.
        public double X { get; set; }
        public double Y { get; set; }
        
        public Nokta (double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}
