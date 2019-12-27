using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OverridePolymorphism1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showOverridedBT_Click(object sender, EventArgs e)
        {
            Personel p = new Personel();
            p.maasHesapla();
            MessageBox.Show("p maas :" + p.Maas.ToString());

            Calisan c = new Calisan();
            c.maasHesapla();
            MessageBox.Show("c maas :" + c.Maas.ToString());

            Mudur m = new Mudur();
            m.maasHesapla();
            MessageBox.Show("m maas :" + m.Maas.ToString());
        }
    }
}
