using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DikdortgenPrizmaOOP
{
    class DikdortgenPrizma
    {
        private float en;
        private float boy;
        private float yukseklik;

        public float hacimHesapla(float en, float boy, float yukseklik)
        {
            this.en = en;
            this.boy = boy;
            this.yukseklik = yukseklik;

            return (this.en * this.boy * this.yukseklik);
        }
    }
}
