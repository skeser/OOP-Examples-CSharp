using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetotNesneAktarma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void PersonelBilgiDegistir(Personel p)
        {
            p.ad = p.ad.ToUpper();
            p.soyad = p.soyad.ToUpper();
        }

        private void testBT_Click(object sender, EventArgs e)
        {
            Personel per = new Personel();
            per.ad = adTB.Text;
            per.soyad = soyadTB.Text;

            PersonelBilgiDegistir(per);

            adTB.Text = per.ad;
            soyadTB.Text = per.soyad;
        }
    }
}
