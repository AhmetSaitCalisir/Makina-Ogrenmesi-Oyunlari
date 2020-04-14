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
    public partial class Form_Titanic : Form
    {
        public Form_Titanic()
        {
            InitializeComponent();
        }

        private void textBox_Boy_TextChanged(object sender, EventArgs e)
        {
            bool isIntString = textBox_Boy.Text.All(char.IsDigit);
            if (!isIntString)
            {
                textBox_Boy.Text = "";
            }
        }

        private void button_Test_Click(object sender, EventArgs e)
        {
            if (textBox_Boy.Text == "" || textBox_Isim.Text == "" || textBox_Kilo.Text == "" || textBox_Yas.Text == "" || comboBox_Meslek.Text == "" || comboBox_Milliyet.Text == "")
            {
                MessageBox.Show("Tüm Alanların Dolu Olduğundan Emin Olun", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Class_Titanic_Puanla class_Titanic_Puanla = new Class_Titanic_Puanla(Convert.ToInt32(textBox_Yas.Text), comboBox_Milliyet.Text, comboBox_Meslek.Text, Convert.ToInt32(textBox_Boy.Text), Convert.ToInt32(textBox_Kilo.Text));
                DialogResult dialogResult;
                if (class_Titanic_Puanla.GetPuan() >= 100)
                {
                    dialogResult = MessageBox.Show("BRAVO "+textBox_Isim.Text+" \nSen tam bir hayatta kalansın. Titanik faciasından burnun bile kanamadan çıkarsın.", "HAYATTA KALDIN", MessageBoxButtons.RetryCancel);
                }
                else if (class_Titanic_Puanla.GetPuan() >= 50)
                {
                    dialogResult = MessageBox.Show("Tam olarak hayatta kalabileceğini söyliyemeyiz. Ama imkansız da değil. Kendine güvenirsen başarabilirsin", "TEHLİKELİ", MessageBoxButtons.RetryCancel);
                }
                else if (class_Titanic_Puanla.GetPuan() >= 0)
                {
                    dialogResult = MessageBox.Show("Hayatta kalabilirsin belki ama çok fazla şey feda etmen gerek", "ÇOK TEHLİKELİ", MessageBoxButtons.RetryCancel);
                }
                else
                {
                    dialogResult = MessageBox.Show("Maalesef " + textBox_Isim.Text + " \nİyi ki o gemide değilsin çünkü sonu senin için hiçte iyi bitmezmiş", "HAYATTA KALAMADIN", MessageBoxButtons.RetryCancel);
                }
                if (dialogResult == DialogResult.Retry)
                {
                    Form_Titanic form_Titanic = new Form_Titanic();
                    form_Titanic.Show();
                    this.Hide();
                }
                else if (dialogResult==DialogResult.Cancel)
                {
                    Form_Giris form_Giris = new Form_Giris();
                    form_Giris.Show();
                    this.Hide();
                }
            }
        }

        private void button_Cikis_Click(object sender, EventArgs e)
        {
            Form_Giris form_Giris = new Form_Giris();
            form_Giris.Show();
            this.Hide();
        }

        private void textBox_Kilo_TextChanged(object sender, EventArgs e)
        {
            bool isIntString = textBox_Kilo.Text.All(char.IsDigit);
            if (!isIntString)
            {
                textBox_Kilo.Text = "";
            }
        }

        private void textBox_Yas_TextChanged(object sender, EventArgs e)
        {
            bool isIntString = textBox_Yas.Text.All(char.IsDigit);
            if (!isIntString)
            {
                textBox_Yas.Text = "";
            }
        }
    }
}
