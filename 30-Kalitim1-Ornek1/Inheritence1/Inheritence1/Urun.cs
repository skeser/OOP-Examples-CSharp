using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence1
{
    class Urun
    {
        public int No { get; set; }

        /*
         *  protected string Ad { get; set; }
         *  yapılırsa;
         *  formdan erişilemiyor.
         *  Kitap ve Telefon class'larından erişileibliyor.
         *  
         *  private string Ad { get; set; }
         *  yapılırsa;
         *  formdan erişilemiyor,
         *  Kitap ve Telefon class'larında DA erişilemiyor.
         */
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public decimal Fiyat { get; set; }
   
    }
}
