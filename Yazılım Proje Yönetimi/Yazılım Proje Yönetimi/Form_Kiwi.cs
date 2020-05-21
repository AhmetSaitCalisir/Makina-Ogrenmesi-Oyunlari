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
    public partial class Form_Kiwi : Form
    {
        Class_KiwiResimler class_KiwiResimler = new Class_KiwiResimler();
        List<Class_KiwiResimCevap> Resimler = new List<Class_KiwiResimCevap>();
        public Form_Kiwi()
        {
            InitializeComponent();
        }

        private void button_Cikis_Click(object sender, EventArgs e)
        {
            Form_Giris form_Giris = new Form_Giris();
            form_Giris.Show();
            this.Hide();
        }

        private void Form_Kiwi_Load(object sender, EventArgs e)
        {
            Resimler = class_KiwiResimler.ResimGetir();
            class_KiwiResimler.Getir(pictureBox_Resim,Resimler[0]);
        }
        private void Goster(Button Cevap)
        {
            class_KiwiResimler.Cevapla(Cevap, Resimler, pictureBox_Resim);
        }

        private void button_Panda_Click(object sender, EventArgs e)
        {
            Goster(button_Panda);
        }

        private void button_Fil_Click(object sender, EventArgs e)
        {
            Goster(button_Fil);
        }

        private void button_Kirpi_Click(object sender, EventArgs e)
        {
            Goster(button_Kirpi);
        }

        private void button_Kuzu_Click(object sender, EventArgs e)
        {
            Goster(button_Kuzu);
        }

        private void button_Papagan_Click(object sender, EventArgs e)
        {
            Goster(button_Papagan);
        }
    }
}
