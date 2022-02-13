using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            S8Fabrikasi s8Fabrikasi = new S8Fabrikasi();
            ITelefon s8 =  s8Fabrikasi.GetTelefon("S8", "2000", 6,9);
            ITelefon s9 = s8Fabrikasi.GetTelefon("S9", "3000", 4, 6);

            Note8Fabrikasi note8Fabrikasi = new Note8Fabrikasi();
            ITelefon note8 = note8Fabrikasi.GetTelefon("NOTE8", "3000", 8, 10);

            Console.WriteLine(s8);
            Console.ReadLine();
        }
    }

    #region Abstract Factory
    public interface ITelefon
    {
        string GetModel();
        string GetBatarya();
        int GetEn();
        int GetBoy();
    }
    public interface ITelefonFactory
    {
        ITelefon GetTelefon(string model, string batarya, int en, int boy);
    }
    public class S8 : ITelefon
    {
        private string model;
        private string batarya;
        private int en;
        private int boy;

        public S8(string model, string batarya, int en, int boy)
        {
            this.model = model;
            this.batarya = batarya;
            this.en = en;
            this.boy = boy;
        }

        public string GetModel()
        {
            return model;
        }

        public string GetBatarya()
        {
            return batarya;
        }

        public int GetEn()
        {
            return en;
        }

        public int GetBoy()
        {
            return boy;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
    public class Note8 : ITelefon
    {
        private string model;
        private string batarya;
        private int en;
        private int boy;

        public Note8(string model, string batarya, int en, int boy)
        {
            this.model = model;
            this.batarya = batarya;
            this.en = en;
            this.boy = boy;
        }

        public string GetModel()
        {
            return model;
        }

        public string GetBatarya()
        {
            return batarya;
        }

        public int GetEn()
        {
            return en;
        }

        public int GetBoy()
        {
            return boy;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
    public class S8Fabrikasi : ITelefonFactory
    {
        public ITelefon GetTelefon(string model, string batarya, int en, int boy)
        {
            return new S8(model,batarya,en,boy);
        }
    }
    public  class Note8Fabrikasi : ITelefonFactory
    {
        public ITelefon GetTelefon(string model, string batarya, int en, int boy)
        {
            return new Note8(model, batarya, en, boy);
        }
    }

    #endregion
}
