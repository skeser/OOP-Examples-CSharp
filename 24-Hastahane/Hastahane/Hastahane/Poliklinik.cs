using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastahane
{
    public class Poliklinik
    {
        public String PolAdi { get; set; }
        public String PolTarih { get; set; }
        public String DoktorAdi { get; set; }
        public String PolBilgi { get; set; }

        public string polBilgiOku()
        {
            return "Poliklinik Adi : " + PolAdi + "Poliklinik Tarihi :" + PolTarih + "Poliklinik Bilgi : " + PolBilgi;
        }
    }
}
