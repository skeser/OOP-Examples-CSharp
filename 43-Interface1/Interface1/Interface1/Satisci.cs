using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface1
{
    public class Satisci : Kisi,ICalisabilen
    {
        /*
        * Calis() ICalisabilen adli interfacede tanımlandıgı 
        * ve Ogretmen Class'i tarafından implemente edildigi icin
        * asagidaki methodu yazmak zorunludur.
        * yazılmazsa HATA
        * Kural : bir class bir interface'i implemente eder ise:
        * Class icinde interface'in methodlari yazilmalidir. 
        */
        public string Calis()
        {
            return "Satisciyim, satis yaparim.";
        }
        public override string BilgiGoster()
        {
            // base class'in return degerine ulasilip,donduruluyor.               
            return base.BilgiGoster();
        }
    }
}
