using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U13Abstract1
{
    public abstract class OgrenciBase
    {
        public string Isim { get; set; }
        public short KrediSayisi { get; set; }
        protected decimal dersucret;
        public decimal DersUcreti { get { return dersucret; } }
        private int birimDersUcreti;

        public OgrenciBase(int birimDersUcreti)
        {
            this.birimDersUcreti = birimDersUcreti;
        }

        public virtual void DersUcretiHesapla()
        {
            dersucret = KrediSayisi * birimDersUcreti;
        }
        // abstract method'larin govdesini yazamayiz.
        public abstract string OgrenciDurum();
    }
}
