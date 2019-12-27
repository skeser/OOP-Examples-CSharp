using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabaOOP
{
    public class Araba
    {
        public string marka;
        public short model;
        public string renk;

        private Decimal fiyatKDVsiz;

        public Decimal FiyatKDVsiz { get { return fiyatKDVsiz; } set { fiyatKDVsiz = value; } }

    }
}
