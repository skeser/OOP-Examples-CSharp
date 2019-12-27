using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsyeriApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void isyeriGosterBT_Click(object sender, EventArgs e)
        {
            // Eksik ve Kotu yontem..
            /*
             * Object initialize methods
                1- classical
                2- via constructure
                3- via Object Initializers
            */
            // 1- classical
            Isyeri IY = new Isyeri();
            IY.Ad = "BlueSoft ";
            
            Adres ad = new Adres();
            ad.Il = "Manisa";
            IY.Adres = ad;

            Calisan calisan1 = new Calisan();
            calisan1.TCKimlikNo = 1111;
    
            calisan1.Departman = "Yazılım Departmanı";
            calisan1.Gorev = "Yazılım Uzmanı";
            calisan1.Isim = "Mr. X";

            Calisan calisan2 = new Calisan();
            calisan2.TCKimlikNo = 2222;
            calisan2.Departman = "Yazılım Departmanı";
            calisan2.Gorev = "Test Uzmanı";
            calisan2.Isim = "Mrs. Y";

            IY.CalisanEkle(calisan1);
            IY.CalisanEkle(calisan2);
                       
            MessageBox.Show(
                            "Isyeri.Ad : " + IY.Ad + "\n" +
                            "Isyeri.Adres.Il :" + IY.Adres.Il + "\n" +
                            "---------------------------------" + "\n" +
                            "Isyeri.Calisans / ları  :" + "\n" +
                            "########################################" + "\n" +
                            IY.CalisanListele()
                            );

            // 3- via Object Initializers / Nesne Baslaticisi yontemi ile nesne olusturma
            Isyeri IY2 = new Isyeri() { 
                Ad = "BlueSoft", 
                Adres = new Adres() { Il = "Manisa"}
            };

            Calisan calisan3 = new Calisan() {
                TCKimlikNo = 3333,
                Departman = "Yazılım Departmanı",
                Gorev = "Test Uzmanı",
                Isim = "Mr. X"
            };

            Calisan calisan4 = new Calisan()
            {
                TCKimlikNo = 4444,
                Departman = "Yazılım Departmanı",
                Gorev = "Test Uzmanı",
                Isim = "Mrs. Y"
            };

            IY2.CalisanEkle(calisan3);
            IY2.CalisanEkle(calisan4);

            MessageBox.Show(
                           "via Object Initializers ile IY2 objesi icerigi" +"\n" +
                           "---------------------------------" + "\n" +
                           "Isyeri.Ad : " + IY2.Ad + "\n" +
                           "Isyeri.Adres.Il :" + IY2.Adres.Il + "\n" +
                           "---------------------------------" + "\n" +
                           "Isyeri.Calisans / ları  :" + "\n" +
                           "########################################" + "\n" +
                           IY2.CalisanListele()
                           );




        }
    }
}
