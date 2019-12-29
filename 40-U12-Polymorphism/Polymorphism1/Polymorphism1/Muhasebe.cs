using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism1
{
    class Muhasebe :Personel
    {
        public int MesaiGunSay { get; set; }

        public override decimal MaasHesapla()
        {
            return base.MaasHesapla() + (this.MesaiGunSay * base.MaasHesapla() / MESAIGUNSAY);
        }
    }
}
