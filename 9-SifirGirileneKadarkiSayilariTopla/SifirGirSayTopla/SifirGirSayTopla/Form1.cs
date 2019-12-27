using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SifirGirSayTopla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int toplam = 0;
        private void toplaBT_Click(object sender, EventArgs e)
        {
            int girSayi = Convert.ToInt32(girSayiTB.Text);
            if ( girSayi != 0)
            {
                toplam = toplam + girSayi;
                girSayiTB.Text = "";
            }
            else
            {
                MessageBox.Show(toplam.ToString());
                toplam = 0;
            }
  
            
        }
    }
}
