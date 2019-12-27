using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuOrnek
{
    public class Kutu
    {
        // 3 adet auto-implmented property taımlaniyor - ozellik, uye degil.
        public int Yukseklik { get; set; }
        public int Genislik { get; set; }
        public int Derinlik { get; set; }
        // constructure method..
        public Kutu()
        {
            this.Yukseklik = 1;
            this.Genislik = 1;
            Derinlik = 1;
        }
        public string customKutuGoster(int kutuNo)
        {
            return kutuNo.ToString() + ". kutu : " + "yukseklik : " + Yukseklik.ToString() + " | genislik :" + Genislik.ToString() + " | derinlik : " + Derinlik.ToString() + "\n";
        }
        // method..
        public string kutuOlcuGoster()
        {
            return "yukseklik : " + Yukseklik.ToString() + " | genislik :" + Genislik.ToString() + " | derinlik : " + Derinlik.ToString();
        }
    }
}
