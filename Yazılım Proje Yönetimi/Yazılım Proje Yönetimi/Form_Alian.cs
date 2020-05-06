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
    public partial class Form_Alian : Form
    {
        public Form_Alian()
        {
            InitializeComponent();
        }
        private int i=0;
        private static Class_AlianLanguage class_AlianLanguage = new Class_AlianLanguage();

        internal static Class_AlianLanguage Class_AlianLanguage { get => class_AlianLanguage; set => class_AlianLanguage = value; }

        private void Form_Alian_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtBx_Karsilik;
            txtBx_Harf.Text= Class_AlianLanguage.HarfGoster(i);
            btn_Basla.Visible = false;
        
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            this.ActiveControl = txtBx_Karsilik;
            i = i + 1;
            Class_AlianLanguage.SembolEkle(txtBx_Karsilik.Text);
            if (i <= 11)
            {
                txtBx_Harf.Text = Class_AlianLanguage.HarfGoster(i);
                txtBx_Karsilik.Text = "";
            }
            else
            {
                txtBx_Karsilik.Enabled = false;
                btn_Next.Enabled = false;
                btn_Basla.Visible = true;
            }
            
            

        }

        private void btn_Basla_Click(object sender, EventArgs e)
        {
            Form_Alian2 form_Alian2 = new Form_Alian2();
            form_Alian2.Show();
            this.Hide();
        }

        private void Btn_Cikis_Click(object sender, EventArgs e)
        {
            Form_Giris form_Giris = new Form_Giris();
            form_Giris.Show();
            this.Hide();
        }
    }
}
