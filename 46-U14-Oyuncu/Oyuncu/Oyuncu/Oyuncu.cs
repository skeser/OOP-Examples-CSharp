using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oyuncu
{
    public class Oyuncu
    {
        public string Ad { get; set; }
        public int Yas { get; set; }
        public Silah Silah { get; set; }

        public string NisanAl()
        {
            if (Silah is AtesliSilah)
            {
                if (this.Silah is IYakinlastirabilir)
                {
                    return ((IYakinlastirabilir)Silah).Yakinlastir();
                }
                else
                {
                    return "gez goz arpacik gorunumu";
                }
            }
            else
            {
                return "bicak dik konumda";
            }
        }
        public string Saldir()
        {
            return "saldiri gerceklestirildi.";
        }
    }
}
