using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGeometriHesap
{
    class Program
    {
        static void Main(string[] args)
        {
            Kare k = new Kare();
            k.CevreHesapla(4,4);
            Console.WriteLine("Hesaplanmıs Cevre(Kare.Sekil.Cevre) : " + k.Cevre.ToString());
            k.AlanHesapla(4,4);
            Console.WriteLine("Hesaplanmıs Alan(Kare.Sekil.Alan) : " + k.Alan.ToString());
            Console.WriteLine("-----------------------------------------------------------------------------");
            Dikdortgen d = new Dikdortgen();
            d.CevreHesapla(6,8);
            Console.WriteLine("Hesaplanmıs Cevre(Dikdortgen.Sekil.Cevre) : " + d.Cevre.ToString());
            d.AlanHesapla(6, 8);
            Console.WriteLine("Hesaplanmıs Alan(Dikdortgen.Sekil.Cevre) : " + d.Alan.ToString());
            Console.WriteLine("-----------------------------------------------------------------------------");
            Cember c = new Cember();
            c.CevreHesapla(Math.PI, 7);
            Console.WriteLine("Hesaplanmıs Cevre(Cember.Sekil.Cevre) : " + c.Cevre.ToString());
            c.AlanHesapla(Math.PI,7);
            Console.WriteLine("Hesaplanmıs Alan(Cember.Sekil.Cevre) : " + c.Alan.ToString());
            
            Console.ReadKey();
        }
    }
}
