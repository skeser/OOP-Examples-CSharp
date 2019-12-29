using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polymorphism1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maasGosterBT_Click(object sender, EventArgs e)
        {
            Muhasebe m1 = new Muhasebe()
            {
                Ad = "Ahmet",
                Soyad = "Demir",
                MesaiGunSay = 4
            };
            MessageBox.Show(
                            "Muhasebe.Personel.Ad :" + m1.Ad + "\n" +
                            "Muhasebe.Personel.Soyad :" + m1.Soyad + "\n" +
                            "Muhasebe.MesaiGunSay :" + m1.MesaiGunSay + "\n" +
                            "Muhasebe.MaasHesapla() : " +m1.MaasHesapla().ToString() 
                            );
            Satis s1 = new Satis()
            {
                Ad = "Mehmet",
                Soyad = "Cicek",
                AylikCiro = 1000
            };
            MessageBox.Show(
                            "Satis.Personel.Ad :" + s1.Ad + "\n" +
                            "Satis.Personel.Soyad :" + s1.Soyad + "\n" +
                            "Satis.Aylikciro :" + s1.AylikCiro + "\n" +
                            "Satis.MaasHesapla() :" + s1.MaasHesapla().ToString()
                );
        }
    }
}
