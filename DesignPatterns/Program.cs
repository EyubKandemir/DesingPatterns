using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CSharp.RuntimeBinder;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Factory Design Pattern

            //Telefon bayisi
            ITelefon s8 = TelefonFabrikası.GetTelefon("S8", "Batarya S8", 1, 2);
            ITelefon note8 = TelefonFabrikası.GetTelefon("NOTE8", "Batarya NOTE8", 2, 4);

            #endregion

            Console.ReadLine();
        }
    }

    #region Factory Design Pattern

    public interface ITelefon
    {
        string GetModel();
        string GetBatarya();
        int GetEn();
        int GetBoy();
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
    public class TelefonFabrikası
    {
        public static ITelefon GetTelefon(string model, string batarya, int en, int boy)
        {
            ITelefon telefon;
            if (model == "S8")
            {
                telefon = new S8(model, batarya, en, boy);
            }
            else if (model == "NOTE8")
            {
                telefon = new Note8(model, batarya, en, boy);
            }
            else
            {
                throw new RuntimeBinderException("Modelde telefon yok");
            }

            return telefon;
        }
    }

    #endregion

}