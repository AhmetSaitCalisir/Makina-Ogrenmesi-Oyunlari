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
    public partial class Form_CarCup : Form
    {
        public Form_CarCup()
        {
            InitializeComponent();
        }

        private static Class_CarCup class_CarCup = new Class_CarCup();

        internal static Class_CarCup Class_CarCup { get => class_CarCup; set => class_CarCup = value; }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form_CarCup_Load(object sender, EventArgs e)
        {
            
            lbl_NesneAdi.Text=class_CarCup.NesneSor(0);
        }

        private void btn_Tree_Click(object sender, EventArgs e)
        {
            if (class_CarCup.Kontrol(btn_Tree.Tag.ToString()))
            {
                lbl_NesneAdi.Text = class_CarCup.NesneSor(0);
                btn_Tree.Visible = false;
            }
            else
            {
                MessageBox.Show("Tekrar denemelisinnnn...");
            }
            
        }

        private void btn_RedCar_Click(object sender, EventArgs e)
        {
            if (class_CarCup.Kontrol(btn_RedCar.Tag.ToString()))
            {
                lbl_NesneAdi.Text = class_CarCup.NesneSor(0);
                btn_RedCar.Visible = false;
            }
            else
            {
                MessageBox.Show("Tekrar denemelisinnnn...");
            }
        }

        private void btn_Cat_Click(object sender, EventArgs e)
        {
            if (class_CarCup.Kontrol(btn_Cat.Tag.ToString()))
            {
                lbl_NesneAdi.Text = class_CarCup.NesneSor(0);
                btn_Cat.Visible = false;
            }
            else
            {
                MessageBox.Show("Tekrar denemelisinnnn...");
            }
        }

        private void btn_House_Click(object sender, EventArgs e)
        {
            if (class_CarCup.Kontrol(btn_House.Tag.ToString()))
            {
                lbl_NesneAdi.Text = class_CarCup.NesneSor(0);
                btn_House.Visible = false;
            }
            else
            {
                MessageBox.Show("Tekrar denemelisinnnn...");
            }
        }

        private void btn_Computer_Click(object sender, EventArgs e)
        {
            if (class_CarCup.Kontrol(btn_Computer.Tag.ToString()))
            {
                lbl_NesneAdi.Text = class_CarCup.NesneSor(0);
                btn_Computer.Visible = false;
            }
            else
            {
                MessageBox.Show("Tekrar denemelisinnnn...");
            }
        }

        private void btn_Book_Click(object sender, EventArgs e)
        {
            if (class_CarCup.Kontrol(btn_Book.Tag.ToString()))
            {
                lbl_NesneAdi.Text = class_CarCup.NesneSor(0);
                btn_Book.Visible = false;
            }
            else
            {
                MessageBox.Show("Tekrar denemelisinnnn...");
            }
        }

        private void btn_Chair_Click(object sender, EventArgs e)
        {
            if (class_CarCup.Kontrol(btn_Chair.Tag.ToString()))
            {
                lbl_NesneAdi.Text = class_CarCup.NesneSor(0);
                btn_Chair.Visible = false;
            }
            else
            {
                MessageBox.Show("Tekrar denemelisinnnn...");
            }
        }

        private void btn_Soup_Click(object sender, EventArgs e)
        {
            if (class_CarCup.Kontrol(btn_Soup.Tag.ToString()))
            {
                lbl_NesneAdi.Text = class_CarCup.NesneSor(0);
                btn_Soup.Visible = false;
            }
            else
            {
                MessageBox.Show("Tekrar denemelisinnnn...");
            }
        }

        private void btn_Radio_Click(object sender, EventArgs e)
        {
            if (class_CarCup.Kontrol(btn_Radio.Tag.ToString()))
            {
                lbl_NesneAdi.Text = class_CarCup.NesneSor(0);
                btn_Radio.Visible = false;
            }
            else
            {
                MessageBox.Show("Tekrar denemelisinnnn...");
            }
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Form_Giris form_Giris = new Form_Giris();
            form_Giris.Show();
            this.Hide();
        }
    }
}
