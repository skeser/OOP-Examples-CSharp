using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oyuncu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OynaBT_Click(object sender, EventArgs e)
        {
            Oyuncu o1 = new Oyuncu();
            M51 m51 = new M51();
            o1.Ad = "Oyuncu 1";
            o1.Silah = m51;

            Oyuncu o2 = new Oyuncu();
            AK47 ak47 = new AK47();
            o2.Ad = "Oyuncu 2";
            o2.Silah = ak47;

            Oyuncu o3 = new Oyuncu();
            RamboBicagi ramboBicagi = new RamboBicagi();
            o3.Ad = "Oyuncu 3";
            o3.Silah = ramboBicagi;

            MessageBox.Show(
                            o1.Ad + " : " + o1.NisanAl() + "\n" +
                            o2.Ad + " : " + o2.NisanAl() + "\n" +
                            o3.Ad + " : " + o3.NisanAl() + "\n" +
                            o1.Ad + " : " + o1.Saldir() + "\n" +
                            o2.Ad + " : " + o2.Saldir() + "\n" +
                            o3.Ad + " : " + o3.Saldir() + "\n"
                );
        }
    }
}
