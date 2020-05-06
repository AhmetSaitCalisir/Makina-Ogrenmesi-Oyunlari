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
    public partial class Form_Giris : Form
    {
        public Form_Giris()
        {
            InitializeComponent();
        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Phishing_Click(object sender, EventArgs e)
        {
            Form_Phishing form_Phishing = new Form_Phishing();
            form_Phishing.Show();
            this.Hide();
        }

        private void btn_Titanic_Click(object sender, EventArgs e)
        {
            Form_Titanic form_Titanic = new Form_Titanic();
            form_Titanic.Show();
            this.Hide();
        }

        private void btn_Tourist_Click(object sender, EventArgs e)
        {
            Form_Tourist form_Tourist = new Form_Tourist();
            form_Tourist.Show();
            this.Hide();
        }

        private void btn_Sorting_Click(object sender, EventArgs e)
        {
            Form_Sorting form_Sorting = new Form_Sorting();
            form_Sorting.Show();
            this.Hide();
        }

        private void btn_Alian_Click(object sender, EventArgs e)
        {
            Form_Alian form_Alian = new Form_Alian();
            form_Alian.Show();
            this.Hide();
        }
    }
}
