using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personel
{
    public class Personel
    {
        // 3 özellik için auto-implement property declarations
        public int KimlikNo { get; set; } 
        public decimal Maas { get; set; }
        public string Departman { get; set; }
        private string calisanConst = "null";
        
        public Personel()
        {
            this.calisanConst = "constructure 1 - default - calisti";
        }
        public Personel(int kimlikNo)
        {
            this.calisanConst = "constructure 2 calisti";
            this.KimlikNo = kimlikNo;
        }
        public Personel(int kimlikNo, string departman)
        {
            this.calisanConst = "constructure 3 calisti";
            this.KimlikNo = kimlikNo;
            this.Departman = departman;
        }
        public Personel(int kimlikNo, string departman, Decimal maas)
        {
            this.calisanConst = "constructure 4 calisti";
            this.KimlikNo = kimlikNo;
            this.Departman = departman;
            this.Maas = Maas;
        }
        public string personelBilgi()
        {
            return "TC :" + KimlikNo + "Departman : " + Departman + "Maas" + Convert.ToString(Maas) + "calisan cons: " + calisanConst;
        }
    }
}
