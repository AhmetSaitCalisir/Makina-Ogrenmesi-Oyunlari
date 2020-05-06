namespace Yazılım_Proje_Yönetimi
{
    partial class Form_Alian
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
            this.btn_Next = new System.Windows.Forms.Button();
            this.txtBx_Harf = new System.Windows.Forms.TextBox();
            this.txtBx_Karsilik = new System.Windows.Forms.TextBox();
            this.lbl_Uyarı = new System.Windows.Forms.Label();
            this.btn_Basla = new System.Windows.Forms.Button();
            this.Btn_Cikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Next
            // 
            this.btn_Next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(143)))), ((int)(((byte)(191)))));
            this.btn_Next.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.btn_Next.Location = new System.Drawing.Point(148, 184);
            this.btn_Next.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(79, 46);
            this.btn_Next.TabIndex = 0;
            this.btn_Next.Text = "Sonraki Harf";
            this.btn_Next.UseVisualStyleBackColor = false;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // txtBx_Harf
            // 
            this.txtBx_Harf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(143)))), ((int)(((byte)(191)))));
            this.txtBx_Harf.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBx_Harf.Location = new System.Drawing.Point(88, 98);
            this.txtBx_Harf.Multiline = true;
            this.txtBx_Harf.Name = "txtBx_Harf";
            this.txtBx_Harf.ReadOnly = true;
            this.txtBx_Harf.Size = new System.Drawing.Size(60, 60);
            this.txtBx_Harf.TabIndex = 1;
            // 
            // txtBx_Karsilik
            // 
            this.txtBx_Karsilik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(143)))), ((int)(((byte)(191)))));
            this.txtBx_Karsilik.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F);
            this.txtBx_Karsilik.Location = new System.Drawing.Point(228, 98);
            this.txtBx_Karsilik.MaxLength = 1;
            this.txtBx_Karsilik.Multiline = true;
            this.txtBx_Karsilik.Name = "txtBx_Karsilik";
            this.txtBx_Karsilik.Size = new System.Drawing.Size(60, 60);
            this.txtBx_Karsilik.TabIndex = 2;
            // 
            // lbl_Uyarı
            // 
            this.lbl_Uyarı.AutoSize = true;
            this.lbl_Uyarı.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(143)))), ((int)(((byte)(191)))));
            this.lbl_Uyarı.Location = new System.Drawing.Point(55, 47);
            this.lbl_Uyarı.Name = "lbl_Uyarı";
            this.lbl_Uyarı.Size = new System.Drawing.Size(312, 17);
            this.lbl_Uyarı.TabIndex = 3;
            this.lbl_Uyarı.Text = "Lütfen kendi dilinizin alfabedeki karşılığını giriniz.";
            // 
            // btn_Basla
            // 
            this.btn_Basla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(176)))), ((int)(((byte)(206)))));
            this.btn_Basla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.btn_Basla.Location = new System.Drawing.Point(148, 261);
            this.btn_Basla.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Basla.Name = "btn_Basla";
            this.btn_Basla.Size = new System.Drawing.Size(79, 46);
            this.btn_Basla.TabIndex = 4;
            this.btn_Basla.Text = "Oyuna Başla";
            this.btn_Basla.UseVisualStyleBackColor = false;
            this.btn_Basla.Click += new System.EventHandler(this.btn_Basla_Click);
            // 
            // Btn_Cikis
            // 
            this.Btn_Cikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(176)))), ((int)(((byte)(206)))));
            this.Btn_Cikis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.Btn_Cikis.Location = new System.Drawing.Point(311, 1);
            this.Btn_Cikis.Name = "Btn_Cikis";
            this.Btn_Cikis.Size = new System.Drawing.Size(67, 34);
            this.Btn_Cikis.TabIndex = 5;
            this.Btn_Cikis.Text = "Çıkış";
            this.Btn_Cikis.UseVisualStyleBackColor = false;
            this.Btn_Cikis.Click += new System.EventHandler(this.Btn_Cikis_Click);
            // 
            // Form_Alian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(379, 347);
            this.Controls.Add(this.Btn_Cikis);
            this.Controls.Add(this.btn_Basla);
            this.Controls.Add(this.lbl_Uyarı);
            this.Controls.Add(this.txtBx_Karsilik);
            this.Controls.Add(this.txtBx_Harf);
            this.Controls.Add(this.btn_Next);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_Alian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "\"";
            this.Load += new System.EventHandler(this.Form_Alian_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.TextBox txtBx_Harf;
        private System.Windows.Forms.TextBox txtBx_Karsilik;
        private System.Windows.Forms.Label lbl_Uyarı;
        private System.Windows.Forms.Button btn_Basla;
        private System.Windows.Forms.Button Btn_Cikis;
    }
}