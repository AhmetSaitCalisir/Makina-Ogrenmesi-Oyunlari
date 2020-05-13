using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yazılım_Proje_Yönetimi
{
    public partial class Form_FindIt : Form
    {
        public Form_FindIt()
        {
            InitializeComponent();
        }
        public int puan = 0;
        private static Class_FindIt class_FindIt = new Class_FindIt();

        internal static Class_FindIt Class_FindIt { get => class_FindIt; set => class_FindIt = value; }

        private void Form_FindIt_Load(object sender, EventArgs e)
        {
            pictureBx_Soru.ImageLocation = class_FindIt.ResimGoster();
            pictureBx_Soru.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            //pictureBx_Soru.ImageLocation = "../../FindItResimler/beach.jpg";
            
        }

        private void btn_SonrakiSoru_Click(object sender, EventArgs e)
        {
            txtBx_Cevap1.Clear();
            txtBx_Cevap2.Clear();
            txtBx_Cevap3.Clear();
            puan += class_FindIt.Kontrol(txtBx_Cevap1.Text, txtBx_Cevap2.Text, txtBx_Cevap3.Text, puan);
            class_FindIt.Sil();
            pictureBx_Soru.ImageLocation = class_FindIt.ResimGoster();
        
            class_FindIt.ButonKontrol(btn_SonrakiSoru);
            if (!btn_SonrakiSoru.Enabled)
            {
                MessageBox.Show("Tebriklerrrrr \nPuanınız: "+puan.ToString(),"OYUN BİTTİ");
            }

        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            Form_Giris form_Giris = new Form_Giris();
            form_Giris.Show();
            this.Hide();
        }
    }
}
