using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fabrika
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
         * Fabrikayi burada kurarak tek F oluşturuyoruz..
         * Fabrika F = new Fabrika(); degil.. obj init ile asagidaki gibi..
         * */
        Fabrika F = new Fabrika { FabrikaIsim = "Vestel", Adres = "Manisa" };
        private void perEkleBT_Click(object sender, EventArgs e)
        {
            int gelenPerno = Convert.ToInt32(perNoTB.Text);
            int gelenTc = Convert.ToInt32(tcNoTB.Text);
            string gelenAd = adTB.Text;
            string gelenSoyad = soyadTB.Text;
            string gelenBirim = birimTB.Text;
            // obj init ile.. kimlik ve per oluşturuluyor..
            Kimlik kim = new Kimlik() { Tckimlik = gelenTc, Ad = gelenAd, Soyad = gelenSoyad };
            Personel per = new Personel() { PerNo = gelenPerno, K = kim, Birim = gelenBirim };
            F.iseAl(per);
        }

        private void perListBT_Click(object sender, EventArgs e)
        {
            perListTB.Text = F.personelListele();
        }
    }
}
