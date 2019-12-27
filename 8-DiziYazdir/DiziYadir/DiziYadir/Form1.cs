using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiziYadir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void diziGosterBT_Click(object sender, EventArgs e)
        {
            int[] dizi = { 1, 2, 3, 4, 5 };
            string messageBox = "";

            for (int indis = 0; indis < dizi.Length; indis++)
            {
                messageBox = messageBox +  dizi[indis] + "\n";
            }

            MessageBox.Show(messageBox);
           
        }
    }
}
