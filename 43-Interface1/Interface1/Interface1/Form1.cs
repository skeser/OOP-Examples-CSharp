using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void interfaceGosterBT_Click(object sender, EventArgs e)
        {
            Ogretmen o = new Ogretmen() { Isim = "Tanju Ogretmen" }; //Isim, Kisi'den miras.
            Satisci s = new Satisci() { Isim = "Sakir Satisci" }; //Isim, Kisi'den miras.
            Mudur m = new Mudur() { Isim = "Necati Mudur" }; //Isim, Kisi'den miras.

            MessageBox.Show("Ogretmen.Kisi<<Abstract>>.BilgiGoster() :" + o.BilgiGoster() + "\n" +
                            "Ogretmen.ICalisabilen<<Interface>>.Calis() :" +o.Calis() );

            MessageBox.Show("Satisci.Kisi<<Abstract>>.BilgiGoster() :" + s.BilgiGoster() + "\n" +
                            "Satisci.ICalisabilen<<Interface>>.Calis() :" + s.Calis() );
            MessageBox.Show("Mudur.Kisi<<Abstract>>.BilgiGoster() :" + m.BilgiGoster() + "\n" +
                            "Mudur.ICalisabilen<<Interface>>.Calis() :" + m.Calis() );


        }
    }
}
