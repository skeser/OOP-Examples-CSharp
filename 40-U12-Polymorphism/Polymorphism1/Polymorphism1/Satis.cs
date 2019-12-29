using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism1
{
    class Satis : Personel
    {
        public decimal AylikCiro { get; set; }
        public decimal Prim 
        { 
            get 
            { 
                return AylikCiro * 0.1M; 
            } 
        }
        //public override int AsgariUcret => base.AsgariUcret;
        public override int AsgariUcret 
        {
            get
            {
                return 5000;
            }
        }
        /*
         * Personel.AsgariUcret yukarida ezildigi icin
         * base.MaasHesapla() calistiginda;
         * Personel.AsgariUcret yerine Satis.AsgariUcret'i baz aliyor ! - dikkat ! 
         */

        public override decimal MaasHesapla()
        {
            return base.MaasHesapla() + this.Prim;
        }
    }
}
