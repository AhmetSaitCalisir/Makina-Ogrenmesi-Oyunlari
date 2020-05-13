using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yazılım_Proje_Yönetimi
{
    class Class_FindIt
    {
        public List<List<string>> listeler = new List<List<string>>();
        private List<string> ForestCevaplar = new List<string>();
        private List<string> BeachCevaplar = new List<string>();
        private List<string> ChildsCevaplar = new List<string>();
        private List<string> LunaparkCevaplar = new List<string>();
        private List<string> SinifCevaplar = new List<string>();
        public List<string> Resimler = new List<string>();

        public Class_FindIt()
        {
            ResimEkle();
            ForestCevaplar.Add("Ağaç");
            ForestCevaplar.Add("Kuş");
            ForestCevaplar.Add("Balık");
            ForestCevaplar.Add("Fil");
            ForestCevaplar.Add("Domuz");
            ForestCevaplar.Add("Timsah");
            ForestCevaplar.Add("Kaplumbağa");
            ForestCevaplar.Add("Maymun");
            ForestCevaplar.Add("Kurbağa");
            ForestCevaplar.Add("Göl");
            ForestCevaplar.Add("Çiçek");

            BeachCevaplar.Add("Palmiye");
            BeachCevaplar.Add("Deniz yıldızı");
            BeachCevaplar.Add("Şezlong");
            BeachCevaplar.Add("Terlik");
            BeachCevaplar.Add("Deniz");
            BeachCevaplar.Add("Kum");
            BeachCevaplar.Add("Tekne");
            BeachCevaplar.Add("Bulut");
            BeachCevaplar.Add("Şemsiye");
            BeachCevaplar.Add("Ada");

            ChildsCevaplar.Add("Uçurtma");
            ChildsCevaplar.Add("Bulut");
            ChildsCevaplar.Add("Balon");
            ChildsCevaplar.Add("Kuş");
            ChildsCevaplar.Add("Güneş");
            ChildsCevaplar.Add("Salıncak");
            ChildsCevaplar.Add("Seksek");
            ChildsCevaplar.Add("Top");
            ChildsCevaplar.Add("Ördek");
            ChildsCevaplar.Add("Çocuk");
            ChildsCevaplar.Add("Göl");

            LunaparkCevaplar.Add("Dönme dolap");
            LunaparkCevaplar.Add("Atlı karınca");
            LunaparkCevaplar.Add("Tren");
            LunaparkCevaplar.Add("Balonlar");
            LunaparkCevaplar.Add("Şato");
            LunaparkCevaplar.Add("Sirk");
            LunaparkCevaplar.Add("Araba");

            SinifCevaplar.Add("Saat");
            SinifCevaplar.Add("Çiçek");
            SinifCevaplar.Add("Kitaplık");
            SinifCevaplar.Add("Dolap");
            SinifCevaplar.Add("Sıra");
            SinifCevaplar.Add("Öğrenci");
            SinifCevaplar.Add("Kitap");
            SinifCevaplar.Add("Küre");
            SinifCevaplar.Add("Tahta");

           // listeler.Add(ForestCevaplar);
            listeler.Add(BeachCevaplar);
            listeler.Add(ChildsCevaplar);
            listeler.Add(LunaparkCevaplar);
            listeler.Add(SinifCevaplar);

            
        }

        public void ResimEkle()
        {
            //Resimler.Add("../../FindItResimler/animals-forest.jpg");
            Resimler.Add("../../FindItResimler/beach.jpg");
            Resimler.Add("../../FindItResimler/childs.jpg");
            Resimler.Add("../../FindItResimler/lunapark.jpg");
            Resimler.Add("../../FindItResimler/sinif.jpg");
        }

        public string ResimGoster()
        {
            if (Resimler.Count == 0)
            {
                return "../../Resimler/gameOver.jpg";
            }
            else
            {
                return Resimler[0];
            }
            
            
        }

        public int Kontrol(string cevap1,string cevap2, string cevap3,int puan)
        {
            foreach (string i in listeler[0])
            {
                if (cevap1 == i || cevap2== i || cevap3==i)
                {
                    puan++;
                }
            }
            return puan;
        }
        public void Sil()
        {
            Resimler.RemoveAt(0);
            listeler.RemoveAt(0);
        }

        public void ButonKontrol(Button buttonSonra)
        {
            if (Resimler.Count == 0)
            {
                buttonSonra.Enabled = false;
               
            }
        }

    }
}
