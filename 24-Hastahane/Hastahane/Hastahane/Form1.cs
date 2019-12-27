using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastahane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gosterBT_Click(object sender, EventArgs e)
        {
            Hasta hasta1 = new Hasta();
            hasta1.Kimlik.kimlikBilgiDoldur(1111); // Kimlik için yazılan getter calisiyor..

            Poliklinik pol = new Poliklinik();
            hasta1.pol = pol; // pol ojesi set ediliyor..
            hasta1.pol.PolAdi = "Dahiliye"; // set edilen objeye şasağıdaki değerler yazılıyor.
            hasta1.pol.DoktorAdi = "Dr. Mehmet";
            hasta1.pol.PolTarih = "8/11/2019";
            hasta1.pol.PolBilgi = "Grip olmuş";

            MessageBox.Show("Hasta Kimlik Bilgileri :" + hasta1.Kimlik.kimlikBilgiOku());
            MessageBox.Show("Hasta Poliklinik Bilgileri :" + hasta1.pol.polBilgiOku());



        }
    }
}
