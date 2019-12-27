using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CumleHarfYazdir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void harfYazdirBT_Click(object sender, EventArgs e)
        {
            string cumle = cumleTB1.Text;
            Char[] charDizi = new char[50];

            charDizi = cumle.ToCharArray(0,50);
            //charDizi = cumleTB1.Text.ToCharArray(0,50);

            string mesaj = "";
            for (int i = 0; i < charDizi.Length; i++)
            {
                mesaj += charDizi[i].ToString() + "\n";
            }
            MessageBox.Show(mesaj);
        }

        private void cumleYazdirBT_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cumleTB1.Text);
        }
    }
}
