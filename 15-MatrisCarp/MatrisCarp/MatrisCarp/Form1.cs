using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrisCarp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void matrisCarpBT_Click(object sender, EventArgs e)
        {
            int[,] matris1 = { { 2, 1, 1 }, 
                               { 5, 1, 4 }, 
                               { 19, 8, 1 }
                             };
            int[,] matris2 = { 
                                { 9, 9, 1 },
                                { 3, 1, 21 },
                                { 7, 1, 11 }
                             };
            int[,] c = new int[3,3];


        }
    }
}
