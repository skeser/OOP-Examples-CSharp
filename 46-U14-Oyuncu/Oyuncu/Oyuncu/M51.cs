using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oyuncu
{
    public class M51 : AtesliSilah, IYakinlastirabilir
    {
        public string Yakinlastir()
        {
            return "silah durbunle yakinlastirildi.";
        }
    }
}
