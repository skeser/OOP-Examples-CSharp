using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhertance3
{
    class Telefon :Urun
    {
        public int tNo { get; private set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public Telefon()
        {
            Random rT = new Random();
            this.tNo = rT.Next(1, 1000);
            Console.WriteLine("Telefon Constucture calisti random t.tNo : " + this.tNo.ToString());
        }
    }
}
