using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract1
{
    public class Kedi : Hayvan
    {
        // 1-attiributes
        // 2-properties
        // 3-auto-implement properties
        // 4- custom auto-implement property      
        // 5-constructure
        public Kedi(string kediAd) : base(kediAd)
        {

        }
        // if base class : 6-virtual methods
        // if extended :  7-overrided methods.
        public override string SesCikar()
        {
            //throw new NotImplementedException(); ???
            return "Miaaavvv";
        }
        // 8-methods
    }
}
