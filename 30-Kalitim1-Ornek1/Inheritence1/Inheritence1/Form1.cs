using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritence1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showObjectsBT_Click(object sender, EventArgs e)
        {
            Urun u = new Urun();
            u.No = 1;
            u.Ad = "u.Ad, klavye";
            u.Aciklama = "u.Aciklama,acikla";
            u.Fiyat = 40;

            Kitap k = new Kitap();
            k.No = 1;
            k.Ad = "k.Ad, ulsularin dususu";
            k.Aciklama = "k.Aciklama, darons book";
            k.Fiyat = 128;

            k.ISBN = "ISBN1128";
            k.Yazar = "Daron Acemoglu";

            Telefon t = new Telefon();
            t.No = 1;
            t.Ad = "mi note 8 pro";
            t.Aciklama = "Siyah";
            t.Fiyat = 2300;

            t.Marka = "Xoami";
            t.Model = "Note 8 pro";

            MessageBox.Show(
                "Urun Class'ından initialize edilen u adli nesnenin icerigi" + "\n"+
                "u.No : " + u.No.ToString() + "\n" +
                "u.Ad :" + u.Ad + "\n" +
                "u.Aciklama :" + u.Aciklama + "\n" +
                "u.Fiyat :" + u.Fiyat.ToString() + "\n" +
                "-----------------------------------------" + "\n" +
                "Urun Class'ından genişletilmiş/extended, Kitap Class'ından initialize edilmiş k adli objenin iceriği " + "\n" +
                "Urun'den miras alinanlar" + "\n" +
                "u.No : " + k.No.ToString() + "\n" +
                "u.Ad :" + k.Ad + "\n" +
                "u.Aciklama :" + k.Aciklama + "\n" +
                "u.Fiyat :" + k.Fiyat.ToString() + "\n" +
                "########################################" + "\n" +
                "kitap class'nın kendi property'leri" + "\n" +
                "k.ISBN :" + k.ISBN + "\n" +
                "k.Yazar :" +k.Yazar + "\n" +
                "-----------------------------------------" + "\n" +
                "Urun Class'ından genişletilmiş/extended, Telefon Class'ından initialize edilmiş t adli objenin iceriği " + "\n" +
                "Urun'den miras alinanlar" + "\n" +
                "u.No : " + t.No.ToString() + "\n" +
                "u.Ad :" + t.Ad + "\n" +
                "u.Aciklama :" + t.Aciklama + "\n" +
                "u.Fiyat :" + t.Fiyat.ToString() + "\n" +
                "########################################" + "\n" +
                "Telefon class'nın kendi property'leri" + "\n" +
                "t.Marka :" + t.Marka + "\n" +
                "t.Model :" + t.Model + "\n" +
                "have a nice day !"
                );
            

        }
    }
}
