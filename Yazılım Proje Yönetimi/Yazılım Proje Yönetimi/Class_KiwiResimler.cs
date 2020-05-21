using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yazılım_Proje_Yönetimi
{
    class Class_KiwiResimler
    {
        private List<Class_KiwiResimCevap> Resimler = new List<Class_KiwiResimCevap>();
        public Class_KiwiResimler()
        {
            Resimler.Add(new Class_KiwiResimCevap("../../Kiwi_Resimler/Fil.jpg","Fil"));
            Resimler.Add(new Class_KiwiResimCevap("../../Kiwi_Resimler/Kirpi.jpg", "Kirpi"));
            Resimler.Add(new Class_KiwiResimCevap("../../Kiwi_Resimler/Kuzu.jpg", "Kuzu"));
            Resimler.Add(new Class_KiwiResimCevap("../../Kiwi_Resimler/Panda.jpg", "Panda"));
            Resimler.Add(new Class_KiwiResimCevap("../../Kiwi_Resimler/Papağan.jpg", "Papağan"));
        }

        public void Getir(PictureBox Resim,Class_KiwiResimCevap class_KiwiResimCevap)
        {
            Resim.ImageLocation = class_KiwiResimCevap.Resim;
        }
        public void Cevapla(Button Cevap, List<Class_KiwiResimCevap> Resimler, PictureBox Resim)
        {
            if(Cevap.Text==Resimler[0].Cevap)
            {
                Cevap.Visible = false;
                try 
                {
                    Resimler.RemoveAt(0);
                    Getir(Resim, Resimler[0]);
                }
                catch
                {
                    MessageBox.Show("Tebrikler", "Oyun bitti", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Yanlış Cevap Dostum", "Hatalı Yanıt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public List<Class_KiwiResimCevap> ResimGetir()
        {
            List<Class_KiwiResimCevap> RastgeleResimler = new List<Class_KiwiResimCevap>();
            Random random = new Random();
            for(int i = 0; i<=4;i++)
            {
                int Ras = random.Next(Resimler.Count);
                RastgeleResimler.Add(Resimler[Ras]);
                Resimler.RemoveAt(Ras);
            }
            return RastgeleResimler;
        }
    }
}
