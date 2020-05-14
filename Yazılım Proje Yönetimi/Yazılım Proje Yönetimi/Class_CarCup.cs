using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yazılım_Proje_Yönetimi
{
    class Class_CarCup
    {
        public List<string> SorulacakNesneler = new List<string>();

        public Class_CarCup()
        {
            SorulacakNesneler.Add("Ağaç");
            SorulacakNesneler.Add("Sandalye");
            SorulacakNesneler.Add("Kedi");
            SorulacakNesneler.Add("Radyo");
            SorulacakNesneler.Add("Kırmızı Araba");
            SorulacakNesneler.Add("Çorba");
            SorulacakNesneler.Add("Kitap");
            SorulacakNesneler.Add("Bilgisayar");
            SorulacakNesneler.Add("Ev");
        }

        public string NesneSor(int index)
        {
           
            return SorulacakNesneler[index];
        }

        public bool Kontrol(string gelen)
        {
            if(gelen== SorulacakNesneler[0])
            {
                SorulacakNesneler.RemoveAt(0);

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
