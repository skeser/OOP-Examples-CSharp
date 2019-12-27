using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverridePolymorphism1
{
    class Mudur : Personel
    {
        public Mudur()
        {

        }
        public override void maasHesapla()
        {
            maas = 4000;
        }
    }
}
