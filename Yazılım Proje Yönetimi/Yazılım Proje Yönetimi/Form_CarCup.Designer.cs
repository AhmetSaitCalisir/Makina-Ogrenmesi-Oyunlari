namespace Yazılım_Proje_Yönetimi
{
    partial class Form_CarCup
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
            this.lbl_Cumle = new System.Windows.Forms.Label();
            this.lbl_NesneAdi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Radio = new System.Windows.Forms.Button();
            this.btn_Soup = new System.Windows.Forms.Button();
            this.btn_Chair = new System.Windows.Forms.Button();
            this.btn_Book = new System.Windows.Forms.Button();
            this.btn_Tree = new System.Windows.Forms.Button();
            this.btn_Computer = new System.Windows.Forms.Button();
            this.btn_House = new System.Windows.Forms.Button();
            this.btn_Cat = new System.Windows.Forms.Button();
            this.btn_RedCar = new System.Windows.Forms.Button();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Cumle
            // 
            this.lbl_Cumle.AutoSize = true;
            this.lbl_Cumle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(193)))), ((int)(((byte)(253)))));
            this.lbl_Cumle.Location = new System.Drawing.Point(125, 41);
            this.lbl_Cumle.Name = "lbl_Cumle";
            this.lbl_Cumle.Size = new System.Drawing.Size(117, 17);
            this.lbl_Cumle.TabIndex = 9;
            this.lbl_Cumle.Text = "Bulacağın nesne:";
            // 
            // lbl_NesneAdi
            // 
            this.lbl_NesneAdi.AutoSize = true;
            this.lbl_NesneAdi.Location = new System.Drawing.Point(250, 41);
            this.lbl_NesneAdi.Name = "lbl_NesneAdi";
            this.lbl_NesneAdi.Size = new System.Drawing.Size(70, 17);
            this.lbl_NesneAdi.TabIndex = 10;
            this.lbl_NesneAdi.Text = "nesne adı";
            this.lbl_NesneAdi.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 11;
            // 
            // btn_Radio
            // 
            this.btn_Radio.BackgroundImage = global::Yazılım_Proje_Yönetimi.Properties.Resources.radio;
            this.btn_Radio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Radio.Location = new System.Drawing.Point(341, 324);
            this.btn_Radio.Name = "btn_Radio";
            this.btn_Radio.Size = new System.Drawing.Size(117, 102);
            this.btn_Radio.TabIndex = 8;
            this.btn_Radio.Tag = "Radyo";
            this.btn_Radio.UseVisualStyleBackColor = true;
            this.btn_Radio.Click += new System.EventHandler(this.btn_Radio_Click);
            // 
            // btn_Soup
            // 
            this.btn_Soup.BackgroundImage = global::Yazılım_Proje_Yönetimi.Properties.Resources.soup;
            this.btn_Soup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Soup.Location = new System.Drawing.Point(207, 324);
            this.btn_Soup.Name = "btn_Soup";
            this.btn_Soup.Size = new System.Drawing.Size(113, 102);
            this.btn_Soup.TabIndex = 7;
            this.btn_Soup.Tag = "Çorba";
            this.btn_Soup.UseVisualStyleBackColor = true;
            this.btn_Soup.Click += new System.EventHandler(this.btn_Soup_Click);
            // 
            // btn_Chair
            // 
            this.btn_Chair.BackgroundImage = global::Yazılım_Proje_Yönetimi.Properties.Resources.chair;
            this.btn_Chair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Chair.Location = new System.Drawing.Point(66, 324);
            this.btn_Chair.Name = "btn_Chair";
            this.btn_Chair.Size = new System.Drawing.Size(117, 102);
            this.btn_Chair.TabIndex = 6;
            this.btn_Chair.Tag = "Sandalye";
            this.btn_Chair.UseVisualStyleBackColor = true;
            this.btn_Chair.Click += new System.EventHandler(this.btn_Chair_Click);
            // 
            // btn_Book
            // 
            this.btn_Book.BackgroundImage = global::Yazılım_Proje_Yönetimi.Properties.Resources.book;
            this.btn_Book.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Book.Location = new System.Drawing.Point(341, 207);
            this.btn_Book.Name = "btn_Book";
            this.btn_Book.Size = new System.Drawing.Size(117, 97);
            this.btn_Book.TabIndex = 5;
            this.btn_Book.Tag = "Kitap";
            this.btn_Book.UseVisualStyleBackColor = true;
            this.btn_Book.Click += new System.EventHandler(this.btn_Book_Click);
            // 
            // btn_Tree
            // 
            this.btn_Tree.BackgroundImage = global::Yazılım_Proje_Yönetimi.Properties.Resources.tree;
            this.btn_Tree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Tree.Location = new System.Drawing.Point(203, 207);
            this.btn_Tree.Name = "btn_Tree";
            this.btn_Tree.Size = new System.Drawing.Size(117, 97);
            this.btn_Tree.TabIndex = 4;
            this.btn_Tree.Tag = "Ağaç";
            this.btn_Tree.UseVisualStyleBackColor = true;
            this.btn_Tree.Click += new System.EventHandler(this.btn_Tree_Click);
            // 
            // btn_Computer
            // 
            this.btn_Computer.BackgroundImage = global::Yazılım_Proje_Yönetimi.Properties.Resources.computer;
            this.btn_Computer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Computer.Location = new System.Drawing.Point(66, 207);
            this.btn_Computer.Name = "btn_Computer";
            this.btn_Computer.Size = new System.Drawing.Size(117, 97);
            this.btn_Computer.TabIndex = 3;
            this.btn_Computer.Tag = "Bilgisayar";
            this.btn_Computer.UseVisualStyleBackColor = true;
            this.btn_Computer.Click += new System.EventHandler(this.btn_Computer_Click);
            // 
            // btn_House
            // 
            this.btn_House.BackgroundImage = global::Yazılım_Proje_Yönetimi.Properties.Resources.house;
            this.btn_House.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_House.Location = new System.Drawing.Point(341, 92);
            this.btn_House.Name = "btn_House";
            this.btn_House.Size = new System.Drawing.Size(117, 96);
            this.btn_House.TabIndex = 2;
            this.btn_House.Tag = "Ev";
            this.btn_House.UseVisualStyleBackColor = true;
            this.btn_House.Click += new System.EventHandler(this.btn_House_Click);
            // 
            // btn_Cat
            // 
            this.btn_Cat.BackgroundImage = global::Yazılım_Proje_Yönetimi.Properties.Resources.Cat;
            this.btn_Cat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Cat.Location = new System.Drawing.Point(203, 92);
            this.btn_Cat.Name = "btn_Cat";
            this.btn_Cat.Size = new System.Drawing.Size(117, 96);
            this.btn_Cat.TabIndex = 1;
            this.btn_Cat.Tag = "Kedi";
            this.btn_Cat.UseVisualStyleBackColor = true;
            this.btn_Cat.Click += new System.EventHandler(this.btn_Cat_Click);
            // 
            // btn_RedCar
            // 
            this.btn_RedCar.BackgroundImage = global::Yazılım_Proje_Yönetimi.Properties.Resources.RedCar;
            this.btn_RedCar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_RedCar.Location = new System.Drawing.Point(66, 92);
            this.btn_RedCar.Name = "btn_RedCar";
            this.btn_RedCar.Size = new System.Drawing.Size(117, 96);
            this.btn_RedCar.TabIndex = 0;
            this.btn_RedCar.Tag = "Kırmızı Araba";
            this.btn_RedCar.UseVisualStyleBackColor = true;
            this.btn_RedCar.Click += new System.EventHandler(this.btn_RedCar_Click);
            // 
            // btn_cikis
            // 
            this.btn_cikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(141)))), ((int)(((byte)(201)))));
            this.btn_cikis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(35)))), ((int)(((byte)(150)))));
            this.btn_cikis.Location = new System.Drawing.Point(435, 0);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(75, 40);
            this.btn_cikis.TabIndex = 12;
            this.btn_cikis.Text = "Çıkış";
            this.btn_cikis.UseVisualStyleBackColor = false;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // Form_CarCup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(35)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(509, 486);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_NesneAdi);
            this.Controls.Add(this.lbl_Cumle);
            this.Controls.Add(this.btn_Radio);
            this.Controls.Add(this.btn_Soup);
            this.Controls.Add(this.btn_Chair);
            this.Controls.Add(this.btn_Book);
            this.Controls.Add(this.btn_Tree);
            this.Controls.Add(this.btn_Computer);
            this.Controls.Add(this.btn_House);
            this.Controls.Add(this.btn_Cat);
            this.Controls.Add(this.btn_RedCar);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(193)))), ((int)(((byte)(253)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_CarCup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_CarCup";
            this.Load += new System.EventHandler(this.Form_CarCup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_RedCar;
        private System.Windows.Forms.Button btn_Cat;
        private System.Windows.Forms.Button btn_House;
        private System.Windows.Forms.Button btn_Book;
        private System.Windows.Forms.Button btn_Tree;
        private System.Windows.Forms.Button btn_Computer;
        private System.Windows.Forms.Button btn_Radio;
        private System.Windows.Forms.Button btn_Soup;
        private System.Windows.Forms.Button btn_Chair;
        private System.Windows.Forms.Label lbl_Cumle;
        private System.Windows.Forms.Label lbl_NesneAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_cikis;
    }
}