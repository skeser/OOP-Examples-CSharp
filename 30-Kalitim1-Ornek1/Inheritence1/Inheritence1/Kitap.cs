using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence1
{
    class Kitap : Urun
    {
        public string ISBN { get; set; }
        public string Yazar { get; set; }
    }
}
