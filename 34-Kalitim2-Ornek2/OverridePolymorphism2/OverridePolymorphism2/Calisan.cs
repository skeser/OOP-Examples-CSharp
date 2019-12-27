using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverridePolymorphism2
{
    class Calisan :Personel
    {
        public Calisan() { }
        public override void maasHesapla()
        {
            /*
             * parent'daki maas'a erisiliyor.
             * */
            base.maasHesapla();
            maas *= 1.5M;
        }
    }
}
