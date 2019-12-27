using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OverridePolymorphism3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showOverridedObjectsBT_Click(object sender, EventArgs e)
        {
            Ogrenci o = new Ogrenci();
            o.KrediSayisi = 14;
            o.DersUcretHesapla();
            MessageBox.Show("o.DersUcreti : " + o.DersUcreti.ToString());

            // Object Initializers yontemi !!
            Burslu b = new Burslu()
            {
                BursOrani = 0.1M,
                KrediSayisi = 14,
            };
            // overrided method runned.
            b.DersUcretHesapla();
            MessageBox.Show(
                "b.BursIndirim : " + b.BursIndirim.ToString() + "\n" +
                "Ogrenci.Burslu.DersUcreti (aslinda Ogrenci.dersucret): " + b.DersUcreti.ToString()
                );

        }
    }
}
