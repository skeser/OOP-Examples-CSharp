using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    public class Isci
    {
        private int kimlikNo;

        public int KimlikNo { get { return kimlikNo; } set { kimlikNo = value; } }

        public string karsilamaMesaji()
        {
            return "Hosgeldin" + kimlikNo + " no lu calisanimiz..";
        }
    }
}
