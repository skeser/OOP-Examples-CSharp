using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstObjInitFark
{
    class Isci
    {
        public int KimlikNo { get; set; }
        public int Maas { get; set; }
        public string Mesaj { get; set; }

        public Isci()
        {
            this.Maas = 993;
            this.Mesaj = "Kimlik no :" + this.KimlikNo + "\nMaaş :" + this.Maas;
        }
    }
}
