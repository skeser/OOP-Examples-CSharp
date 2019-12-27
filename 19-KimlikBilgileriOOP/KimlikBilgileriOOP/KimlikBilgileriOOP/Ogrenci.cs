using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimlikBilgileriOOP
{
    
    public class Ogrenci
    {
        enum eProgramTur
        {
            Lisans,
            YL,
            Doktora
        }

        public string ogrNo;
        //public eProgramTur GetEProgramTur;
        public string birim;
        public string bolum;
        public KimlikBilgileri kimlikBilgi;

        public string ogrenciBilgiGoster()
        {
            return "Öğrenci No :" + ogrNo + "\n" +
                    "Birim :" + birim + "\n" +
                    "Bölüm :" + bolum + "\n" +
                    "Kimlik No :" + kimlikBilgi.kimlikNo.ToString() + "\n" +
                    "Ad :" + kimlikBilgi.ad + "\n" +
                    "Soyad :" + kimlikBilgi.soyad + "\n" +
                    "Dogum Yeri :" + kimlikBilgi.dogumYeri + "\n" +
                    "Dogum Tarihi :" + kimlikBilgi.dogumTarihi.ToShortDateString();
        }
    }
}
