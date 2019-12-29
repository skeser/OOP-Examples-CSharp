using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism1
{
    class Personel
    {
        //private const decimal asgari_ucret = 1300;
        protected const int MESAIGUNSAY = 22;
        public string Ad { get; set; }
        public string Soyad { get; set; }
        /*
         * soru 2 yi saglamak icin property;
         * base class da virtual yapılır.
         * child class'larda ezen property'ler yazılır.
         */

        public virtual int AsgariUcret
        {
            get
            {
                return 1300;
            }
        }

        public virtual decimal MaasHesapla()
        {
            return 2 * this.AsgariUcret;
        }

    }
}
