using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverridePolymorphism1
{
    class Personel
    {
        public string Ad { get; set; }
        /*
         * maas ile Maas farklı property'ler !
         * */
        protected decimal maas = 0;
        public decimal Maas
        {
            get
            {
                return maas;
            }
        }
        // constructure
        public Personel()
        {
        }
        public virtual void maasHesapla()
        {
           maas = 0;
        }
    }
}
