using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane
{
    public class Kutuphane
    { 
        /*
         * Kutuphane ile Kitap arasi composition(is made of : kutuphane kitaplardan oluşur.)
         * turunde ilişki burada tanımlanmış.
         * bir kütüphane birden çok kitap içeriri. içi dolu baklava.
         * Aslında Aggregation ve Composition turu ilişkiler daha çok varlıkları 
         * nasıl kullandığımızla ortaya çıkan şeyler.
         * */
        private List<Kitap> kList = new List<Kitap>();

        public void kitapEkle(Kitap gelenKitap)
        {
            // bağımlılığın tersine cevrimi..
            // objeyi parametre olarak aldik. istediğin yerde sakla.
            // yukarısı nerede saklandığı ile ilgilenmiyor.
            // kitap objeleri list yapısı (collection) içinde tutuluyor. 
            kList.Add(gelenKitap);
        }
        public string kitapListele()
        {
            string item = "null";
            foreach (Kitap k in kList)
            {
                item += "ISBN : " + k.KitapOzellik.ISBN +
                        "Kitap Adi : " + k.KitapOzellik.KitapAdi +
                        "Yazar :" + k.KitapOzellik.Yazar +
                        "Alis Tarih :" + k.alisTarih.ToString() +
                        "İade Tarih :" + k.iadeTarih.ToString() + Environment.NewLine;
            }
            return item;
        }
        public void kutuphaneBosalt()
        {
            kList.Clear();
        }

    }
}
