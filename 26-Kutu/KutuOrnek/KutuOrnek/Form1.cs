using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kutuGoster_Click(object sender, EventArgs e)
        {
            // kutu sınıfından 3 adet obje/nesne oluşturuluyor..
            Kutu k1 = new Kutu() { Yukseklik = 45 };
            Kutu k2 = new Kutu() { Genislik = 35 };
            Kutu k3 = new Kutu() { Derinlik = 10 };

            MessageBox.Show("k1 :" + k1.kutuOlcuGoster() + "\n" +
                            "k2 :" + k2.kutuOlcuGoster() + "\n" +
                            "k3 :" + k3.kutuOlcuGoster() + "\n"
                            );
            MessageBox.Show("Custom kutular \n" +
                            k1.customKutuGoster(1) +
                            k2.customKutuGoster(2) +
                            k3.customKutuGoster(3)
                            );

        }
    }
}
