using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane
{
    public class KitapOzellik
    {
        /*
         * 3 adet auto-implement property tanımlaniyor.
         * public oldukları için özelliktir.
         * */
        public string Yazar { get; set; }
        public string KitapAdi { get; set; }
        public string ISBN { get; set; }
    }
}
