using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Yazılım_Proje_Yönetimi
{
    class Class_Tourist_YerAyarlama
    {
        private List<string> Sehirler = new List<string>();
        public Class_Tourist_YerAyarlama(string Mevsim,string Lokasyon, string Dil, string Tur)
        {
            Sehirler.Add("Antalya");
            Sehirler.Add("İzmir");
            Sehirler.Add("Paris");
            Sehirler.Add("New York");
            if (Mevsim == "Yaz") 
            {
                Sehirler.Add("Muğla");
                Sehirler.Add("Antalya");
                Sehirler.Add("İzmir");
                Sehirler.Add("Kıbrıs");
                Sehirler.Add("Mersin");
            }
            else if (Mevsim == "Kış")
            {
                Sehirler.Add("Kars");
                Sehirler.Add("Nevşehir");
                Sehirler.Add("Bolu");
                Sehirler.Add("Bursa");
                Sehirler.Add("Kocaeli");
            }
            else if (Mevsim == "Bahar")
            {
                Sehirler.Add("Bolu");
                Sehirler.Add("Mardin");
                Sehirler.Add("Alanya");
                Sehirler.Add("Çanakkale");
                Sehirler.Add("Trabzon");
            }
            if (Lokasyon == "Deniz kenarı")
            {
                Sehirler.Add("Antalya");
                Sehirler.Add("Balıkesir");
                Sehirler.Add("Çanakkale");
                Sehirler.Add("Muğla");
                Sehirler.Add("İstanbul");
            }
            else if (Lokasyon == "Dağ")
            {
                Sehirler.Add("Balıkesir");
                Sehirler.Add("Samsun");
                Sehirler.Add("Kocaeli");
                Sehirler.Add("Giresun");
                Sehirler.Add("İzmir");
            }
            else if (Lokasyon == "Şehir")
            {
                Sehirler.Add("Roma");
                Sehirler.Add("Paris");
                Sehirler.Add("Amsterdam");
                Sehirler.Add("Prag");
                Sehirler.Add("Barselona");
            }
            else if (Lokasyon == "Orman")
            {
                Sehirler.Add("Bolu");
                Sehirler.Add("Trabzon");
                Sehirler.Add("Antalya");
                Sehirler.Add("Tunceli");
                Sehirler.Add("Erzurum");
            }
            if (Dil == "Türkçe")
            {
                Sehirler.Add("Antalya");
                Sehirler.Add("Muğla");
                Sehirler.Add("Çanakkale");
                Sehirler.Add("Sinop");
                Sehirler.Add("Samsun");
            }
            else if (Dil == "İngilizce")
            {
                Sehirler.Add("San Francisco");
                Sehirler.Add("Bristol");
                Sehirler.Add("Vancouver");
                Sehirler.Add("Brisbane");
                Sehirler.Add("Auckland");
            }
            else if (Dil == "Almanca")
            {
                Sehirler.Add("Berlin");
                Sehirler.Add("Münih");
                Sehirler.Add("Koblenz");
                Sehirler.Add("Konstanz");
                Sehirler.Add("Winterberg");
            }
            else if (Dil == "Fransızca")
            {
                Sehirler.Add("Paris");
                Sehirler.Add("Nice");
                Sehirler.Add("Marsilya");
                Sehirler.Add("Bordeaux");
                Sehirler.Add("Strazburg");
            }
            if (Tur == "Romantik")
            {
                Sehirler.Add("Budapeşte");
                Sehirler.Add("Floransa");
                Sehirler.Add("Prag");
                Sehirler.Add("Paris");
                Sehirler.Add("Londra");
            }
            else if (Tur == "Eğlence")
            {
                Sehirler.Add("Belgrad");
                Sehirler.Add("Playa Del Carmen");
                Sehirler.Add("Singapur");
                Sehirler.Add("St. Petersburg");
                Sehirler.Add("Los Cabos");
            }
            else if (Tur == "Sessiz")
            {
                Sehirler.Add("Balıkesir");
                Sehirler.Add("Çanakkale");
                Sehirler.Add("Yalova");
                Sehirler.Add("Bursa");
                Sehirler.Add("Kırklareli");
            }
            else if (Tur == "Yeni yerler")
            {
                Sehirler.Add("İzmir");
                Sehirler.Add("Edirne");
                Sehirler.Add("Balıkesir");
                Sehirler.Add("Muğla");
                Sehirler.Add("Gümüşhane");
            }
        }
        public string SehirSec()
        {
            Random random = new Random();
            return Sehirler[random.Next(Sehirler.Count)];
        }
    }
}
