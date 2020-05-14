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
    public partial class Form_MakeMeHappy : Form
    {
        public Form_MakeMeHappy()
        {
            InitializeComponent();
        }

        private static Class_MakeMeHappy meHappy = new Class_MakeMeHappy();

        internal static Class_MakeMeHappy MeHappy { get => meHappy; set => meHappy = value; }

        public int point = 0;
        public int turn = 0;

        private void Form_MakeMeHappy_Load(object sender, EventArgs e)
        {
            foreach(string i in meHappy.NiceWords)
            {
                cmbBx_Söz.Items.Add(i);
            }
            foreach(string k in meHappy.BadWords)
            {
                cmbBx_Söz.Items.Add(k);
            }
            meHappy.ChangePicture(point, pictureBox_Resim);
            // pictureBox_Resim.ImageLocation = meHappy.SmileyFaces[0];

        }

        private void cmbBx_Söz_SelectedIndexChanged(object sender, EventArgs e)
        {

            turn = turn + 1;
            lbl_Secilen.Text = cmbBx_Söz.SelectedItem.ToString();
            point = meHappy.WordCheck(lbl_Secilen.Text, point);
            
            meHappy.ChangePicture(point , pictureBox_Resim);


            if (turn == 4)
            {
                cmbBx_Söz.Enabled = false;
                MessageBox.Show("Game over...\nPoint: "+point.ToString());
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
