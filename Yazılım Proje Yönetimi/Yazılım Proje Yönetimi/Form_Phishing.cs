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
    public partial class Form_Phishing : Form
    {
        Class_Phishing_Sorular Class_Phishing_Sorular = new Class_Phishing_Sorular();
        int Puan = 0;
        int Alinan_Harf = 0;
        public Form_Phishing()
        {
            InitializeComponent();
        }
        
        private void btn_Cevapla_Click(object sender, EventArgs e)
        {
            if (textbox_Cevap.Text == Class_Phishing_Sorular.Sorular[0].Cevap)
            {
                Puan += 15 - Alinan_Harf;
                Class_Phishing_Sorular.SoruGec();
                if (Class_Phishing_Sorular.Sorular.Count == 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Tebrikler Bitirdiniz \nPuanınız: " + Puan, "TEBRİKLER", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Cancel)
                    {
                        Form_Giris form_Giris = new Form_Giris();
                        form_Giris.Show();
                        this.Hide();
                    }
                    else if (dialogResult == DialogResult.Retry)
                    {
                        Form_Phishing form_Phishing = new Form_Phishing();
                        form_Phishing.Show();
                        this.Hide();
                    }
                }
                else
                {
                    textbox_Soru.Text = Class_Phishing_Sorular.Sorular[0].Soru;
                    Alinan_Harf = 0;
                    textbox_Cevap.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Yanlış cevap", ":(", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form_Phishing_Load(object sender, EventArgs e)
        {
            textbox_Soru.Text = Class_Phishing_Sorular.Sorular[0].Soru;
        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            Form_Giris form_Giris = new Form_Giris();
            form_Giris.Show();
            this.Hide();
        }

        private void btn_Ipucu_Click(object sender, EventArgs e)
        {
            if (Alinan_Harf >= 10)
            {
                MessageBox.Show("Maalesef maksimum sayıda harf aldınız", ":(", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textbox_Cevap.Text = Class_Phishing_Sorular.IpucuVer(Alinan_Harf);
            }
            else
            {
                Alinan_Harf++;
                textbox_Cevap.Text = Class_Phishing_Sorular.IpucuVer(Alinan_Harf);
            }
        }

        private void textbox_Cevap_MouseClick(object sender, MouseEventArgs e)
        {
            if (textbox_Cevap.Text == "Buraya Cevaplayın")
            {
                textbox_Cevap.Text = "";
            }
        }
    }
}
