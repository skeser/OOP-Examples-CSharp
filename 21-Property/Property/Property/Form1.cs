using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Property
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gosterBT_Click(object sender, EventArgs e)
        {
            Isci isci = new Isci();
            isci.KimlikNo = 45;
            MessageBox.Show(isci.karsilamaMesaji());
        }
    }
}
