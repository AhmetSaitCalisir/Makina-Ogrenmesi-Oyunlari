namespace Yazılım_Proje_Yönetimi
{
    partial class Form_Chameleon
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
            this.pictrBx_Soru = new System.Windows.Forms.PictureBox();
            this.btn_Renk1 = new System.Windows.Forms.Button();
            this.btn_Renk2 = new System.Windows.Forms.Button();
            this.btn_Renk3 = new System.Windows.Forms.Button();
            this.lbl_Cumle = new System.Windows.Forms.Label();
            this.btn_Cikis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictrBx_Soru)).BeginInit();
            this.SuspendLayout();
            // 
            // pictrBx_Soru
            // 
            this.pictrBx_Soru.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictrBx_Soru.Location = new System.Drawing.Point(111, 59);
            this.pictrBx_Soru.Name = "pictrBx_Soru";
            this.pictrBx_Soru.Size = new System.Drawing.Size(251, 201);
            this.pictrBx_Soru.TabIndex = 0;
            this.pictrBx_Soru.TabStop = false;
            // 
            // btn_Renk1
            // 
            this.btn_Renk1.BackColor = System.Drawing.Color.Yellow;
            this.btn_Renk1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_Renk1.Location = new System.Drawing.Point(87, 309);
            this.btn_Renk1.Name = "btn_Renk1";
            this.btn_Renk1.Size = new System.Drawing.Size(75, 74);
            this.btn_Renk1.TabIndex = 1;
            this.btn_Renk1.Text = "Sarı";
            this.btn_Renk1.UseVisualStyleBackColor = false;
            this.btn_Renk1.Click += new System.EventHandler(this.btn_Renk1_Click);
            // 
            // btn_Renk2
            // 
            this.btn_Renk2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Renk2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_Renk2.Location = new System.Drawing.Point(196, 309);
            this.btn_Renk2.Name = "btn_Renk2";
            this.btn_Renk2.Size = new System.Drawing.Size(75, 74);
            this.btn_Renk2.TabIndex = 2;
            this.btn_Renk2.Text = "Mavi";
            this.btn_Renk2.UseVisualStyleBackColor = false;
            this.btn_Renk2.Click += new System.EventHandler(this.btn_Renk2_Click);
            // 
            // btn_Renk3
            // 
            this.btn_Renk3.BackColor = System.Drawing.Color.DeepPink;
            this.btn_Renk3.ForeColor = System.Drawing.Color.MistyRose;
            this.btn_Renk3.Location = new System.Drawing.Point(307, 309);
            this.btn_Renk3.Name = "btn_Renk3";
            this.btn_Renk3.Size = new System.Drawing.Size(75, 74);
            this.btn_Renk3.TabIndex = 3;
            this.btn_Renk3.Text = "Pembe";
            this.btn_Renk3.UseVisualStyleBackColor = false;
            this.btn_Renk3.Click += new System.EventHandler(this.btn_Renk3_Click);
            // 
            // lbl_Cumle
            // 
            this.lbl_Cumle.AutoSize = true;
            this.lbl_Cumle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(210)))), ((int)(((byte)(154)))));
            this.lbl_Cumle.Location = new System.Drawing.Point(139, 29);
            this.lbl_Cumle.Name = "lbl_Cumle";
            this.lbl_Cumle.Size = new System.Drawing.Size(197, 17);
            this.lbl_Cumle.TabIndex = 4;
            this.lbl_Cumle.Text = "Bukalemun hangi renk olmalı?";
            // 
            // btn_Cikis
            // 
            this.btn_Cikis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(128)))), ((int)(((byte)(126)))));
            this.btn_Cikis.Location = new System.Drawing.Point(412, 0);
            this.btn_Cikis.Name = "btn_Cikis";
            this.btn_Cikis.Size = new System.Drawing.Size(67, 34);
            this.btn_Cikis.TabIndex = 5;
            this.btn_Cikis.Text = "Çıkış";
            this.btn_Cikis.UseVisualStyleBackColor = true;
            this.btn_Cikis.Click += new System.EventHandler(this.btn_Cikis_Click);
            // 
            // Form_Chameleon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(128)))), ((int)(((byte)(173)))));
            this.ClientSize = new System.Drawing.Size(478, 445);
            this.Controls.Add(this.btn_Cikis);
            this.Controls.Add(this.lbl_Cumle);
            this.Controls.Add(this.btn_Renk3);
            this.Controls.Add(this.btn_Renk2);
            this.Controls.Add(this.btn_Renk1);
            this.Controls.Add(this.pictrBx_Soru);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Chameleon";
            this.Text = "Form_Chameleon";
            this.Load += new System.EventHandler(this.Form_Chameleon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictrBx_Soru)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictrBx_Soru;
        private System.Windows.Forms.Button btn_Renk1;
        private System.Windows.Forms.Button btn_Renk2;
        private System.Windows.Forms.Button btn_Renk3;
        private System.Windows.Forms.Label lbl_Cumle;
        private System.Windows.Forms.Button btn_Cikis;
    }
}