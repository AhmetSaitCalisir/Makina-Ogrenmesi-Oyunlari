namespace Yazılım_Proje_Yönetimi
{
    partial class Form_Titanic
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
            this.button_Test = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Isim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_Milliyet = new System.Windows.Forms.ComboBox();
            this.textBox_Yas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_Meslek = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Boy = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Kilo = new System.Windows.Forms.TextBox();
            this.button_Cikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Test
            // 
            this.button_Test.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(25)))), ((int)(((byte)(11)))));
            this.button_Test.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Test.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Test.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(75)))), ((int)(((byte)(33)))));
            this.button_Test.Location = new System.Drawing.Point(18, 338);
            this.button_Test.Name = "button_Test";
            this.button_Test.Size = new System.Drawing.Size(309, 60);
            this.button_Test.TabIndex = 0;
            this.button_Test.Text = "Test Et";
            this.button_Test.UseVisualStyleBackColor = false;
            this.button_Test.Click += new System.EventHandler(this.button_Test_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(25)))), ((int)(((byte)(11)))));
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Karakterinizi Yaratın";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(25)))), ((int)(((byte)(11)))));
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "İsim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(25)))), ((int)(((byte)(11)))));
            this.label3.Location = new System.Drawing.Point(12, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Yaş";
            // 
            // textBox_Isim
            // 
            this.textBox_Isim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(25)))), ((int)(((byte)(11)))));
            this.textBox_Isim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Isim.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold);
            this.textBox_Isim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(75)))), ((int)(((byte)(33)))));
            this.textBox_Isim.Location = new System.Drawing.Point(190, 108);
            this.textBox_Isim.Name = "textBox_Isim";
            this.textBox_Isim.Size = new System.Drawing.Size(137, 28);
            this.textBox_Isim.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(25)))), ((int)(((byte)(11)))));
            this.label4.Location = new System.Drawing.Point(12, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Milliyet";
            // 
            // comboBox_Milliyet
            // 
            this.comboBox_Milliyet.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox_Milliyet.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_Milliyet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(25)))), ((int)(((byte)(11)))));
            this.comboBox_Milliyet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Milliyet.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold);
            this.comboBox_Milliyet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(75)))), ((int)(((byte)(33)))));
            this.comboBox_Milliyet.FormattingEnabled = true;
            this.comboBox_Milliyet.Items.AddRange(new object[] {
            "ABD",
            "Almanya",
            "Arjantin",
            "Avustralya",
            "Brezilya",
            "Britanya",
            "Çin",
            "Endonezya",
            "Fransa",
            "Güney Afrika",
            "Güney Kore",
            "Hindistan",
            "İtalya",
            "Japonya",
            "Kanada",
            "Meksika",
            "Rusya",
            "Suudi Arabistan",
            "Türkiye",
            "Yunanistan"});
            this.comboBox_Milliyet.Location = new System.Drawing.Point(190, 176);
            this.comboBox_Milliyet.Name = "comboBox_Milliyet";
            this.comboBox_Milliyet.Size = new System.Drawing.Size(137, 37);
            this.comboBox_Milliyet.TabIndex = 6;
            // 
            // textBox_Yas
            // 
            this.textBox_Yas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(25)))), ((int)(((byte)(11)))));
            this.textBox_Yas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Yas.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold);
            this.textBox_Yas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(75)))), ((int)(((byte)(33)))));
            this.textBox_Yas.Location = new System.Drawing.Point(190, 142);
            this.textBox_Yas.MaxLength = 3;
            this.textBox_Yas.Name = "textBox_Yas";
            this.textBox_Yas.Size = new System.Drawing.Size(137, 28);
            this.textBox_Yas.TabIndex = 7;
            this.textBox_Yas.TextChanged += new System.EventHandler(this.textBox_Yas_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(25)))), ((int)(((byte)(11)))));
            this.label5.Location = new System.Drawing.Point(12, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Meslek";
            // 
            // comboBox_Meslek
            // 
            this.comboBox_Meslek.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox_Meslek.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_Meslek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(25)))), ((int)(((byte)(11)))));
            this.comboBox_Meslek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Meslek.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold);
            this.comboBox_Meslek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(75)))), ((int)(((byte)(33)))));
            this.comboBox_Meslek.FormattingEnabled = true;
            this.comboBox_Meslek.Items.AddRange(new object[] {
            "Doktor",
            "Üniversite profesörü",
            "Hakim",
            "Öğretmen",
            "Diş hekimi",
            "General",
            "Vali",
            "Yüzbaşı",
            "Büyükelçi",
            "Mimar",
            "Eczacı",
            "Psikolog",
            "Makine mühendisi",
            "Genel müdür",
            "Elektrik mühendisi",
            "Avukat",
            "Araştırma görevlisi",
            "Belediye başkanı",
            "İnşaat mühendisi",
            "Astsubay"});
            this.comboBox_Meslek.Location = new System.Drawing.Point(190, 219);
            this.comboBox_Meslek.Name = "comboBox_Meslek";
            this.comboBox_Meslek.Size = new System.Drawing.Size(137, 37);
            this.comboBox_Meslek.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(25)))), ((int)(((byte)(11)))));
            this.label6.Location = new System.Drawing.Point(12, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "Boy (cm)";
            // 
            // textBox_Boy
            // 
            this.textBox_Boy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(25)))), ((int)(((byte)(11)))));
            this.textBox_Boy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Boy.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold);
            this.textBox_Boy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(75)))), ((int)(((byte)(33)))));
            this.textBox_Boy.Location = new System.Drawing.Point(190, 262);
            this.textBox_Boy.MaxLength = 3;
            this.textBox_Boy.Name = "textBox_Boy";
            this.textBox_Boy.Size = new System.Drawing.Size(137, 28);
            this.textBox_Boy.TabIndex = 11;
            this.textBox_Boy.TextChanged += new System.EventHandler(this.textBox_Boy_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(25)))), ((int)(((byte)(11)))));
            this.label7.Location = new System.Drawing.Point(12, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 29);
            this.label7.TabIndex = 12;
            this.label7.Text = "Kilo (kg)";
            // 
            // textBox_Kilo
            // 
            this.textBox_Kilo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(25)))), ((int)(((byte)(11)))));
            this.textBox_Kilo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Kilo.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold);
            this.textBox_Kilo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(75)))), ((int)(((byte)(33)))));
            this.textBox_Kilo.Location = new System.Drawing.Point(190, 296);
            this.textBox_Kilo.MaxLength = 3;
            this.textBox_Kilo.Name = "textBox_Kilo";
            this.textBox_Kilo.Size = new System.Drawing.Size(137, 28);
            this.textBox_Kilo.TabIndex = 13;
            this.textBox_Kilo.TextChanged += new System.EventHandler(this.textBox_Kilo_TextChanged);
            // 
            // button_Cikis
            // 
            this.button_Cikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(25)))), ((int)(((byte)(11)))));
            this.button_Cikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cikis.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Cikis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(75)))), ((int)(((byte)(33)))));
            this.button_Cikis.Location = new System.Drawing.Point(281, -2);
            this.button_Cikis.Name = "button_Cikis";
            this.button_Cikis.Size = new System.Drawing.Size(63, 28);
            this.button_Cikis.TabIndex = 14;
            this.button_Cikis.Text = "Çıkış";
            this.button_Cikis.UseVisualStyleBackColor = false;
            this.button_Cikis.Click += new System.EventHandler(this.button_Cikis_Click);
            // 
            // Form_Titanic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(343, 417);
            this.Controls.Add(this.button_Cikis);
            this.Controls.Add(this.textBox_Kilo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_Boy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox_Meslek);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_Yas);
            this.Controls.Add(this.comboBox_Milliyet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_Isim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Test);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Titanic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Titanic";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Test;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Isim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_Milliyet;
        private System.Windows.Forms.TextBox textBox_Yas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_Meslek;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Boy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_Kilo;
        private System.Windows.Forms.Button button_Cikis;
    }
}