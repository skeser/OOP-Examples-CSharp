using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastahane
{
    public class Hasta
    {
        //Kimlik sınıfından kimlik adli objenin bildirimi (declaration yapılıyor)
        private Kimlik kimlik;
        // Poliklinik Class turunden pol adlı obje için auto-implment property tanımlanıyor..
        // Custom class'a getter - setter yazılmış. DİKKAT ! onemli.
        // pol objesi ise Hasta - Poliklinik class ları arasında Aggregation - gevşek bağlılık
        // içi boş baklava ilişikisi kuruluyor..
        public Poliklinik pol { get; set; }
        /* Kimlik Class turunden Kimlik adlı obje için custom getter - setter yazılmış.
         * get : kimlik objesi yoksa implemente ediliyor.
         * Dikkat Kimlik ile kimlik aynı sınıftan ama farklı objeler..
         * */
        public Kimlik Kimlik
        {
            get
            {
                if (this.kimlik == null)
                {
                    this.kimlik = new Kimlik(); 
                }
                return this.kimlik;
            }
        }
    }
}
