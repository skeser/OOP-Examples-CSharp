using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    class Urun
    {

        public int No { get; private set; }
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public decimal Fiyat { get; set; }

        public Urun()
        {
            Random r = new Random();
            this.No = r.Next(1, 10000);
            Console.WriteLine("Urun Constucture calisti r : " + this.No.ToString());
        }
    }
}
