using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inhertance3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showObjectsBT_Click(object sender, EventArgs e)
        {
            Kitap k = new Kitap();        
            k.Ad = "k.Ad, ulsularin dususu";
            k.ISBN = "ISBN1128";
            k.Yazar = "Daron Acemoglu";

            Telefon t = new Telefon();
            t.Ad = "mi note 8 pro";
            t.Marka = "Xoami";
            t.Model = "Note 8 pro";

            MessageBox.Show(
                "-----------------------------------------" + "\n" +
                "Urun Class'ından genişletilmiş/extended, Kitap Class'ından initialize edilmiş k adli objenin iceriği " + "\n" +
                "Urun'den miras alinanlar" + "\n" +
                "u.No : " + k.No.ToString() + "\n" +
                "u.Ad :" + k.Ad + "\n" +
                "########################################" + "\n" +
                "kitap class'nın kendi property'leri" + "\n" +
                "k.kNo :" + k.kNo + "\n" +
                "k.ISBN :" + k.ISBN + "\n" +
                "k.Yazar :" + k.Yazar + "\n" +
                "-----------------------------------------" + "\n" +
                "Urun Class'ından genişletilmiş/extended, Telefon Class'ından initialize edilmiş t adli objenin iceriği " + "\n" +
                "Urun'den miras alinanlar" + "\n" +
                "u.No : " + t.No.ToString() + "\n" +
                "u.Ad :" + t.Ad + "\n" +
                "########################################" + "\n" +
                "Telefon class'nın kendi property'leri" + "\n" +
                "t.tNo :" + t.tNo + "\n" +
                "t.Marka :" + t.Marka + "\n" +
                "t.Model :" + t.Model + "\n" +
                "have a nice day !"
                );

        }
    }
}
