using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrika
{
    public class Fabrika
    {
        /* property'ler 
         * private/protect ise uye.
         * public ise özellik.
         * */
        public string FabrikaIsim { get; set; } // auto-implemen property.
        public string Adres { get; set; } // auto-implemen property.
        /* Fabrika sınıfı/tun time : objesi birden fazla personel turunde obje
         * barındıracağı için bu objeler bir veri yapısında ttulmalıdır.
         * burada List veri yapısı kulanılmış.
         * Alternatif personel tipinde dizi de de tutulabilirdi, dez avantajı 
         * kullanılıabilirlik olurdu. List veri tipiyle işlem yapmak daha kolay.
         * */
        private List<Personel> personeller = new List<Personel>(); 
        // Bir fabrika birden fazla personel içeriri ilişki 1 e n dir.
        // Fabrika ile Personel arasındaki ilişki turu ise composition.
        // Fabrika Personel olamadan fanksiyonlarini yerine getiremez..
        public Personel P { get; set; } // auto-implemen property. Personel turunde..     
        public void iseAl(Personel eklenecekPer)
        {
            /* run time : personel turundeki objeler veri yapısına atılıyor..
             * Burda liste atılmış.. dizi'yede atılaiblirdi.
             * ust taraf nereye atıldığı ile ilgilenmiyor..
             * bu da bağımlılığın tersine çevrilmesi oluyor..
             * */
            personeller.Add(eklenecekPer);
        }
        public void istenCikar()
        {
            personeller.Clear();
        }
        public string personelListele()
        {
            string liste = "";
            foreach (Personel p in personeller) {
                liste += "No: " + p.PerNo +
                         "Adı :" + p.K.Ad +
                         "Soyad : " + p.K.Soyad +
                         "Birim : " + p.Birim + Environment.NewLine;
            }
            return liste;
        }
    }
}
