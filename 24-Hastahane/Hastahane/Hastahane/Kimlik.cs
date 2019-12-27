using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastahane
{
    public class Kimlik
    {
        // 3 adet özellik auto-implement property yontemi ile..
        public int TcKimlik { get; private set; }
        public String Ad { get; private set; }
        public String Soyad { get; private set; }
        // api gibi davranan method kimlikNo'ya göre Ad ve Soyad özelliklerini set ediyor.
        public void kimlikBilgiDoldur(int kimlikNo)
        {
            TcKimlik = kimlikNo;
            Ad = "Ahmet";
            Soyad = "Aslan";
        }
        public string kimlikBilgiOku()
        {
            return "TC : " + Convert.ToString(TcKimlik) + "Ad :" + Ad + "Soyad :" + Soyad;
        }
        
        
    }
}
