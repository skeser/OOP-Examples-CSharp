using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsyeriApp2
{
    class Kisi
    {
        // 1-attiributes
        // 2-properties
        // 3-auto-implement properties
        public int TCKimlikNo { get; set; }
        public string Isim { get; set; }
        // 3.1- custom class auto-implement properties
        public Adres Adres { get; set; }
        // 4- custom auto-implement property      
        // 5-constructure
        public Kisi()
        {
            /*
             *  Adres ve Kisi class'lari arasındaki
             *  compositon (1-1) iliski kodda asagidaki 
             *  satir sayesinde gercekleniyor.
             *  Kisi türünden bir nesne olusturuldugunda;
             *  Adres turunden bir nesne otomatik olarak initialize ediliyor.
             */
            this.Adres = new Adres();
        }
        // if base class : 6-virtual methods
        // if extended :  7-overrided methods.
        // 8-methods
        // if abstract class : 9- abstract methods
    }
}
