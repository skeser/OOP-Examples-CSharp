using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoImplementedProperty
{
    public class Isci
    {
        /**
         * Auto-Implemented Property kullanildigi icin 
         * backing filed olarak adlandirilan asagidaki bildirime gerek yoktur.
        //private int kimlikNo;
        /**
         * Auto Implemented Property kullanımı;
         * get ve set metodlari ozellestrilemez..
         * Auto Implemented Property kullanımının;
         * Avantaji : 14. satirdaki backing field bildirimene gerek birakmiyor..
         * DEZAVANTAJI : Property'ler ozellestrilemiyor...
         * icinde yazıp 100 den buyuk set edilmeye calisilirsa su olsun diyemiyorsun..
         **/
        public int KimlikNo { get; set; }

        private int testNo;
        public int TestNo { get; set; }

    }
}
