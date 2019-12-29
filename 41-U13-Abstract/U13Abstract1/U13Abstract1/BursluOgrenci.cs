using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U13Abstract1
{
    public class BursluOgrenci : OgrenciBase
    {
        public decimal BursOrani { get; set; }
        public decimal BursIndirimi { get; private set; }
        // abstract base class'daki birimDersUcreti degeri kullanılıyor.
        public BursluOgrenci(int birimDersUcreti): base(birimDersUcreti)
        {

        }
        public override void DersUcretiHesapla()
        {
            base.DersUcretiHesapla();
            BursIndirimi = dersucret * BursOrani;
            dersucret = dersucret - BursIndirimi;
        }
        public override string OgrenciDurum()
        {
            return "Burslu Ogrenci";
            //throw new NotImplementedException();
        }

    }
}
