using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGeometriHesap
{
    public abstract class Sekil
    {
        protected double cevre;
        public double Cevre { get { return cevre; } }
        protected double alan;
        public double Alan { get { return alan; } }

        /*
         * abstract method oldugu icin govdeleri boş olmalı.
         * abstract class icinde abstract olmayan method yazılabilir.
         * govdeleri dolu olabilir.
         */
        public abstract void CevreHesapla(double x, double y);
        public abstract void AlanHesapla(double x, double y);
    }
}
