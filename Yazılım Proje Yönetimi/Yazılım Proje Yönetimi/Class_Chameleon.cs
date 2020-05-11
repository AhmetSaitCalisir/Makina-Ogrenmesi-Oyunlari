using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yazılım_Proje_Yönetimi
{
    class Class_Chameleon
    {
        private List<string> Resimler = new List<string>();

        private List<string> DogruCevap = new List<string>();

        public Class_Chameleon()
        {
            Resimler.Add("../../Resimler/Sarı1.jpg");
            Resimler.Add("../../Resimler/Mavi1.jpg");
            Resimler.Add("../../Resimler/Sarı2.jpg");
            Resimler.Add("../../Resimler/Pembe1.jpg");
            Resimler.Add("../../Resimler/Mavi2.jpg");
            Resimler.Add("../../Resimler/Pembe2.jpg");
            Resimler.Add("../../Resimler/Sarı3.jpg");
            Resimler.Add("../../Resimler/Mavi3.jpg");
            Resimler.Add("../../Resimler/Pembe3.jpg");
            CevapEkle();

        }

        public string ResimGoster(int index)
        {
            if (Resimler.Count == 0)
            {
                return "../../Resimler/gameOver.jpg";
            }
            else
            {
                return Resimler[index];
            }
            
        }

        public void CevapEkle()
        {
            DogruCevap.Add("Sarı");
            DogruCevap.Add("Mavi");
            DogruCevap.Add("Sarı");
            DogruCevap.Add("Pembe");
            DogruCevap.Add("Mavi");
            DogruCevap.Add("Pembe");
            DogruCevap.Add("Sarı");
            DogruCevap.Add("Mavi");
            DogruCevap.Add("Pembe");

        }

        public bool Kontrol(string gelen)
        {
            if (DogruCevap.Count == 0)
            {
                return true;
            }
            else
            {
                if (gelen == DogruCevap[0])
                {

                    DogruCevap.RemoveAt(0);
                    Resimler.RemoveAt(0);

                    return true;
                }
                else
                {
                    return false;
                }
            }
            
        }

        public void ButonKontrol(Button buttonSarı,Button buttonMavi,Button buttonPembe )
        {
            if (Resimler.Count == 0 )
            {
                buttonSarı.Enabled = false;
                buttonMavi.Enabled = false;
                buttonPembe.Enabled = false;
            }
        }


    }
}
