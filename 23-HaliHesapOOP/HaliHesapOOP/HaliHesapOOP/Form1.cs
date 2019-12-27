using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaliHesapOOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Hali h = new Hali();

        private void uzunlukTB_TextChanged(object sender, EventArgs e)
        {
            h.Uzunluk = Convert.ToInt32( ( uzunlukTB.Text == "" ) ? "0" : uzunlukTB.Text);
            sonucLB.Text = h.Alan.ToString();
        }

        private void genislikTB_TextChanged(object sender, EventArgs e)
        {
            h.Genislik = Convert.ToInt32( ( genislikTB.Text == "") ? "0" : genislikTB.Text);
            sonucLB.Text = h.Alan.ToString();
        }
    }
}
