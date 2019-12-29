using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CokluInterafce2
{
    class Renault:Araba,IKontak
    {
        /*
         *  constructure upcast, base class'in ki kullaniliyor..
         **/
        public Renault(int maxHiz, int vitesSay):base(maxHiz, vitesSay)
        {
            
        }
        /*
         *  base class'daki abstract class'lar override ediliyor. 
         */
        public override string YakitTuket()
        {
            //throw new NotImplementedException();
            return "normal yakit tuketirim.";
        }
        /*
         * Ikontak interface'indeki methodların govdeleri 
         * buraya yazılmalı. ŞART
         */
        public string KontakAc()
        {
            return "kontak anahtarla acildi.";
        }
    }
}
