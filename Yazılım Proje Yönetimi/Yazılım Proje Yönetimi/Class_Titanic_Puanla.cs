using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yazılım_Proje_Yönetimi
{
    class Class_Titanic_Puanla
    {
        private int Puan;
        public Class_Titanic_Puanla(int Yas, string Milliyet, string Meslek, int Boy, int Kilo)
        {
            Puan = 0;
            Puan = (Yas >= 17 && Yas <= 45) ? Puan += 50 : Puan -= 10;
            Puan = (Milliyet == "Türkiye") ? Puan += 35 : Puan;
            Puan = (Milliyet == "Yunanistan") ? Puan += 60 : Puan;
            Puan = (Milliyet == "Çin") ? Puan -= 30 : Puan;
            Puan = (Milliyet == "Türkiye") ? Puan += 20 : Puan;
            Puan = (Milliyet == "ABD" || Milliyet == "Arjantin" || Milliyet == "Brezilya" || Milliyet == "İtalya" || Milliyet == "Japonya") ? Puan += 20 : Puan;
            Puan = (Milliyet == "Rusya" || Milliyet == "Almanya") ? Puan -= 15 : Puan;
            Puan = (Meslek == "General" || Meslek == "Yüzbaşı" || Meslek == "Astsubay") ? Puan += 35 : Puan;
            Puan = (Meslek == "Vali" || Meslek == "Mimar" || Meslek == "Genel müdür") ? Puan -= 20 : Puan;
            Puan = (Meslek == "Makine mühendisi" || Meslek == "Elektrik mühendisi" || Meslek == "İnşaat mühendisi") ? Puan += 5 : Puan;
            double Indeks = Kilo / ((Convert.ToDouble(Boy) / 100)* (Convert.ToDouble(Boy) / 100));
            Puan = (Indeks > 20 && Indeks < 25) ? Puan += 40 : Puan -= 5;
            Puan = (Indeks > 30 || Indeks < 15) ? Puan -= 40 : Puan;
        }
        public int GetPuan()
        {
            return Puan;
        }
    }
}
