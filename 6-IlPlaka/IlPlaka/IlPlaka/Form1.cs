using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IlPlaka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gosterBT_Click(object sender, EventArgs e)
        {
            string resultText = "null";
            int plakaSecim = Convert.ToInt32(plakaCB.Text);

            switch (plakaSecim)
            {
                case 45:
                    resultText = "Manisa";
                break;
                case 35:
                    resultText = "İzmir";
                    break;
                case 06:
                    resultText = "Ankara";
                    break;
             
            }

            MessageBox.Show(resultText);
        }
    }
}
