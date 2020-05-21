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
    public partial class Form_Sorting : Form
    {
        public Form_Sorting()
        {
            InitializeComponent();
        }
        Class_Sorting_Sorular class_Sorting_Sorular = new Class_Sorting_Sorular();
        List<Class_Sorting_Soru> Sorular = new List<Class_Sorting_Soru>();
        List<string> Cevaplar = new List<string>();
        private void buttonCikis_Click(object sender, EventArgs e)
        {
            Form_Giris form_Giris = new Form_Giris();
            form_Giris.Show();
            this.Hide();
        }

        private void button_Sec_Click(object sender, EventArgs e)
        {
            Sor();
        }

        private void Form_Sorting_Load(object sender, EventArgs e)
        {
            Sorular = class_Sorting_Sorular.Listele();
            Sor();
        }
        private void Sor()
        {
            try
            {
                if (comboBox_Cevaplar.Items.Count != 0)
                {
                    class_Sorting_Sorular.Cevapla(Cevaplar[comboBox_Cevaplar.SelectedIndex]);
                }
                comboBox_Cevaplar.Items.Clear();
                Cevaplar.Clear();
                richTextBox_Soru.Text = Sorular[0].Soru;
                comboBox_Cevaplar.Items.Add(Sorular[0].Cevap1[0]);
                Cevaplar.Add(Sorular[0].Cevap1[1]);
                comboBox_Cevaplar.Items.Add(Sorular[0].Cevap2[0]);
                Cevaplar.Add(Sorular[0].Cevap2[1]);
                comboBox_Cevaplar.Items.Add(Sorular[0].Cevap3[0]);
                Cevaplar.Add(Sorular[0].Cevap3[1]);
                comboBox_Cevaplar.Items.Add(Sorular[0].Cevap4[0]);
                Cevaplar.Add(Sorular[0].Cevap4[1]);
                Sorular.RemoveAt(0);
                comboBox_Cevaplar.Text = "";
            }
            catch
            {
                DialogResult dialogResult = MessageBox.Show(class_Sorting_Sorular.Bitir(textBox_Ad.Text), "Bitti", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Retry)
                {
                    Form_Sorting form_Sorting = new Form_Sorting();
                    form_Sorting.Show();
                    this.Hide();
                }
                else
                {
                    Form_Giris form_Giris = new Form_Giris();
                    form_Giris.Show();
                    this.Hide();
                }
            }
        }
    }
}
