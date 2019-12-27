using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abstract1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void KopekBilgisiGoster(Kopek k)
        {
            MessageBox.Show(
                "Hayvan.Kopek.Ad (miras) :" + k.Ad + "\n" +
                "Hayvan.Kopek.Cins (miras):" + k.Cins + "\n" +
                "Kopek.SesCikar (overrided Hayvan) :" + k.SesCikar() + "\n"
                );
        }
        public void KediBilgiGoster(Kedi kedi)
        {
            MessageBox.Show(
                "Hayvan.Kedi.Ad (miras) :" + kedi.Ad + "\n" +
                "Hayvan.Kedi.Cins (miras) :" + kedi.Cins + "\n" +
                "Kedi.SesCikar (overrided Hayvan) :" + kedi.SesCikar() + "\n"
                );
        }
        // upcast - Liskovun yerine geçme prensibi
        public void HayvanBilgiGoster(Hayvan hayvan)
        {
            MessageBox.Show(
               "Hayvan.Ad  :" + hayvan.Ad + "\n" +
               "Hayvan.Cins  :" + hayvan.Cins + "\n" +
               "Hayvan.SesCikar (overrided Hayvan , kediyse kedi.SesCikar / kopekse kopek.SesCikar() calisir.) :" + hayvan.SesCikar() + "\n"
               );
        }

        private void showAbstractBT_Click(object sender, EventArgs e)
        {
            //Hayvan h = new Hayvan(); abstract class dan oble initialize edilemez. !
            Kopek kopek = new Kopek("Bobie");
            kopek.Cins = "zaar";
            kopek.SesCikar();
            Console.WriteLine("formdan - Kopek.SesCikar (overrided Hayvan) - : " + kopek.SesCikar());
            KopekBilgisiGoster(kopek);

            Kedi kedi = new Kedi("Tekir");
            kedi.Cins = "Van kedisi";
            kedi.SesCikar();
            KediBilgiGoster(kedi);
            Console.WriteLine("formdan - Kedi.SesCikar (overrided Hayvan) - : " + kedi.SesCikar());

            /*
             *  Problem ! 
             *  Kopek ve Kedi sınıfları icin ayrı ayrı bilgi goster method'ları yazmak zorundamıyız ??
             *  Çözüm
             *  HayvanBilgiGoster adlı Hayvan sınıfından parametre alan bir method kullanırsak ?
             *  Bu yonteme upcast - Liskovun yerine geçme prensibi denir.
             */
            HayvanBilgiGoster(kopek);
            HayvanBilgiGoster(kedi);
        }
    }
}
