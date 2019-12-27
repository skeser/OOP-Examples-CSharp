using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhertance3
{
    class Kitap :Urun
    {

        public int kNo { get; private set; }
        public string ISBN { get; set; }
        public string Yazar { get; set; }
        public Kitap()
        {
            Random rK = new Random();
            this.kNo = rK.Next(1,1000);
            Console.WriteLine("Kitap Constucture calisti random k.kNo : " + this.kNo.ToString());
        }
    }
}
