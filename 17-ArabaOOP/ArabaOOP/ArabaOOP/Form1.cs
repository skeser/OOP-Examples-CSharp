using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArabaOOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void arabaClassGosterBT_Click(object sender, EventArgs e)
        {
            Araba myAraba = new Araba();
            myAraba.marka = "Peugeout 206";
            myAraba.model = 2003;
            myAraba.renk = "Mavi";
            myAraba.FiyatKDVsiz = 29000;
         

            MessageBox.Show("Marka :" + myAraba.marka + "\n" +
                            "Model :" + myAraba.model + "\n" +
                            "Renk :" + myAraba.renk + "\n" +
                            "KDV'siz fiyat :" + myAraba.FiyatKDVsiz);
        }
    }
}
