using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract1
{
    public class Kopek: Hayvan
    {
        // 1-attiributes
        // 2-properties
        // 3-auto-implement properties
        // 4- custom auto-implement property      
        // 5-constructure
        public Kopek(string kopekAdi):base(kopekAdi) // bu ne ?
        {

        }
        // if base class : 6-virtual methods
        // if extended :  7-overrided methods.
        public override string SesCikar()
        {
            // throw new NotImplementedException(); bu ne ?
            return "hav hav";
        }
        // 8-methods
    }
}
