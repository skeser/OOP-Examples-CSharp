using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AraliktakiTekCiftToplam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hesaplaButton_Click(object sender, EventArgs e)
        {
            int baslangic, bitis, tekToplam, ciftToplam;
            tekToplam = 0;
            ciftToplam = 0;
            baslangic = 0;
            bitis = 0;

            baslangic = Convert.ToInt32(baslangicTextBox.Text);
            bitis = Convert.ToInt32(bitisTextBox.Text);


            for (int i = baslangic; i <= bitis; i++)
            {
                if ( i % 2 != 0 ) {
                    // sayı tek ise
                    tekToplam = tekToplam + i;
                } else {
                    // sayı tek degil ise -> cifttir.
                    ciftToplam = ciftToplam + i;
                }
            }// for close

            // show results..
            tekToplamShowLabel.Text = Convert.ToString(tekToplam);
            ciftToplamResultLabel.Text = Convert.ToString(ciftToplam);
        }
    }
}
