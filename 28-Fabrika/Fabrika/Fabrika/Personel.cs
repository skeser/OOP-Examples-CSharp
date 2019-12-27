using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrika
{
    public class Personel
    {
        public int PerNo { get; set; }
        public string Birim { get; set; }
        /*
         * Bir Personelin 1 kimlik bilgisi olur.
         * ilişiki 1 e 1 dir.
         * ilişiki türü aggregation'dur. gevşek bağlı.
         * personelin kimlik bilgisi olmadan da personel var olabilir.
         * */
        public Kimlik K { get; set; }

    }
}
