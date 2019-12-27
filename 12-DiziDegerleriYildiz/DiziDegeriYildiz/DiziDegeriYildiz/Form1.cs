using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiziDegeriYildiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] dizi = { 19, 3, 15, 7, 11, 9, 13, 5, 17, 1 };
        private void button1_Click(object sender, EventArgs e)
        {
            String yildiz = "";
            int sayac = 0;

            for (int i = 0; i < dizi.Length; i++)
            {
                for( int z = 1; z <= dizi[i]; z++)
                {
                    yildiz = yildiz + "*";
                    sayac++;
                } // ic for close
                MessageBox.Show("Dizinin " + i + " . elemanını " + sayac + " yildiz sayisi : " + yildiz);
                sayac = 0;
            }// dıs for close
        }
    }
}
