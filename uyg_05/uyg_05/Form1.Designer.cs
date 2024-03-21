namespace uyg_05
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbBirinci = new System.Windows.Forms.ListBox();
            this.txbEkle = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.txbBul = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.txbIndices = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.lbAktar = new System.Windows.Forms.ListBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button12 = new System.Windows.Forms.Button();
            this.txbSayi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbAsal = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblAnlami = new System.Windows.Forms.Label();
            this.lblUcuncu = new System.Windows.Forms.Label();
            this.lblIkınci = new System.Windows.Forms.Label();
            this.lblBirinci = new System.Windows.Forms.Label();
            this.btnBul = new System.Windows.Forms.Button();
            this.txbKelime = new System.Windows.Forms.TextBox();
            this.lbKelimeler = new System.Windows.Forms.ListBox();
            this.rbTreng = new System.Windows.Forms.RadioButton();
            this.rbEngtr = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbBirinci
            // 
            this.lbBirinci.FormattingEnabled = true;
            this.lbBirinci.Items.AddRange(new object[] {
            "Ahırlı",
            "Akören",
            "Akşehir",
            "Altınekin",
            "Beyşehir",
            "Bozkır",
            "Cihanbeyli",
            "Çeltik",
            "Çumra",
            "Derbent",
            "Derebucak",
            "Doğanhisar",
            "Emirgazi",
            "Ereğli",
            "Güneysınır",
            "Ahırlı"});
            this.lbBirinci.Location = new System.Drawing.Point(6, 47);
            this.lbBirinci.Name = "lbBirinci";
            this.lbBirinci.Size = new System.Drawing.Size(126, 238);
            this.lbBirinci.TabIndex = 0;
            // 
            // txbEkle
            // 
            this.txbEkle.Location = new System.Drawing.Point(6, 21);
            this.txbEkle.Name = "txbEkle";
            this.txbEkle.Size = new System.Drawing.Size(126, 20);
            this.txbEkle.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button11);
            this.groupBox1.Controls.Add(this.button10);
            this.groupBox1.Controls.Add(this.txbBul);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.txbIndices);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.lbAktar);
            this.groupBox1.Controls.Add(this.lbBirinci);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txbEkle);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 382);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Temel İşlemler";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(73, 353);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(113, 23);
            this.button11.TabIndex = 7;
            this.button11.Text = "Sonrakini Bul";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(6, 353);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(61, 23);
            this.button10.TabIndex = 7;
            this.button10.Text = "Bul";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // txbBul
            // 
            this.txbBul.Location = new System.Drawing.Point(6, 320);
            this.txbBul.Name = "txbBul";
            this.txbBul.Size = new System.Drawing.Size(180, 20);
            this.txbBul.TabIndex = 6;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(6, 291);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(368, 23);
            this.button9.TabIndex = 5;
            this.button9.Text = "Sıralı";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(138, 192);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(94, 25);
            this.button8.TabIndex = 4;
            this.button8.Text = "Add Indices";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(138, 223);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(94, 25);
            this.button7.TabIndex = 4;
            this.button7.Text = "Remove Indices";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // txbIndices
            // 
            this.txbIndices.Location = new System.Drawing.Point(138, 166);
            this.txbIndices.Name = "txbIndices";
            this.txbIndices.Size = new System.Drawing.Size(94, 20);
            this.txbIndices.TabIndex = 4;
            this.txbIndices.Text = "2";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(138, 262);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(94, 23);
            this.button6.TabIndex = 4;
            this.button6.Text = "Seçilenleri Aktar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // lbAktar
            // 
            this.lbAktar.FormattingEnabled = true;
            this.lbAktar.Location = new System.Drawing.Point(254, 21);
            this.lbAktar.Name = "lbAktar";
            this.lbAktar.Size = new System.Drawing.Size(120, 264);
            this.lbAktar.TabIndex = 3;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(138, 137);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 23);
            this.button5.TabIndex = 2;
            this.button5.Text = "MultiExtended";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(138, 108);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "MultiSimple";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(138, 79);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "None";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(138, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "One";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button12);
            this.groupBox2.Controls.Add(this.txbSayi);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lbAsal);
            this.groupBox2.Location = new System.Drawing.Point(405, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(184, 383);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Asal Çarpan Bulma";
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(109, 37);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(69, 23);
            this.button12.TabIndex = 3;
            this.button12.Text = "Asal Çarp.";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // txbSayi
            // 
            this.txbSayi.Location = new System.Drawing.Point(6, 39);
            this.txbSayi.Name = "txbSayi";
            this.txbSayi.Size = new System.Drawing.Size(100, 20);
            this.txbSayi.TabIndex = 2;
            this.txbSayi.Text = "45";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sayı :";
            // 
            // lbAsal
            // 
            this.lbAsal.FormattingEnabled = true;
            this.lbAsal.Location = new System.Drawing.Point(6, 65);
            this.lbAsal.Name = "lbAsal";
            this.lbAsal.Size = new System.Drawing.Size(172, 303);
            this.lbAsal.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.btnBul);
            this.groupBox3.Controls.Add(this.txbKelime);
            this.groupBox3.Controls.Add(this.lbKelimeler);
            this.groupBox3.Controls.Add(this.rbTreng);
            this.groupBox3.Controls.Add(this.rbEngtr);
            this.groupBox3.Location = new System.Drawing.Point(595, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(201, 382);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sözlük";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblAnlami);
            this.groupBox4.Controls.Add(this.lblUcuncu);
            this.groupBox4.Controls.Add(this.lblIkınci);
            this.groupBox4.Controls.Add(this.lblBirinci);
            this.groupBox4.Location = new System.Drawing.Point(6, 284);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(192, 92);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bilgiler";
            // 
            // lblAnlami
            // 
            this.lblAnlami.AutoSize = true;
            this.lblAnlami.Location = new System.Drawing.Point(12, 67);
            this.lblAnlami.Name = "lblAnlami";
            this.lblAnlami.Size = new System.Drawing.Size(44, 13);
            this.lblAnlami.TabIndex = 0;
            this.lblAnlami.Text = "Anlamı :";
            // 
            // lblUcuncu
            // 
            this.lblUcuncu.AutoSize = true;
            this.lblUcuncu.Location = new System.Drawing.Point(12, 54);
            this.lblUcuncu.Name = "lblUcuncu";
            this.lblUcuncu.Size = new System.Drawing.Size(72, 13);
            this.lblUcuncu.TabIndex = 0;
            this.lblUcuncu.Text = "Üçüncü Hali :";
            // 
            // lblIkınci
            // 
            this.lblIkınci.AutoSize = true;
            this.lblIkınci.Location = new System.Drawing.Point(12, 39);
            this.lblIkınci.Name = "lblIkınci";
            this.lblIkınci.Size = new System.Drawing.Size(59, 13);
            this.lblIkınci.TabIndex = 0;
            this.lblIkınci.Text = "İkinci Hali :";
            // 
            // lblBirinci
            // 
            this.lblBirinci.AutoSize = true;
            this.lblBirinci.Location = new System.Drawing.Point(12, 22);
            this.lblBirinci.Name = "lblBirinci";
            this.lblBirinci.Size = new System.Drawing.Size(62, 13);
            this.lblBirinci.TabIndex = 0;
            this.lblBirinci.Text = "Birinci Hali :";
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(110, 63);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(66, 23);
            this.btnBul.TabIndex = 3;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // txbKelime
            // 
            this.txbKelime.Location = new System.Drawing.Point(6, 66);
            this.txbKelime.Name = "txbKelime";
            this.txbKelime.Size = new System.Drawing.Size(100, 20);
            this.txbKelime.TabIndex = 2;
            // 
            // lbKelimeler
            // 
            this.lbKelimeler.FormattingEnabled = true;
            this.lbKelimeler.Location = new System.Drawing.Point(6, 92);
            this.lbKelimeler.Name = "lbKelimeler";
            this.lbKelimeler.ScrollAlwaysVisible = true;
            this.lbKelimeler.Size = new System.Drawing.Size(173, 186);
            this.lbKelimeler.TabIndex = 1;
            // 
            // rbTreng
            // 
            this.rbTreng.AutoSize = true;
            this.rbTreng.Checked = true;
            this.rbTreng.Location = new System.Drawing.Point(19, 32);
            this.rbTreng.Name = "rbTreng";
            this.rbTreng.Size = new System.Drawing.Size(66, 17);
            this.rbTreng.TabIndex = 0;
            this.rbTreng.TabStop = true;
            this.rbTreng.Text = "TR-ENG";
            this.rbTreng.UseVisualStyleBackColor = true;
            this.rbTreng.CheckedChanged += new System.EventHandler(this.rbTreng_CheckedChanged);
            // 
            // rbEngtr
            // 
            this.rbEngtr.AutoSize = true;
            this.rbEngtr.Location = new System.Drawing.Point(110, 32);
            this.rbEngtr.Name = "rbEngtr";
            this.rbEngtr.Size = new System.Drawing.Size(66, 17);
            this.rbEngtr.TabIndex = 0;
            this.rbEngtr.Text = "ENG-TR";
            this.rbEngtr.UseVisualStyleBackColor = true;
            this.rbEngtr.CheckedChanged += new System.EventHandler(this.rbEngtr_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 399);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Uygulama 05";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbBirinci;
        private System.Windows.Forms.TextBox txbEkle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox lbAktar;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox txbIndices;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox txbBul;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.TextBox txbSayi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbAsal;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbTreng;
        private System.Windows.Forms.RadioButton rbEngtr;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblAnlami;
        private System.Windows.Forms.Label lblUcuncu;
        private System.Windows.Forms.Label lblIkınci;
        private System.Windows.Forms.Label lblBirinci;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.TextBox txbKelime;
        private System.Windows.Forms.ListBox lbKelimeler;
    }
}

