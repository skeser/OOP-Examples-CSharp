using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OverridePolymorphisim4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void validationBT_Click(object sender, EventArgs e)
        {
            // initialize object..
            Urun u = new Urun();
            Telefon t = new Telefon();
            Kitap k = new Kitap();

            MessageBox.Show("u.Validasyon() : " + u.Validasyon());
            MessageBox.Show("t.Validasyon() : " + t.Validasyon());
            MessageBox.Show("k.Validayson() : " + k.Validasyon());

            // initialize objects with Object Initialize methods.
            Urun validatedU = new Urun()
            {
                Ad = "foo_Ad",
                Fiyat = 4
            };

            Telefon validatedT = new Telefon()
            {
                Marka = "Xoami",
                Model = "Note 8"
            };
            Kitap validatedK = new Kitap()
            {
                ISBN = "454545D",
                Yazar = "Daron Acemoğlu"

            };
            MessageBox.Show("validatedU.Validasyon() : " + validatedU.Validasyon());
            MessageBox.Show("validatedT.Validasyon() : " + validatedT.Validasyon());
            MessageBox.Show("validatedK.Validayson() : " + validatedK.Validasyon());


        }
    }
}
