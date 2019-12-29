using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface1
{
    public abstract class Kisi
    {
        public string Isim { get; set; }
        public virtual string BilgiGoster()
        {
            return "Kisi(abstract).Isim :" + this.Isim;
        }
    }
}
