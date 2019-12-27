using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane
{
    public class Kitap
    {
        //2 adet auto-implement propery tanımlaniyor.ozellik. uye değil.
        public DateTime alisTarih { get; set; }
        public DateTime iadeTarih { get; set; }
        /*
         * Kitap ve KitapOzellik sinifları arası ilişiki aggregation'dur.
         * gevşek bağlığılık. is part of.
         * tanımlama(decleration) auto-implement propert tarzinda yapılmış
         * */
        public KitapOzellik KitapOzellik { get; set; }
    }
}
