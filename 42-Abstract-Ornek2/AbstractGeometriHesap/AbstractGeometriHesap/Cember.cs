using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGeometriHesap
{
    public class Cember:Sekil
    {
        /*
        * base class'daki abstract methodlar override edilmek zorunda,
        * CevreHesapla() ve AlanHesapla() 
        * override edilmeseydi HATA alirdik.
        */
        public override void CevreHesapla(double x, double y)
        {
            //throw new NotImplementedException();
            // cevre 2.pi.r / x = pi y = r.
            this.cevre = 2 * x * y; // abstract Sekil'den miras.
            Console.WriteLine("Cember.CevreHesapla() calisti. (override abstract Sekil.CevreHesapla()) :" + this.cevre.ToString());
        }
        public override void AlanHesapla(double x, double y)
        {
            //throw new NotImplementedException();
            // alan pi.r * r  / x = pi y = r.
            this.alan = x * y * y; // abstract Sekil'den miras.
            Console.WriteLine("Cember.AlanHesapla() calisti. (override abstract Sekil.CevreHesapla()) :" + this.alan.ToString());
        }
    }
}
