using System;
using System.Windows.Forms;

namespace CokluInterafce2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showArabaOzellikBT_Click(object sender, EventArgs e)
        {
            Sahin s = new Sahin(160, 4);
            MessageBox.Show
                (
                    "Sahin.<<abstract>>Araba.GetMaxHiz (returned, private maxHiz) :" + s.GetMaxHiz() + "\n" +
                    "Sahin.<<abstract>>Araba.GetVitesSay (returned, private vitesSay) : vites sayisi :" + s.GetVitesSay() + "\n" +
                    "Sahin.<<abstract>>Araba.<<abstract>>YakitTuket() :" + s.YakitTuket() + "\n" +
                    "Sahin.<<abstract>>Araba.<<virtual>>Plaka() :" + s.Plaka()
                );

            Renault r = new Renault(180, 5);
            MessageBox.Show
                (
                    "Renault.<<abstract>>Araba.GetMaxHiz (returned, private maxHiz) :" + r.GetMaxHiz() + "\n" +
                    "Renault.<<abstract>>Araba.GetVitesSay (returned, private vitesSay) : vites sayisi :" + r.GetVitesSay() + "\n" +
                    "Renault.<<abstract>>Araba.<<abstract>>YakitTuket() :" + r.YakitTuket() + "\n" +
                    "Renault.<<abstract>>Araba.<<virtual>>Plaka() :" + r.Plaka() + "\n" +
                    "------- IKontak interface'i ile kazandirilan yetenek. -----" + "\n" +
                    "Renoult<<Interface>>IKontak.KontakAc() :" + r.KontakAc()
                );
            Audi a = new Audi(280, 7);
            MessageBox.Show
               (
                   "Audi.<<abstract>>Araba.GetMaxHiz (returned, private maxHiz) :" + a.GetMaxHiz() + "\n" +
                   "Audi.<<abstract>>Araba.GetVitesSay (returned, private vitesSay) : vites sayisi :" + a.GetVitesSay() + "\n" +
                   "Audi.<<abstract>>Araba.<<abstract>>YakitTuket() :" + a.YakitTuket() + "\n" +
                   "Audi.<<abstract>>Araba.<<virtual>>Plaka() -you see, result of overrided in Audi class --:" + a.Plaka() + "\n" +
                   "------- IKontak interface'i ile kazandirilan yetenek. -----" + "\n" +
                   "Audi<<Interface>>IKontak.KontakAc() :" + a.KontakAc() + "\n" +
                   "------- IKlima interface'i ile kazandirilan yetenekler -----" + "\n" +
                   "Audi<<Interface>>IKlima.KlimaTip() :" + a.KlimaTip() + "\n" +
                   "Audi<<Interface>>IKlima.KlimaCalistir() :" + a.KlimaCalistir() + "\n" +
                   "------- IUstuAcilabilable interface'i ile kazandirilan yetenek. -----" + "\n" +
                   "Audi<<Interface>>IUstuAcilabilable.UstunuAc() :" + a.UstunuAc()
               );



        }
    }
}
