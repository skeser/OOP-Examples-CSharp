using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DikdortgenPrizmaOOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DikdortgenPrizma prizmaObj = new DikdortgenPrizma();
        private void hacimHesaplaBT_Click(object sender, EventArgs e)
        {     
            MessageBox.Show("Dikdortgen Prizma Hacim :" + Convert.ToSingle(prizmaObj.hacimHesapla(2f, 5f, 7f)));
        }
    }
}
