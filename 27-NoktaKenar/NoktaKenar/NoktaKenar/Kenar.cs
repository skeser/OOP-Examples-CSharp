using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoktaKenar
{
    public class Kenar
    {
        private Nokta n1;
        private Nokta n2;

        public Kenar(Nokta n1, Nokta n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }
        public string kenarOku()
        {
            // eğer Nokta class'ındaki X ve Y property'leri public olmasaydı erişemezdik..
            return "( " + n1.X + " , " + n1.Y + " ) - ( " + n2.X + " , " + n2.Y + " )";
        }
    }
}
