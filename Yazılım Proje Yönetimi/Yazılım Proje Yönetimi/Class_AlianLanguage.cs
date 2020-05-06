using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yazılım_Proje_Yönetimi
{
    class Class_AlianLanguage
    {
        public List<string> Harfler = new List<string>();

        public List<string> Semboller = new List<string>();

        private List<string> Kelimeler = new List<string>();

        private List<string> Cevaplar = new List<string>();



        public int i;


        public Class_AlianLanguage()
        {
            Harfler.Add("b");
            Harfler.Add("a");
            Harfler.Add("ç");
            Harfler.Add("i");
            Harfler.Add("e");
            Harfler.Add("k");
            Harfler.Add("r");
            Harfler.Add("d");
            Harfler.Add("l");
            Harfler.Add("m");
            Harfler.Add("s");
            Harfler.Add("h");
            KelimeKaydet();
        }
        public void KelimeKaydet()
        {
            
            Kelimeler.Add("baba");
            Kelimeler.Add("çiçek");
            Kelimeler.Add("bardak");
            Kelimeler.Add("kalem");
            Kelimeler.Add("masa");
            Kelimeler.Add("dal");
            Kelimeler.Add("bar");
            Kelimeler.Add("dar");
            Kelimeler.Add("ders");
            Kelimeler.Add("dilim");
            Kelimeler.Add("çakal");
            Kelimeler.Add("melek");
            Kelimeler.Add("bahçe");
            Kelimeler.Add("kar");
            Kelimeler.Add("bal");
            Kelimeler.Add("balık");


        }
        public string KelimeGoster(int index)
        {
            return Kelimeler[index];
        }

        
        public string cevabiGoster(int indeks)
        {
            return Cevaplar[indeks];
        }

        public void SembolEkle(string sembol)
        {
            Semboller.Add(sembol);
        }
        public string semboluGoster(int index)
        {
            return Semboller[index];
        }
        public string HarfGoster(int index)
        {
            return Harfler[index];
        }
        

        public string CevapDon(string gelen)
        {
            string alianCevap="";

            

            foreach (char harf in gelen)
            {
                i = 0;
                foreach (string alianHarf in Harfler)
                {
                    if (alianHarf == harf.ToString())
                    {
                        alianCevap = alianCevap + Semboller[i];
                    }
                    i++;
                }
            }

            return alianCevap;

        }

    }
}
