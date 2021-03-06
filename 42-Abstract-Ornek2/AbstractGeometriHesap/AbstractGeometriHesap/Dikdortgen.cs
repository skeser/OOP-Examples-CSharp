﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGeometriHesap
{
    public class Dikdortgen:Sekil
    {
        /*
        * base class'daki abstract methodlar override edilmek zorunda,
        * CevreHesapla() ve AlanHesapla() 
        * override edilmeseydi HATA alirdik.
        */
        public override void CevreHesapla(double x, double y)
        {
            //throw new NotImplementedException();
            this.cevre = 2 * (x + y);   // abstract Sekil'den miras.
            Console.WriteLine("Dikdortgen.CevreHesapla() calisti. (override abstract Sekil.CevreHesapla()) :" + this.cevre.ToString());
        }
        public override void AlanHesapla(double x, double y)
        {
            //throw new NotImplementedException();
            this.alan = x * y;  // abstract Sekil'den miras.
            Console.WriteLine("Dikdortgen.AlanHesapla() calisti. (override abstract Sekil.CevreHesapla()) :" + this.alan.ToString());
        }
    }
}
