using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CokluInterface
{
    /*
     *  Cocuk class'i;
     *  Kisi<<abstract>> class'i ile 
     *  ICalisabilen <<Interface>> ve IOynayabilen<<Interface>>
     *  lerini implemente ediliyor..
     *  interface'lerde declare edilen (bos govedeli) methodlarin
     *  govdeleri burada yazilacak, ZZORUNLU !
     */
    public class Cocuk : Kisi, ICalisabilen, IOynayabilen
    {
        public string Calis()
        {
            return "Runned : Cocuk.ICalisabilen<<interface>>.Calis() - BEN , #Cocuk.Kisi<<abstract>>.Isim#  :" + Isim + " calisirim.";
        }
        public string Oyna()
        {
            return "Runned : Cocuk.IOynayabilen<<interface>>.Calis() - BEN , #Cocuk.Kisi<<abstract>>.Isim#  :" + Isim + " oynarim.";
        }

    }
}
