using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U13Abstract1
{
    class NormalOgrenci : OgrenciBase
    {
        // abstract base class'daki birimDersUcreti degeri kullanılıyor.
        public NormalOgrenci(int birimDersUcreti):base(birimDersUcreti)
        {

        }
        public override void DersUcretiHesapla()
        {
            base.DersUcretiHesapla();

        }
        public override string OgrenciDurum()
        {            
            //throw new NotImplementedException();
            return "Normal Ogrenci";
        }
    }
}
