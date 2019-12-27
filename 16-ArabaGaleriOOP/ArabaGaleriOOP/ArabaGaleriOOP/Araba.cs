using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabaGaleriOOP
{
    public class Araba
    {
        private string marka;
        private short model;
        private string renk;

        public string Marka { get { return marka;  } set { marka = value;  } }
        public short Model { get { return model; } set { model = value; } }
        public string Renk { get { return renk; } set { renk = value; } }

        public override string ToString()
        {
            return marka + " " + Convert.ToString(model) + " " + renk;
        }

    }
}
