using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverridePolymorphism2
{
    class Personel
    {
        private const decimal ASGARIUCRET = 1000;
        private const decimal AILEGECIMINDIRIM = 500;
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
            maas = ASGARIUCRET + AILEGECIMINDIRIM;
        }
    }
}
