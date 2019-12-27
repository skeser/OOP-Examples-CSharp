using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GirSayFaktoriyelBul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int faktoriyel(int sayi)
        {
            int carpim;
            carpim = 1;
            //for (int i = 1; sayi >= i; i++)
            for ( int i = sayi; i > 0; i--)
            {
                carpim = carpim * i;
                Console.WriteLine(i);
            }
            return carpim;
        }

        private void faktoriyelHesaplaBT_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(sayiTB.Text);
            sonucFaktoriyelLB.Text = Convert.ToString(faktoriyel(sayi));

        }
    }
}
