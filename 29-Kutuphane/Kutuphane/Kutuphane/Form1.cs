using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // burada oluşturulmasına dikkat.. yoksa butona her basildiğinda
        // farkli kutuphane..
        Kutuphane SalihliHalkKutuphanesi = new Kutuphane();
        private void kitapEkleBT_Click(object sender, EventArgs e)
        {
            string isbn = isbnTB.Text;
            string kitapAdi = kitapAdiTB.Text;
            string yazar = yazarTB.Text;
            DateTime alisTarih = Convert.ToDateTime(alisTarhiTB.Text);
            DateTime iadeTarih = Convert.ToDateTime(iadeTarihTB.Text);
            // koz nesnesi oluşturuluyor ve içine nesne başlatıcı (oject initilazier)
            // yöntemi ile değer atanıyor. Yazar , Kitap ve ISB ler auto-implement..
            KitapOzellik koz = new KitapOzellik() { Yazar = yazar, KitapAdi = kitapAdi, ISBN = isbn };
            // kitap nesnesi oluşturuluyor ve içine nesne başlatıcı (oject initilazier)
            // yöntemi ile değer atanıyor. parametreler auto-implement..
            Kitap kitap = new Kitap() { alisTarih = alisTarih, iadeTarih = iadeTarih, KitapOzellik = koz };
            // kutuphaneye kitap ekleniyor.
            SalihliHalkKutuphanesi.kitapEkle(kitap);
        }

        private void litapListeBT_Click(object sender, EventArgs e)
        {
            kitapListesiTB.Text = SalihliHalkKutuphanesi.kitapListele();
        }

        private void kutuphaneBosaltBT_Click(object sender, EventArgs e)
        {
            SalihliHalkKutuphanesi.kutuphaneBosalt();
        }
    }
}
