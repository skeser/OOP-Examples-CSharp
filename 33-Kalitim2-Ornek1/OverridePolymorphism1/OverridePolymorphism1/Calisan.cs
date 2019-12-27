using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverridePolymorphism1
{
    class Calisan : Personel
    {
        public Calisan()
        {

        }
        public override void maasHesapla()
        {
            maas = 1500;
        }
    }
}
