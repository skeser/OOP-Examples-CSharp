using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverridePolymorphism3
{
    class Ogrenci
    {
        // 1-attiributes
        private const decimal BIRIM_DERS_UCRET = 55.75M;
        protected decimal dersucret = 0;
        // 2-properties
        // 3-auto-implement properties
        public string Ad { get; set; }
        public short KrediSayisi { get; set; }
        // 4- custom auto-implement property
        public decimal DersUcreti
        {
            get
            {
                return this.dersucret;
            }
        }
        // 5-constructure
        public Ogrenci()
        {
            Console.WriteLine("Ogrenci constructure calisti.");
        }
        // 6-virtual methods
        public virtual void DersUcretHesapla()
        {
            this.dersucret = this.KrediSayisi * BIRIM_DERS_UCRET;
        }
        // 7-methods


    }
}
