using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CokluInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showMultiInterfaceBT_Click(object sender, EventArgs e)
        {
            Cocuk c = new Cocuk() { Isim = "Kral Sakir" };
            MessageBox.Show(c.Calis());
            MessageBox.Show(c.Oyna());
        }
    }
}
