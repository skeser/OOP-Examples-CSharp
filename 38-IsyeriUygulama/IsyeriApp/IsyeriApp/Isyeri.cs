using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsyeriApp
{
    class Isyeri
    {
        // 1-attiributes
        private List<Calisan> Calisans = new List<Calisan>();
        // 2-properties
        // 3-auto-implement properties
        public string Ad { get; set; }
        // 3.1- custom class auto-implement properties
        public Adres Adres { get; set; }
        // 4-auto-implement custom property    
        // 4.1-custom class custom auto-implement property

        // 5-constructure
      
        // if base class : 6-virtual methods
        // if extended :  7-overrided methods.
        // 8-methods
        public void CalisanEkle(Calisan eklenecekCalisan)
        {
            Calisans.Add(eklenecekCalisan);
        }
        // if abstract class : 9- abstract methods
        // --
        public string CalisanListele()
        {
            string item = "";

            foreach (Calisan c in Calisans)
            {
                item += "Calisan.Kisi.TCKimlikNo :" + c.TCKimlikNo + "\n" +
                        "Calisan.Kisi.Isim :" + c.Isim + "\n" +
                        "Calisan.Departman :" + c.Departman + "\n" +
                        "Calisan.Gorev :" + c.Gorev + "\n" +
                        "---------------------------------" + "\n";
            }
            return item;
            
        }
        
    }
}
