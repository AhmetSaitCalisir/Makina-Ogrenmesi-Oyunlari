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
    public partial class Form_Tourist : Form
    {
        public Form_Tourist()
        {
            InitializeComponent();
        }

        private void button_Cikis_Click(object sender, EventArgs e)
        {
            Form_Giris form_Giris = new Form_Giris();
            form_Giris.Show();
            this.Hide();
        }

        private void button_Planla_Click(object sender, EventArgs e)
        {
            if (textBox_Isim.Text == "" || comboBox_Dil.Text == "" || comboBox_Lokasyon.Text == "" || comboBox_Mevsim.Text == "" || comboBox_Tur.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanların dolu olduğundan emin olun", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Class_Tourist_YerAyarlama class_Tourist_YerAyarlama = new Class_Tourist_YerAyarlama(comboBox_Mevsim.Text, comboBox_Lokasyon.Text, comboBox_Dil.Text, comboBox_Tur.Text);
                DialogResult dialogResult = MessageBox.Show("Sevgili "+textBox_Isim.Text+" Senin için en uygun seyehat şehri " + class_Tourist_YerAyarlama.SehirSec() + "\nBu şehir tam senin aradığın şehir", "İyi Tatiller", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Retry)
                {
                    Form_Tourist form_Tourist = new Form_Tourist();
                    form_Tourist.Show();
                    this.Hide();
                }
                else if (dialogResult == DialogResult.Cancel)
                {
                    Form_Giris form_Giris = new Form_Giris();
                    form_Giris.Show();
                    this.Hide();
                }
            }
        }
    }
}
