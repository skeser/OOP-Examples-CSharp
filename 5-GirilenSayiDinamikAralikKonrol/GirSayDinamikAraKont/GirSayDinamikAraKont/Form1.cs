using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GirSayDinamikAraKont
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String kontrolEt(int min, int max, int kontrol)
        {
            string resultTex = "null";

            if ( kontrol < min ) { resultTex = "girilen sayi min değerden kucuk | " + kontrol + " < " + min; }
            if ( kontrol >= min && kontrol <= max ) { resultTex = "Girilen sayı min ve max arasında | " + min + " <= " + kontrol + " <= " + max; }
            if ( kontrol > max ) { resultTex = "Girlen sayi max'dan buyuk  | " + max + " < " + kontrol; }


            return resultTex;
        }

        private void kontBT_Click(object sender, EventArgs e)
        {
            int sayMin, sayMax, sayKontrol;

            sayMin = Convert.ToInt32(minTB.Text);
            sayMax = Convert.ToInt32(maxTB.Text);

            sayKontrol = Convert.ToInt32(kontrolTB.Text);

            MessageBox.Show(kontrolEt(sayMin, sayMax, sayKontrol));
        }
    }
}
