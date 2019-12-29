using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CokluInterafce2
{
    class Audi:Araba,IKontak,IKlima,IUstuAcilabilable
    {
        /*
         * 1-) imlemete edilen abstract Araba class'indaki
         * abstract methodlar burada override edilmeli ZORUNLU
         * 
         * 2-) 3 interface implemente edilmiş, hepsindeki methodlar
         * burada yazıalcak ZORUNLU
         */
         /*
          * base sinifin const.. kullaniliyor.
          */
        public Audi(int maxHiz, int vitesSay):base(maxHiz, vitesSay)
        {
           
        }
        /*
         *  base abstract class daki abstract method implemete ediliyor..
         *  yazılıyor ZORUNLU !
         **/
        public override string YakitTuket()
        {
            //throw new NotImplementedException();
            return "Çok yakit tuketirim.";
        }
        /*
         * Araba<<abstract>>.Plaka() virtual tanımlı.
         * ezmeye gerek yok.
         * abstract olsaydı override edilmesi ZORUNLUYDU.
         */
        public override string Plaka()
        {
            //return base.Plaka();
            return "45 SB 455";
        }

        // IKontak.KOntakAc() 
        public string KontakAc()
        {
            return "kontak start butonu ile acildi.";
        }
        // IKlima.KlimaTip()
        public string KlimaTip()
        {
            return "Dijital klima var.";
        }
        // IKlima.KlimaCalistir()
        public string KlimaCalistir()
        {
            return "Klima dijital ekrandan acildi.";
        }
        // IUstuAcilabiable.UstunuAc()
        public string UstunuAc()
        {
            return "Sunroof Acildi.";
        }
    }
}
