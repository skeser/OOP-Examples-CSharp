using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsyeriApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void isYeriGosterBT_Click(object sender, EventArgs e)
        {
            /* 
             * Object initialize methods
               1- classical
               2- via constructure
               3- via Object Initializers
           */
            // 1- classical
            Isyeri IY = new Isyeri();
            IY.IsyeriAd = "BlueSoft";
            IY.Adres.Il = "Manisa";
            IY.Adres.Ilce = "Salihli";
            IY.Adres.Mahalle = "Merkez";
            IY.Adres.AcikAdres = "No : 45 Daire : 3 ";

            Calisan calisan1 = new Calisan();
            // Kisi'den
            calisan1.TCKimlikNo = 1111;
            calisan1.Isim = "Mr. X";
            // Kisi - Adres / composition
            calisan1.Adres.Il = "Izmir";
            calisan1.Adres.Ilce = "Bornova";
            calisan1.Adres.Mahalle = "Park";
            calisan1.Adres.AcikAdres = "No:1 Kat:1";
            // Calisan
            calisan1.SGKNo = 11110;
            calisan1.Gorev = "Yazılım Uzmanı";
            calisan1.Departman = "Yazılım";
            // Calisan - Isyeri Arasi Aggregation.
            calisan1.Isyeri = IY;

            Calisan calisan2 = new Calisan();
            // Kisi'den
            calisan2.TCKimlikNo = 2222;
            calisan2.Isim = "Mrs. Y";
            // Kisi - Adres / composition
            calisan2.Adres.Il = "Izmir";
            calisan2.Adres.Ilce = "Bayranlı";
            calisan2.Adres.Mahalle = "Orta";
            calisan2.Adres.AcikAdres = "No:2 Kat:2";
            // Calisan
            calisan2.SGKNo = 22220;
            calisan2.Gorev = "Test Uzmanı";
            calisan2.Departman = "Yazılım";
            // Calisan - Isyeri Arasi Aggregation.
            calisan2.Isyeri = IY;

            IY.CalisanEkle(calisan1);
            IY.CalisanEkle(calisan2);

            MessageBox.Show(IY.CalisanListele());

            // 3- via Object Initializers / Nesne Baslaticisi yontemi ile nesne olusturma
            Isyeri IY2 = new Isyeri() { 
                IsyeriAd = "BlueSoft",
                Adres = new Adres() { Il = "Manisa", Ilce = "Salihli", Mahalle = "Merkez", AcikAdres = "No : 45 Daire : 3" }
            };

            Calisan calisan3 = new Calisan()
            {
                TCKimlikNo = 3333,
                Isim = "Mr. Z",
                Adres = new Adres()
                {
                    Il = "Izmir",
                    Ilce = "Balcova",
                    Mahalle = "Kenar",
                    AcikAdres = "No:3 , Kat:3"
                },
                SGKNo = 33330,
                Gorev = "Test Uzmani",
                Departman = "Yazılım",
                Isyeri = IY2
            };

            Calisan calisan4 = new Calisan()
            {
                TCKimlikNo = 4444,
                Isim = "Mr. T",
                Adres = new Adres()
                {
                    Il = "Izmir",
                    Ilce = "Konak",
                    Mahalle = "Liman",
                    AcikAdres = "No:4 , Kat:4"
                },
                SGKNo = 44440,
                Gorev = "Yazılım Uzmani",
                Departman = "Yazılım",
                Isyeri = IY2
            };

            IY2.CalisanEkle(calisan3);
            IY2.CalisanEkle(calisan4);

            MessageBox.Show(IY2.CalisanListele());
        }
    }
}
