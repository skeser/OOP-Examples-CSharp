using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArabaGaleriOOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Galeri g = new Galeri();
        private void arabaEkleBT_Click(object sender, EventArgs e)
        {
            g.ArabaEkle(markaTB.Text, Convert.ToInt16(modelTB.Text), renkTB.Text);
        }

        private void listViewLoadBT_Click(object sender, EventArgs e)
        {
            listViewLoad();
        }

        private void listViewLoad()
        {

        }

        private void listBoxLoadBT_Click(object sender, EventArgs e)
        {
            listBoxLoad();
        }

        private void listBoxLoad()
        {
            arabaLB.Items.Clear();
            foreach (Araba araba in g.ArabaListele())
            {
                arabaLB.Items.Add(araba);
            }
        }

        private void arabaLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            g.ArabaSat((Araba)(sender as ListBox).SelectedItem);
            listBoxLoad();
        }
    }
}
