using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciNotlariDizi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // 10 elemanlı dizi tanımlanır.
        int[] notArr = new int[10];

        private void kaydetGosterBT_Click(object sender, EventArgs e)
        {
            notArr[0] = Convert.ToInt32(notTB1.Text);
            notArr[1] = Convert.ToInt32(notTB2.Text);
            notArr[2] = Convert.ToInt32(notTB3.Text);
            notArr[3] = Convert.ToInt32(notTB4.Text);
            notArr[4] = Convert.ToInt32(notTB5.Text);
            notArr[5] = Convert.ToInt32(notTB6.Text);
            notArr[6] = Convert.ToInt32(notTB7.Text);
            notArr[7] = Convert.ToInt32(notTB8.Text);
            notArr[8] = Convert.ToInt32(notTB9.Text);
            notArr[9] = Convert.ToInt32(notTB10.Text);

            MessageBox.Show("Girilen Notlar: \n" +
                            "Not 1:" + notArr[0] + "\n" +
                            "Not 2:" + notArr[1] + "\n" +
                            "Not 3:" + notArr[2] + "\n" +
                            "Not 4:" + notArr[3] + "\n" +
                            "Not 5:" + notArr[4] + "\n" +
                            "Not 6:" + notArr[5] + "\n" +
                            "Not 7:" + notArr[6] + "\n" +
                            "Not 8:" + notArr[7] + "\n" +
                            "Not 9:" + notArr[8] + "\n" +
                            "Not 10:" + notArr[9] + "\n");
        }
    }
}
