namespace Yazılım_Proje_Yönetimi
{
    partial class Form_Phishing
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
            this.btn_Cevapla = new System.Windows.Forms.Button();
            this.btn_Cikis = new System.Windows.Forms.Button();
            this.textbox_Cevap = new System.Windows.Forms.RichTextBox();
            this.btn_Ipucu = new System.Windows.Forms.Button();
            this.textbox_Soru = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_Cevapla
            // 
            this.btn_Cevapla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btn_Cevapla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cevapla.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Bold);
            this.btn_Cevapla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(59)))), ((int)(((byte)(66)))));
            this.btn_Cevapla.Location = new System.Drawing.Point(12, 254);
            this.btn_Cevapla.Name = "btn_Cevapla";
            this.btn_Cevapla.Size = new System.Drawing.Size(338, 52);
            this.btn_Cevapla.TabIndex = 0;
            this.btn_Cevapla.Text = "Cevapla";
            this.btn_Cevapla.UseVisualStyleBackColor = false;
            this.btn_Cevapla.Click += new System.EventHandler(this.btn_Cevapla_Click);
            // 
            // btn_Cikis
            // 
            this.btn_Cikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(205)))), ((int)(((byte)(230)))));
            this.btn_Cikis.FlatAppearance.BorderSize = 0;
            this.btn_Cikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cikis.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Cikis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(59)))), ((int)(((byte)(66)))));
            this.btn_Cikis.Location = new System.Drawing.Point(472, 0);
            this.btn_Cikis.Name = "btn_Cikis";
            this.btn_Cikis.Size = new System.Drawing.Size(94, 27);
            this.btn_Cikis.TabIndex = 2;
            this.btn_Cikis.Text = "ÇIKIŞ";
            this.btn_Cikis.UseVisualStyleBackColor = false;
            this.btn_Cikis.Click += new System.EventHandler(this.btn_Cikis_Click);
            // 
            // textbox_Cevap
            // 
            this.textbox_Cevap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.textbox_Cevap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_Cevap.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Bold);
            this.textbox_Cevap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(59)))), ((int)(((byte)(66)))));
            this.textbox_Cevap.Location = new System.Drawing.Point(13, 152);
            this.textbox_Cevap.Name = "textbox_Cevap";
            this.textbox_Cevap.Size = new System.Drawing.Size(541, 96);
            this.textbox_Cevap.TabIndex = 3;
            this.textbox_Cevap.Text = "Buraya Cevaplayın";
            this.textbox_Cevap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textbox_Cevap_MouseClick);
            // 
            // btn_Ipucu
            // 
            this.btn_Ipucu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btn_Ipucu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Ipucu.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Bold);
            this.btn_Ipucu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(59)))), ((int)(((byte)(66)))));
            this.btn_Ipucu.Location = new System.Drawing.Point(356, 254);
            this.btn_Ipucu.Name = "btn_Ipucu";
            this.btn_Ipucu.Size = new System.Drawing.Size(197, 52);
            this.btn_Ipucu.TabIndex = 5;
            this.btn_Ipucu.Text = "İpuçu Al";
            this.btn_Ipucu.UseVisualStyleBackColor = false;
            this.btn_Ipucu.Click += new System.EventHandler(this.btn_Ipucu_Click);
            // 
            // textbox_Soru
            // 
            this.textbox_Soru.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.textbox_Soru.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_Soru.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textbox_Soru.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(59)))), ((int)(((byte)(66)))));
            this.textbox_Soru.Location = new System.Drawing.Point(12, 33);
            this.textbox_Soru.Name = "textbox_Soru";
            this.textbox_Soru.ReadOnly = true;
            this.textbox_Soru.Size = new System.Drawing.Size(542, 113);
            this.textbox_Soru.TabIndex = 6;
            this.textbox_Soru.Text = "Merkezi Hekim Randevu Sistemi\'nin urlsi nedir?";
            // 
            // Form_Phishing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(566, 321);
            this.Controls.Add(this.textbox_Soru);
            this.Controls.Add(this.btn_Ipucu);
            this.Controls.Add(this.textbox_Cevap);
            this.Controls.Add(this.btn_Cikis);
            this.Controls.Add(this.btn_Cevapla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Phishing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Phishing";
            this.Load += new System.EventHandler(this.Form_Phishing_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Cevapla;
        private System.Windows.Forms.Button btn_Cikis;
        private System.Windows.Forms.RichTextBox textbox_Cevap;
        private System.Windows.Forms.Button btn_Ipucu;
        private System.Windows.Forms.RichTextBox textbox_Soru;
    }
}