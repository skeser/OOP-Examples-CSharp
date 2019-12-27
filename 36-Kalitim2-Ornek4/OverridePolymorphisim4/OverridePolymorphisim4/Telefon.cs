using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverridePolymorphisim4
{
    class Telefon : Urun
    {
        // 1-attiributes
        // 2-properties
        // 3-auto-implement properties
        public string Marka { get; set; }
        public string Model { get; set; }
        // 4- custom auto-implement property      
        // 5-constructure
        // if base class : 6-virtual methods
        // if extended :  7-overrided methods.
        public override string Validasyon()
        {
            string hataTelefon = "";
            if ( ( this.Marka == "" ) || ( this.Marka == null ))
            {
                hataTelefon += "Marka bos gecilemez.." + Environment.NewLine;
            }
            if ( ( this.Model == "" ) || ( this.Model == null ))
            {
                hataTelefon += "Model adi bos gecilemez.." + Environment.NewLine;
            }
            return hataTelefon;
        }
        // 8-methods
    }
}
