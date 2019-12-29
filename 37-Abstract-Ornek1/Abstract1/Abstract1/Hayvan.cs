using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract1
{
    public abstract class Hayvan
    {
        // 1-attiributes ??
        // 2-properties
        // 3-auto-implement properties
        public string Cins { get; set; }
        // 4- custom auto-implement property      
        public string Ad { get; private set; }
        // 5-constructure
        public Hayvan(string ad)
        {
            this.Ad = ad;
        }
        // if base class : 6-virtual methods
        // if extended :  7-overrided methods.
        // 8-methods ??
        // 9- abstract methods : govdesi yazılamaz.
        public abstract string SesCikar();

    }
}
