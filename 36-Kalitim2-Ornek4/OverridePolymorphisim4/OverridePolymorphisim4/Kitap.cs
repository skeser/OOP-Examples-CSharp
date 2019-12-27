using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverridePolymorphisim4
{
    class Kitap : Urun
    {

        // 1-attiributes
        // 2-properties
        // 3-auto-implement properties
        public string ISBN { get; set; }
        public string Yazar { get; set; }
        // 4- custom auto-implement property      
        // 5-constructure
        // if base class : 6-virtual methods
        // if extended :  7-overrided methods.
        public override string Validasyon()
        {
            string hataKitap = "";
            if ( (this.ISBN == "") || (this.ISBN == null))
            {
                hataKitap += "ISBN bos olamaz.." + Environment.NewLine;
            }
            if ( ( this.Yazar == "" ) || ( this.Yazar == null ))
            {
                hataKitap += "Yazar adi bos olamaz.." + Environment.NewLine;
            }
            return hataKitap;

        }
        // 8-methods
    }
}
