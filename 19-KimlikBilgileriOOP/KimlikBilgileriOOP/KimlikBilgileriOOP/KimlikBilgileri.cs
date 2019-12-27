using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimlikBilgileriOOP
{
    public class KimlikBilgileri
    {
        public ulong kimlikNo;
        public string ad;
        public string soyad;
        //protected string dogumYeri; // protect yaparsak form başka class olduğu için erişilemiyor..
        public string dogumYeri;
        public DateTime dogumTarihi;
        public string kimlikBilgileriGoster()
        {
            return "Kimlik No : " + kimlikNo.ToString() + "\n" +
                    "Ad :" + ad + "\n" +
                    "Soyad :" + soyad + "\n" +
                    "Dogum Yeri :" + dogumYeri + "\n" +
                    "Dogum Tarihi :" + dogumTarihi.ToShortDateString();
                 
        }
    }
}
