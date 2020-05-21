namespace Yazılım_Proje_Yönetimi
{
    partial class Form_Tourist
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Isim = new System.Windows.Forms.TextBox();
            this.button_Planla = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Mevsim = new System.Windows.Forms.ComboBox();
            this.comboBox_Lokasyon = new System.Windows.Forms.ComboBox();
            this.comboBox_Dil = new System.Windows.Forms.ComboBox();
            this.comboBox_Tur = new System.Windows.Forms.ComboBox();
            this.button_Cikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(195)))), ((int)(((byte)(219)))));
            this.label1.Font = new System.Drawing.Font("Sylfaen", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(52)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(263, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim";
            // 
            // textBox_Isim
            // 
            this.textBox_Isim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(195)))), ((int)(((byte)(219)))));
            this.textBox_Isim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Isim.Font = new System.Drawing.Font("Sylfaen", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_Isim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(52)))), ((int)(((byte)(66)))));
            this.textBox_Isim.Location = new System.Drawing.Point(148, 96);
            this.textBox_Isim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Isim.Name = "textBox_Isim";
            this.textBox_Isim.Size = new System.Drawing.Size(308, 45);
            this.textBox_Isim.TabIndex = 1;
            // 
            // button_Planla
            // 
            this.button_Planla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(195)))), ((int)(((byte)(219)))));
            this.button_Planla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Planla.Font = new System.Drawing.Font("Sylfaen", 20.25F, System.Drawing.FontStyle.Bold);
            this.button_Planla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(52)))), ((int)(((byte)(66)))));
            this.button_Planla.Location = new System.Drawing.Point(148, 480);
            this.button_Planla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Planla.Name = "button_Planla";
            this.button_Planla.Size = new System.Drawing.Size(308, 61);
            this.button_Planla.TabIndex = 2;
            this.button_Planla.Text = "Seyahat Planla";
            this.button_Planla.UseVisualStyleBackColor = false;
            this.button_Planla.Click += new System.EventHandler(this.button_Planla_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(195)))), ((int)(((byte)(219)))));
            this.label2.Font = new System.Drawing.Font("Sylfaen", 20.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(52)))), ((int)(((byte)(66)))));
            this.label2.Location = new System.Drawing.Point(210, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 44);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kriterlerin";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox_Mevsim
            // 
            this.comboBox_Mevsim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(195)))), ((int)(((byte)(219)))));
            this.comboBox_Mevsim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Mevsim.Font = new System.Drawing.Font("Sylfaen", 20.25F, System.Drawing.FontStyle.Bold);
            this.comboBox_Mevsim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(52)))), ((int)(((byte)(66)))));
            this.comboBox_Mevsim.FormattingEnabled = true;
            this.comboBox_Mevsim.Items.AddRange(new object[] {
            "Yaz",
            "Kış",
            "Bahar"});
            this.comboBox_Mevsim.Location = new System.Drawing.Point(169, 228);
            this.comboBox_Mevsim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_Mevsim.Name = "comboBox_Mevsim";
            this.comboBox_Mevsim.Size = new System.Drawing.Size(257, 52);
            this.comboBox_Mevsim.TabIndex = 4;
            // 
            // comboBox_Lokasyon
            // 
            this.comboBox_Lokasyon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(195)))), ((int)(((byte)(219)))));
            this.comboBox_Lokasyon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Lokasyon.Font = new System.Drawing.Font("Sylfaen", 20.25F, System.Drawing.FontStyle.Bold);
            this.comboBox_Lokasyon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(52)))), ((int)(((byte)(66)))));
            this.comboBox_Lokasyon.FormattingEnabled = true;
            this.comboBox_Lokasyon.Items.AddRange(new object[] {
            "Deniz kenarı",
            "Dağ",
            "Şehir",
            "Orman"});
            this.comboBox_Lokasyon.Location = new System.Drawing.Point(169, 288);
            this.comboBox_Lokasyon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_Lokasyon.Name = "comboBox_Lokasyon";
            this.comboBox_Lokasyon.Size = new System.Drawing.Size(257, 52);
            this.comboBox_Lokasyon.TabIndex = 5;
            // 
            // comboBox_Dil
            // 
            this.comboBox_Dil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(195)))), ((int)(((byte)(219)))));
            this.comboBox_Dil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Dil.Font = new System.Drawing.Font("Sylfaen", 20.25F, System.Drawing.FontStyle.Bold);
            this.comboBox_Dil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(52)))), ((int)(((byte)(66)))));
            this.comboBox_Dil.FormattingEnabled = true;
            this.comboBox_Dil.Items.AddRange(new object[] {
            "Türkçe",
            "İngilizce",
            "Almanca",
            "Fransızca",
            "Farketmez"});
            this.comboBox_Dil.Location = new System.Drawing.Point(169, 349);
            this.comboBox_Dil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_Dil.Name = "comboBox_Dil";
            this.comboBox_Dil.Size = new System.Drawing.Size(257, 52);
            this.comboBox_Dil.TabIndex = 6;
            // 
            // comboBox_Tur
            // 
            this.comboBox_Tur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(195)))), ((int)(((byte)(219)))));
            this.comboBox_Tur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Tur.Font = new System.Drawing.Font("Sylfaen", 20.25F, System.Drawing.FontStyle.Bold);
            this.comboBox_Tur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(52)))), ((int)(((byte)(66)))));
            this.comboBox_Tur.FormattingEnabled = true;
            this.comboBox_Tur.Items.AddRange(new object[] {
            "Romantik",
            "Eğlence",
            "Sessizlik",
            "Yeni yerler"});
            this.comboBox_Tur.Location = new System.Drawing.Point(169, 409);
            this.comboBox_Tur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_Tur.Name = "comboBox_Tur";
            this.comboBox_Tur.Size = new System.Drawing.Size(257, 52);
            this.comboBox_Tur.TabIndex = 7;
            // 
            // button_Cikis
            // 
            this.button_Cikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(195)))), ((int)(((byte)(219)))));
            this.button_Cikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cikis.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Cikis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(52)))), ((int)(((byte)(66)))));
            this.button_Cikis.Location = new System.Drawing.Point(488, 0);
            this.button_Cikis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Cikis.Name = "button_Cikis";
            this.button_Cikis.Size = new System.Drawing.Size(113, 43);
            this.button_Cikis.TabIndex = 8;
            this.button_Cikis.Text = "Çıkış";
            this.button_Cikis.UseVisualStyleBackColor = false;
            this.button_Cikis.Click += new System.EventHandler(this.button_Cikis_Click);
            // 
            // Form_Tourist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(52)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(601, 560);
            this.Controls.Add(this.button_Cikis);
            this.Controls.Add(this.comboBox_Tur);
            this.Controls.Add(this.comboBox_Dil);
            this.Controls.Add(this.comboBox_Lokasyon);
            this.Controls.Add(this.comboBox_Mevsim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Planla);
            this.Controls.Add(this.textBox_Isim);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_Tourist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Tourist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Isim;
        private System.Windows.Forms.Button button_Planla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Mevsim;
        private System.Windows.Forms.ComboBox comboBox_Lokasyon;
        private System.Windows.Forms.ComboBox comboBox_Dil;
        private System.Windows.Forms.ComboBox comboBox_Tur;
        private System.Windows.Forms.Button button_Cikis;
    }
}