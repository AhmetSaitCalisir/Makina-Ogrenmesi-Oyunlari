using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yazılım_Proje_Yönetimi
{
    class Class_Sorting_Sorular
    {
        private List<Class_Sorting_Soru> Sorular = new List<Class_Sorting_Soru>();
        public Class_Sorting_Sorular()
        {
            Sorular.Add(new Class_Sorting_Soru(
                "Quidditch oynasan hangi pozisyonda olurdun?",
                "Arayıcı",
                "Tutucu",
                "Kovalayıcı",
                "Vurucu"
                ));
            Sorular.Add(new Class_Sorting_Soru(
                "Büyünü seç",
                "Expecto Patronum (Ruh emicilere karşı kalkan oluşturur)",
                "Obliviate (Hafıza silme büyüsü)",
                "Alohomora (Kilit açma büyüsü)",
                "Avada Kedavra (Kişiyi doğrudan öldüren tek lanet)"
                ));
            Sorular.Add(new Class_Sorting_Soru(
                "Evcil hayvanını seç",
                "Baykuş",
                "Kurbağa",
                "Kedi",
                "Yıan"
                ));
            Sorular.Add(new Class_Sorting_Soru(
                "Hogwarts'ta okusan en sevdiğin ders hangisi olurdu?",
                "Karanlık Sanatlara Karşı Savunma",
                "Biçim değiştirme",
                "Uçuş dersleri",
                "Biçim değiştirme"
                ));
            Sorular.Add(new Class_Sorting_Soru(
                "Karşına bir Böcürt (en çok korktuğun şeye dönüşen yaratıklar) çıksa neye dönüşürdü?",
                "Ruh emicilere",
                "Örümceğe",
                "Karanlığa",
                "Bir Muggle'a"
                ));
            Sorular.Add(new Class_Sorting_Soru(
                "Diyelim ki bir arkadaşının sınavda senden kopya çektiğini gördün, ne yapardın?",
                "Kağıdımı daha da açardım",
                "Görmezden gelirdim",
                "Onu şikayet ederdim",
                "Ben de ondan kopya çekerdim"
                ));
            Sorular.Add(new Class_Sorting_Soru(
                "Hogwarts'ta okusan en çok kimden nefret ederdin?",
                "Dolores Umbridge",
                "Argus Filch",
                "Severus Snape",
                "Minerva Mcgonagall"
                ));
            Sorular.Add(new Class_Sorting_Soru(
                "Büyülü bir yaratık seç!",
                "Ruh Emiciler",
                "Hippogriffler",
                "At Adamlar",
                "Ev Cinleri"
                ));
        }
        public List<Class_Sorting_Soru> Listele()
        {
            Random random = new Random();
            List<Class_Sorting_Soru> Doncecek = new List<Class_Sorting_Soru>();
            for (int i = 0; i < 5; i++)
            {
                int sor = random.Next(Sorular.Count);
                Doncecek.Add(Sorular[sor]);
                Sorular.RemoveAt(sor);
            }
            return Doncecek;
        }

    }
}
