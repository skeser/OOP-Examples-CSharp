using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsyeriApp2
{
    class Isyeri
    {
        // 1-attiributes
        //private List<Calisan> Calisans = new List<Calisan>();
        // 2-properties
        // 3-auto-implement properties
        public string IsyeriAd { get; set; }
        // 3.1- custom class auto-implement properties
        public Adres Adres { get; set; }
        // 4-auto-implement custom property    
        public List<Calisan> Calisans { get; private set; }
            // 4.1-custom class custom auto-implement property

        // 5-constructure
        public Isyeri()
        {
            /*
             *  Adres ve Isyeri class'lari arasındaki
             *  compositon (is made of) (1-1)  iliski kodda asagidaki 
             *  satir sayesinde gercekleniyor.
             *  Isyeri türünden bir nesne olusturuldugunda;
             *  Adres turunden bir nesne otomatik olarak initialize ediliyor.
             */
            this.Adres = new Adres();
        }


        // if base class : 6-virtual methods
        // if extended :  7-overrided methods.
        // 8-methods
        public void CalisanEkle(Calisan eklenecekCalisan)
        {
            /*
             *  Isyeri ve Calisan class'lari arasındaki
             *  aggregation (is part of) (1-n) iliski kodda asagidaki 
             *  satir sayesinde gercekleniyor.
             *  Isyerine calisan eklenmeye calisildiginda 
             *  Calisan sınıfından Collection (list) oluşturulup 
             *  içine değer atanıyor.
             *  Isyeri class'ından bir obje oluşturuludugunda otomatik olarak
             *  Calisan List'i OLUSTURULMUYOR, böylece Aggregation sağlanmış oluyor.
             */
            // varsa yeniden olusturma.
            if (this.Calisans == null)
            {
                this.Calisans = new List<Calisan>();
            }
            Calisans.Add(eklenecekCalisan);
        }
        public string CalisanListele()
        {
            string item = "";

            foreach (Calisan c in Calisans)
            {
                item += "Calisan.Isyeri.IsyeriAd :" + c.Isyeri.IsyeriAd + "\n" +
                        "Calisan.Kisi.TCKimlikNo :" + c.TCKimlikNo + "\n" +
                        "Calisan.Kisi.Isim :" + c.Isim + "\n" +
                        "Calisan.Departman :" + c.Departman + "\n" +
                        "Calisan.Gorev :" + c.Gorev + "\n" +
                        "---------------------------------" + "\n";
            }
            return item;

        }
        // if abstract class : 9- abstract methods
        // --
    }
}
