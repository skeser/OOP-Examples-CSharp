using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConstObjInitFark
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FarkGoster_Click(object sender, EventArgs e)
        {
            /*
             * Once constructure calisir, Mesaj degiskenini doldurur,
             * ardindan object initializer calisir, KimlikNo icine 100, Maas icine 100 atar.
             * Mesaj Degiskeni ekrana yazdırıldığında; 34. Satır çıktı :
             * Kimlik no : 0
             * Maaş : 983
             * 35. Satir cikti :
             * Kimlik No : 100
             * Degişen maaş : 1000
             * 
             */
            Isci isc = new Isci() { KimlikNo = 100, Maas  = 1000 };
            MessageBox.Show(isc.Mesaj);
            MessageBox.Show("Kimlik No : " + isc.KimlikNo + "\nDegişen maaş : " + isc.Maas);
        }
    }
}
