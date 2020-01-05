namespace CokluInterafce2
{
    public class Sahin : Araba
    {
        /*
         * base class'in constructure'i kullanılıyor.
         * upcast.
         */
        public Sahin(int maxHiz, int vitesSay) : base(maxHiz, vitesSay)
        {

        }

        /*
         * base class icindeki abstract method.
         * override edilmis. Gerekli. ve şart.
         */
        public override string YakitTuket()
        {
            //throw new NotImplementedException();
            return "Ben az yakit tuketirim.";
        }
    }
}
