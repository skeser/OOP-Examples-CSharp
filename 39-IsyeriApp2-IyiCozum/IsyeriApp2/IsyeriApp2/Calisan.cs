using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsyeriApp2
{
    class Calisan : Kisi
    {
        // 1-attiributes
        // 2-properties
        // 3-auto-implement properties
        public int SGKNo { get; set; }
        public string Gorev { get; set; }
        public string Departman { get; set; }
        // 3.1- custom class auto-implement properties
        public Isyeri Isyeri { get; set; }
        // 4- custom auto-implement property      
        // 5-constructure
        // if base class : 6-virtual methods
        // if extended :  7-overrided methods.
        // 8-methods
        // if abstract class : 9- abstract methods
    }
}
