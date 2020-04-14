using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yazılım_Proje_Yönetimi
{
    public class Class_Phishing_Sorular
    {
        public List<Class_Phishing_Soru> Sorular = new List<Class_Phishing_Soru>();
        public Class_Phishing_Sorular ()
        {
            Sorular.Add(new Class_Phishing_Soru("Google arama motorunun urlsi nedir?", "google.com.tr"));
            Sorular.Add(new Class_Phishing_Soru("Türk Dil Kurumu'nun urlsi nedir?", "sozluk.gov.tr"));
            Sorular.Add(new Class_Phishing_Soru("e-Devlet'in urlsi nedir?", "turkiye.gov.tr"));
            Sorular.Add(new Class_Phishing_Soru("Merkezi Hekim Randevu Sistemi'nin urlsi nedir?", "mhrs.gov.tr"));
        }
        public void SoruGec() 
        {
            Sorular.RemoveAt(0);
        }
        public string IpucuVer(int harf)
        {
            return Sorular[0].Cevap.Substring(0, harf);
        }
    }
}
