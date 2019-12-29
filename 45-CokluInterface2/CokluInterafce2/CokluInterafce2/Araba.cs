using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CokluInterafce2
{
    public abstract class Araba
    {
        private int MaxHiz;
        private int VistesSay;
        public Araba(int maxHiz, int vitesSay)
        {
            /*
             * auto-implement propert kullanılmadan 
             * clasik yontem ile setter.
             */
            this.MaxHiz = maxHiz;
            this.VistesSay = vitesSay;
        }
        /*
         * classic yontem ile 
         * MaxHiz ve VitesSay icin getters.
         */
        public string GetMaxHiz()
        {
            return this.MaxHiz.ToString() + "km/sa";
        }
        public string GetVitesSay()
        {
            return this.VistesSay.ToString() + "vitesli";
        }
        /*
         * abstract class'in abstract method'u.
         * child class'da override EDILMELI.
         * govdesi yazilamaz..
         */
        public abstract string YakitTuket();
        /* 
         * abstract method'larin govdeleri yazılamaz !
        public abstract string TekerSay()
        {
            return "4 teker";
        }
        */
        public virtual string Plaka()
        {
            return "gecici plaka var.";
        }

    }
}
