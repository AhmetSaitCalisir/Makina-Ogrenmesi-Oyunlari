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
    public partial class Form_Chameleon : Form
    {
        public Form_Chameleon()
        {
            InitializeComponent();
        }
        private static Class_Chameleon class_Chameleon = new Class_Chameleon();

        internal static Class_Chameleon Class_Chameleon { get => class_Chameleon; set => class_Chameleon = value; }

        private void Form_Chameleon_Load(object sender, EventArgs e)
        {
            pictrBx_Soru.ImageLocation = class_Chameleon.ResimGoster(0);
            pictrBx_Soru.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            
        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            Form_Giris form_Giris = new Form_Giris();
            form_Giris.Show();
            this.Hide();
        }

        private void btn_Renk1_Click(object sender, EventArgs e)
        {
            class_Chameleon.ButonKontrol(btn_Renk1, btn_Renk2, btn_Renk3);
            if (class_Chameleon.Kontrol(btn_Renk1.Text))
            {
                pictrBx_Soru.ImageLocation = class_Chameleon.ResimGoster(0);
                pictrBx_Soru.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            }
            else
            {
                MessageBox.Show("Bilemedinnnnn!!!!!");
            }
        }

        private void btn_Renk2_Click(object sender, EventArgs e)
        {
            class_Chameleon.ButonKontrol(btn_Renk1, btn_Renk2, btn_Renk3);
            if (class_Chameleon.Kontrol(btn_Renk2.Text))
            {
                pictrBx_Soru.ImageLocation = class_Chameleon.ResimGoster(0);
                pictrBx_Soru.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            }
            else
            {
                MessageBox.Show("Bilemedinnnnn!!!!!");
            }
        }

        private void btn_Renk3_Click(object sender, EventArgs e)
        {
            class_Chameleon.ButonKontrol(btn_Renk1, btn_Renk2, btn_Renk3);
            if (class_Chameleon.Kontrol(btn_Renk3.Text))
            {
                pictrBx_Soru.ImageLocation = class_Chameleon.ResimGoster(0);
                pictrBx_Soru.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            }
            else
            {
                MessageBox.Show("Bilemedinnnnn!!!!!");
            }
        }
    }
}
