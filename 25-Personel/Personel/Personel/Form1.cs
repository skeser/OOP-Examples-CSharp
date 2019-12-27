using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void personelGoster_Click(object sender, EventArgs e)
        {
            Personel per1 = new Personel();
            Personel per2 = new Personel(111);
            Personel per3 = new Personel(333,"Muhasebe");
            Personel per4 = new Personel(444, "Satın Alma", 4500);

            MessageBox.Show("per1:" + per1.personelBilgi() + "\n" +
                            "per2:" + per2.personelBilgi() + "\n" +
                            "per3:" + per3.personelBilgi() + "\n" +
                            "per4:" + per4.personelBilgi() + "\n"
                            );
           
        }
    }
}
