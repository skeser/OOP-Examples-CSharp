using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalismaDurumu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calisiyorRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            aylikGelirTextBox.Enabled = true;
        }

        private void calismiyorRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            aylikGelirTextBox.Text = String.Empty;
            aylikGelirTextBox.Enabled = false;
        }

        private void gosterButton_Click(object sender, EventArgs e)
        {
            string ad, soyad, calismaDurum;
            float aylikGelir;

            ad = adTextBox.Text;
            soyad = soyadTextBox.Text;

            calismaDurum = calisiyorRadioButton.Checked ? "Çalışıyor" : "Çalışmıyor";
            // calisyor secildiyse aylik gelir text'inin içindeki değeri al string'e cevir ekrana yaz.
            // secilmediyse 0 ata onu stringe cevir.
            aylikGelir = Convert.ToSingle(calisiyorRadioButton.Checked ? aylikGelirTextBox.Text : "0");

            MessageBox.Show("Kişi Bilgileri : \n" +
                            "Ad: " + ad + "\n" +
                            "Soyad : " + soyad + "\n" +
                            "Calisma Durumu: " + calismaDurum + "\n" +
                            "Aylik Gelir : " + aylikGelir);

        }
    }
}
