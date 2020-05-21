using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yazılım_Proje_Yönetimi
{
    class Class_Sorting_Soru
    {
        public string Soru;
        public string[] Cevap1 = new string[2];
        public string[] Cevap2 = new string[2];
        public string[] Cevap3 = new string[2];
        public string[] Cevap4 = new string[2];
        public Class_Sorting_Soru(string Soru, string Gry, string Huff, string Rav, string Sly)
        {
            this.Soru = Soru;
            Cevap1[0] = Gry;
            Cevap1[1] = "Gryffindor";
            Cevap2[0] = Huff;
            Cevap2[1] = "Hufflepuff";
            Cevap3[0] = Rav;
            Cevap3[1] = "Ravenclaw";
            Cevap4[0] = Sly;
            Cevap4[1] = "Slytherin";
        }

        
    }
}
