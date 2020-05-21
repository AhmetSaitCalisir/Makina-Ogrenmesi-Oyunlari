namespace Yazılım_Proje_Yönetimi
{
    partial class Form_Alian2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBx_Cevap = new System.Windows.Forms.TextBox();
            this.txtBx_SorulanKelime = new System.Windows.Forms.TextBox();
            this.btn_Check = new System.Windows.Forms.Button();
            this.Btn_Cikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBx_Cevap
            // 
            this.txtBx_Cevap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(143)))), ((int)(((byte)(191)))));
            this.txtBx_Cevap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBx_Cevap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.txtBx_Cevap.Location = new System.Drawing.Point(63, 138);
            this.txtBx_Cevap.Multiline = true;
            this.txtBx_Cevap.Name = "txtBx_Cevap";
            this.txtBx_Cevap.Size = new System.Drawing.Size(240, 45);
            this.txtBx_Cevap.TabIndex = 1;
            this.txtBx_Cevap.Text = "Cevabınızı girin";
            // 
            // txtBx_SorulanKelime
            // 
            this.txtBx_SorulanKelime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(143)))), ((int)(((byte)(191)))));
            this.txtBx_SorulanKelime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBx_SorulanKelime.Location = new System.Drawing.Point(63, 61);
            this.txtBx_SorulanKelime.Multiline = true;
            this.txtBx_SorulanKelime.Name = "txtBx_SorulanKelime";
            this.txtBx_SorulanKelime.ReadOnly = true;
            this.txtBx_SorulanKelime.Size = new System.Drawing.Size(240, 45);
            this.txtBx_SorulanKelime.TabIndex = 2;
            // 
            // btn_Check
            // 
            this.btn_Check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(176)))), ((int)(((byte)(206)))));
            this.btn_Check.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.btn_Check.Location = new System.Drawing.Point(93, 223);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(164, 34);
            this.btn_Check.TabIndex = 3;
            this.btn_Check.Text = "Kontrol";
            this.btn_Check.UseVisualStyleBackColor = false;
            this.btn_Check.Click += new System.EventHandler(this.btn_Check_Click);
            // 
            // Btn_Cikis
            // 
            this.Btn_Cikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(176)))), ((int)(((byte)(206)))));
            this.Btn_Cikis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.Btn_Cikis.Location = new System.Drawing.Point(300, -1);
            this.Btn_Cikis.Name = "Btn_Cikis";
            this.Btn_Cikis.Size = new System.Drawing.Size(67, 34);
            this.Btn_Cikis.TabIndex = 4;
            this.Btn_Cikis.Text = "Çıkış";
            this.Btn_Cikis.UseVisualStyleBackColor = false;
            this.Btn_Cikis.Click += new System.EventHandler(this.Btn_Cikis_Click);
            // 
            // Form_Alian2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(195)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(363, 314);
            this.Controls.Add(this.Btn_Cikis);
            this.Controls.Add(this.btn_Check);
            this.Controls.Add(this.txtBx_SorulanKelime);
            this.Controls.Add(this.txtBx_Cevap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Alian2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Alian2";
            this.Load += new System.EventHandler(this.Form_Alian2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBx_Cevap;
        private System.Windows.Forms.TextBox txtBx_SorulanKelime;
        private System.Windows.Forms.Button btn_Check;
        private System.Windows.Forms.Button Btn_Cikis;
    }
}