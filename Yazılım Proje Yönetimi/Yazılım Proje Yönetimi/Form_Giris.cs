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
    }
}
