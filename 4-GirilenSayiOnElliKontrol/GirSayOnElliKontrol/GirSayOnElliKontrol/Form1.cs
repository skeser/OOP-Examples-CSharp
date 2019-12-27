using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GirSayOnElliKontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kontrolButton_Click(object sender, EventArgs e)
        {
            int girilenSayi;
            string sayiDurum = "";
            girilenSayi = Convert.ToInt32(girilenSayiTextBox.Text);

            if ( girilenSayi < 10) { sayiDurum = "Girilen sayi : ( " + girilenSayi + " ) 10'dan kucuk"; }
            if ( (girilenSayi >= 10) && (girilenSayi <= 50) ) { sayiDurum = "Girilen sayi : ( " + girilenSayi + " ) 10 ile 50 araliğinda"; }
            if ( girilenSayi > 50 ) { sayiDurum = "Girilen sayi : ( " + girilenSayi + " ) 50 'den buyuk"; }

            MessageBox.Show("Girilen Sayi : " + girilenSayi + "\n" +
                            "Kontrol İşlemi Sonucu: " + sayiDurum);
        }
    }
}
