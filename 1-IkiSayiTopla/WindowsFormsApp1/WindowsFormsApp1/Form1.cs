using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toplaButton_Click(object sender, EventArgs e)
        {
            int say1;
            int say2;
            int toplam;
            say1 = Convert.ToInt32(say1textBox.Text);
            say2 = Convert.ToInt32(say2textBox.Text);

            toplam = say1 + say2;
            sonucResultLabel.Text = Convert.ToString(toplam);

        }

        private void clearFormButton_Click(object sender, EventArgs e)
        {
            /* 
            say1textBox.Text = "";
            say2textBox.Text = "";
            sonucResultLabel.Text = "";
            */
            say1textBox.Text = String.Empty;
            say2textBox.Text = String.Empty;
            sonucResultLabel.Text = "sayıları gir butona bas";

        }
    }
}
