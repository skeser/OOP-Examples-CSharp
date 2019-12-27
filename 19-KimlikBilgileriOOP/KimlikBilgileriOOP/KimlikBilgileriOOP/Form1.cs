using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KimlikBilgileriOOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        KimlikBilgileri personObj = new KimlikBilgileri();

        private void kimlikBilgileriGosterBT_Click(object sender, EventArgs e)
        {
            personObj.kimlikNo = 11111111;
            personObj.ad = "Ahmet";
            personObj.soyad = "Aslan";
            personObj.dogumTarihi = Convert.ToDateTime("31.01.2013");
            personObj.dogumYeri = "Turgutlu";

            MessageBox.Show(personObj.kimlikBilgileriGoster());
        }
        Ogrenci ogrenciObj = new Ogrenci();
        private void ogrenciGosterBT_Click(object sender, EventArgs e)
        {
            /**
             * Aggregation Kullanım;
             * ogrenci sınıfnın parcasi olan kimlikBilgi referansına
             * KimblikBilgileri sınıfından turetilen nesne ataniyor..
             * */
            ogrenciObj.kimlikBilgi = new KimlikBilgileri();

            ogrenciObj.birim = "HFT Teknoloji Fakültesi";
            ogrenciObj.bolum = "Yazılım Muhendisliği";
            ogrenciObj.ogrNo = "177";
          
            ogrenciObj.kimlikBilgi.kimlikNo = 121212;
            ogrenciObj.kimlikBilgi.ad = "Mehmet";
            ogrenciObj.kimlikBilgi.soyad = "Kaplan";
            ogrenciObj.kimlikBilgi.dogumYeri = "Manisa";
            ogrenciObj.kimlikBilgi.dogumTarihi = Convert.ToDateTime("1.1.1999");

            MessageBox.Show(ogrenciObj.ogrenciBilgiGoster());


        }
    }
}
