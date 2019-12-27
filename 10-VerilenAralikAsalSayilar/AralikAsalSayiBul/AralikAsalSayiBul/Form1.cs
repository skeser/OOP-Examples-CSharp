using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AralikAsalSayiBul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void asalSayiBulBT_Click(object sender, EventArgs e)
        {
            int min = Convert.ToInt32(minTB.Text);
            int max = Convert.ToInt32(maxTB.Text);
            string mesaj = " ";
            Boolean flag = true; // asal bayragi : her sayıya asaldır on yargısı ile yaklasiyoruz.
            Console.WriteLine("min:" + min);
            Console.WriteLine("max :" + max);

            for(int i = min; i <= max; i++)
            {
                for (int z = 2; z < i; z++)
                {
                    //Console.Write("i : " + i + " z : " + z + "\n");
                    if ( (i % z) == 0)
                    {
                        flag = false; // 2 ile kendisine kadar olan sayılara tam bolunurse asalık bozuluyor..
                    }
                }//
                if (flag == true)
                {
                    Console.Write("\n **************************************** ASAL BULDUM ! i asaldır ! " + i + "\n");
                    mesaj = mesaj + "-" + i;
                }
                flag = true; // sonraki sayı icin on yargımızı yineliyoruz.
            }
            MessageBox.Show(mesaj);

        }
    }
}
