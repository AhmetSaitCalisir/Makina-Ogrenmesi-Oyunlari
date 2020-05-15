namespace Yazılım_Proje_Yönetimi
{
    partial class Form_MakeMeHappy
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
            this.cmbBx_Söz = new System.Windows.Forms.ComboBox();
            this.pictureBox_Resim = new System.Windows.Forms.PictureBox();
            this.btn_Cikis = new System.Windows.Forms.Button();
            this.lbl_Secilen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Resim)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBx_Söz
            // 
            this.cmbBx_Söz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(255)))), ((int)(((byte)(223)))));
            this.cmbBx_Söz.FormattingEnabled = true;
            this.cmbBx_Söz.Location = new System.Drawing.Point(197, 320);
            this.cmbBx_Söz.Name = "cmbBx_Söz";
            this.cmbBx_Söz.Size = new System.Drawing.Size(158, 24);
            this.cmbBx_Söz.TabIndex = 0;
            this.cmbBx_Söz.SelectedIndexChanged += new System.EventHandler(this.cmbBx_Söz_SelectedIndexChanged);
            // 
            // pictureBox_Resim
            // 
            this.pictureBox_Resim.Location = new System.Drawing.Point(114, 12);
            this.pictureBox_Resim.Name = "pictureBox_Resim";
            this.pictureBox_Resim.Size = new System.Drawing.Size(316, 292);
            this.pictureBox_Resim.TabIndex = 1;
            this.pictureBox_Resim.TabStop = false;
            // 
            // btn_Cikis
            // 
            this.btn_Cikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(255)))), ((int)(((byte)(223)))));
            this.btn_Cikis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            this.btn_Cikis.Location = new System.Drawing.Point(486, -1);
            this.btn_Cikis.Name = "btn_Cikis";
            this.btn_Cikis.Size = new System.Drawing.Size(75, 31);
            this.btn_Cikis.TabIndex = 2;
            this.btn_Cikis.Text = "Çıkış";
            this.btn_Cikis.UseVisualStyleBackColor = false;
            this.btn_Cikis.Click += new System.EventHandler(this.btn_Cikis_Click);
            // 
            // lbl_Secilen
            // 
            this.lbl_Secilen.AutoSize = true;
            this.lbl_Secilen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(192)))), ((int)(((byte)(235)))));
            this.lbl_Secilen.Location = new System.Drawing.Point(249, 401);
            this.lbl_Secilen.Name = "lbl_Secilen";
            this.lbl_Secilen.Size = new System.Drawing.Size(38, 17);
            this.lbl_Secilen.TabIndex = 3;
            this.lbl_Secilen.Text = "word";
            // 
            // Form_MakeMeHappy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            this.ClientSize = new System.Drawing.Size(559, 498);
            this.Controls.Add(this.lbl_Secilen);
            this.Controls.Add(this.btn_Cikis);
            this.Controls.Add(this.pictureBox_Resim);
            this.Controls.Add(this.cmbBx_Söz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_MakeMeHappy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_MakeMeHappy";
            this.Load += new System.EventHandler(this.Form_MakeMeHappy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Resim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBx_Söz;
        private System.Windows.Forms.PictureBox pictureBox_Resim;
        private System.Windows.Forms.Button btn_Cikis;
        private System.Windows.Forms.Label lbl_Secilen;
    }
}