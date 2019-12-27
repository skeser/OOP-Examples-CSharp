using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverridePolymorphism2
{
    class Mudur : Personel
    {
        public Mudur() { }
        public override void maasHesapla()
        {
            /*
             * parent'daki maas'a erisiliyor.
             * */
            base.maasHesapla();
            maas *= 4M;
        }
    }
}
