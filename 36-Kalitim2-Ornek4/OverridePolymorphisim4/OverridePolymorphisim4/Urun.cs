using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverridePolymorphisim4
{
    class Urun
    {
        // 1-attiributes
        // 2-properties
        // 3-auto-implement properties
        public string Ad { get; set; }
        public decimal Fiyat { get; set; }
        // 4- custom auto-implement property      
        // 5-constructure
        // if base class : 6-virtual methods
        public virtual string Validasyon()
        {
            string hata = "";
            if( (this.Ad == "") || (this.Ad == null) )
            {
                hata += "Ad boş olamaz.." + Environment.NewLine; 
            }
            if (this.Fiyat ==0)
            {
                hata += "Fiyat 0 olamaz.." + Environment.NewLine;
            }
            return hata;
        }
        // if extended :  7-overrided methods.
        // 8-methods
    }
}
