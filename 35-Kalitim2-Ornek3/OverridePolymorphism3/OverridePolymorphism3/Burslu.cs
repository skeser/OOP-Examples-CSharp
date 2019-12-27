using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverridePolymorphism3
{
    class Burslu: Ogrenci
    {
        // 1-attiributes
        // 2-properties
        // 3-auto-implement properties
        public decimal BursOrani { get; set; }
        public decimal BursIndirim { get; set; }
        // 4- custom auto-implement property      
        // 5-constructure
        public Burslu()
        {
            Console.WriteLine("Burslu constructure calisti.");
        }
        // if base class : 6-virtual methods
        // if extended :  7-overrided methods.
        public override void DersUcretHesapla()
        {
            base.DersUcretHesapla();//dersucret e erisim.(miras..)
            // DersUcret : base class'dan auto-implement property get.
            this.BursIndirim = DersUcreti * BursOrani;
            // dersucret:miras, base sayesinde erisildi.
            dersucret = DersUcreti - BursIndirim;
        }
        // 8-methods
        public decimal getDersUcret()
        {
            /*
             *  dersucret : base class'dan miras. 
             *  protected oldugu icin formdan erisilemez.
             *  bu yolla formdan erisime aciliyor.
             */
            return dersucret;
        }
    }
}
