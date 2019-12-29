using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U13Abstract1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const int birimDersUcreti = 55;
        private void gosterBT_Click(object sender, EventArgs e)
        {
            
            NormalOgrenci NO = new NormalOgrenci(birimDersUcreti);
            NO.KrediSayisi = 10;
            NO.DersUcretiHesapla();
            
            MessageBox.Show(
                            "NormalOgrenci.OgrenciDurum() :" + NO.OgrenciDurum() + "\n" +
                            "NormalOgrenci.OgrenciBase.DersUcreti" + NO.DersUcreti
                );
            
            BursluOgrenci BU = new BursluOgrenci(birimDersUcreti);
            BU.KrediSayisi = 10;
            BU.BursOrani = 0.1M;
            BU.DersUcretiHesapla();

            MessageBox.Show(
                            "BursluOgrenci.OgrenciDurum() :" + BU.OgrenciDurum() + "\n" +
                            "BursluOgrenci.OgrenciBase.DersUcreti : " + BU.DersUcreti
                            );
        }
    }
}
