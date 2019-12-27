using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaliHesapOOP
{
    public class Hali
    {
        private int alan;
        public int Alan {
            get
            {
                AlanHesapla();
                return alan;
            }
        }
        public int Genislik { get; set; }
        public int Uzunluk { get; set; }
        private void AlanHesapla()
        {
            alan = Uzunluk * Genislik;
        }
    }
}
