using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerbestDusmeHesapla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float g = 9.8f;
        private void hesaplaBT_Click(object sender, EventArgs e)
        {
            // formul 1
            if (hSecimCB.Checked)
            {
                float t1 = Convert.ToSingle(t1GirisTB.Text);
                float h1Sonuc = 0.5f * g * t1 * t1;
                hSonucTB.Text = Convert.ToString(h1Sonuc);
            }
            // formul 2
            if (v1SecimCB.Checked)
            {
                float t2 = Convert.ToSingle(t2GirisTB.Text);
                float v1Sonuc = g * t2;
                v1SonucTB.Text = Convert.ToString(v1Sonuc);
            }
            // formul3
            if (v2SecimCB.Checked)
            {
                float h1 = Convert.ToSingle(hGirisTB.Text);
                float h2Sonuc = 2f * g * h1;
                v2SonucTB.Text = Convert.ToString(h2Sonuc);
            }
        }
    }
}
