using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoktaKenar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kenarGoster_Click(object sender, EventArgs e)
        {
            // nokta objelerini oluştur..
            Nokta N1 = new Nokta(1,2);
            Nokta N2 = new Nokta(5, 6);
            // noktaları kenara gödner 
            // * kenar nesnesi initiliaze edilirken constructure'ine parametre gittigine dikkat. 
            Kenar k1 = new Kenar(N1, N2);

            MessageBox.Show("Kenar in noktaları : " + k1.kenarOku());


        }
    }
}
