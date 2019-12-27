using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhertance3
{
    class Urun
    {
        public int No { get; private set; }
        public string Ad { get; set; }

        public Urun()
        {
            Random rU = new Random();
            this.No = rU.Next(1, 10000);
            Console.WriteLine("Urun Constucture calisti random u.No : " + 
            this.No.ToString()
            );
        }

    }
}
