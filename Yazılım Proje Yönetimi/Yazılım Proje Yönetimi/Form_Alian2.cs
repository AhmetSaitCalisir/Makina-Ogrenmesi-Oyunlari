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
    
    public partial class Form_Alian2 : Form
    {
        
        public Form_Alian2()
        {
            InitializeComponent();
        }

        
        
        public int i = 0;
        public string dogruCevap;
        private void Form_Alian2_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtBx_Cevap;
            txtBx_SorulanKelime.Text = Form_Alian.Class_AlianLanguage.KelimeGoster(i);

        }
        private void Btn_Cikis_Click(object sender, EventArgs e)
        {
            Form_Giris form_Giris = new Form_Giris();
            form_Giris.Show();
            this.Hide();
        }

        private void btn_Check_Click(object sender, EventArgs e)
        {
            this.ActiveControl = txtBx_Cevap;

            if (txtBx_Cevap.Text == Form_Alian.Class_AlianLanguage.CevapDon(txtBx_SorulanKelime.Text))
            {
                
                //CEVAP DOĞRUYSA YAPILACAKLAR
                i = i + 1;
                if (i <=15)
                {
                    txtBx_SorulanKelime.Text = Form_Alian.Class_AlianLanguage.KelimeGoster(i);
                    txtBx_Cevap.Clear();
                }
                else
                {
                    txtBx_Cevap.Enabled = false;
                    btn_Check.Enabled = false;
                    MessageBox.Show("Oyun bitti");
                }
            }
            else
            {
                MessageBox.Show("CEVABINIZ HATALI");
                MessageBox.Show(Form_Alian.Class_AlianLanguage.CevapDon(txtBx_SorulanKelime.Text));
                //CEVAP YANLIŞSA YAPILACAKLAR
               // txtBx_Cevap.Enabled = false;
            }

            
            
        }
    }
}
