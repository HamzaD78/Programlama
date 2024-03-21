namespace uyg_04
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
            this.cboxDeneme = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelSayisi = new System.Windows.Forms.Label();
            this.labelIndex = new System.Windows.Forms.Label();
            this.labelIcerik = new System.Windows.Forms.Label();
            this.txbGenislik = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbUzunluk = new System.Windows.Forms.TextBox();
            this.btAyarla = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txbAktar = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txbEkle = new System.Windows.Forms.TextBox();
            this.cboxEkle = new System.Windows.Forms.ComboBox();
            this.txbIndex = new System.Windows.Forms.TextBox();
            this.txbVeri = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboxIlceler = new System.Windows.Forms.ComboBox();
            this.cboxIller = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button12 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.cmbIslemSec = new System.Windows.Forms.ComboBox();
            this.txtIkinciSayi = new System.Windows.Forms.TextBox();
            this.txtIlkSayi = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboxDeneme
            // 
            this.cboxDeneme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboxDeneme.FormattingEnabled = true;
            this.cboxDeneme.Items.AddRange(new object[] {
            "Deneme 1",
            "Deneme 2",
            "Deneme 3",
            "Deneme 4",
            "Deneme 5",
            "Deneme 6",
            "Deneme 7"});
            this.cboxDeneme.Location = new System.Drawing.Point(146, 19);
            this.cboxDeneme.Name = "cboxDeneme";
            this.cboxDeneme.Size = new System.Drawing.Size(121, 124);
            this.cboxDeneme.TabIndex = 0;
            this.cboxDeneme.SelectedIndexChanged += new System.EventHandler(this.cboxDeneme_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Simple";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(21, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "DropDown";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(21, 77);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "DropDownList";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sayısı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "İndex :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Seçilen :";
            // 
            // labelSayisi
            // 
            this.labelSayisi.AutoSize = true;
            this.labelSayisi.Location = new System.Drawing.Point(349, 24);
            this.labelSayisi.Name = "labelSayisi";
            this.labelSayisi.Size = new System.Drawing.Size(10, 13);
            this.labelSayisi.TabIndex = 2;
            this.labelSayisi.Text = "-";
            // 
            // labelIndex
            // 
            this.labelIndex.AutoSize = true;
            this.labelIndex.Location = new System.Drawing.Point(349, 48);
            this.labelIndex.Name = "labelIndex";
            this.labelIndex.Size = new System.Drawing.Size(10, 13);
            this.labelIndex.TabIndex = 2;
            this.labelIndex.Text = "-";
            // 
            // labelIcerik
            // 
            this.labelIcerik.AutoSize = true;
            this.labelIcerik.Location = new System.Drawing.Point(349, 72);
            this.labelIcerik.Name = "labelIcerik";
            this.labelIcerik.Size = new System.Drawing.Size(10, 13);
            this.labelIcerik.TabIndex = 2;
            this.labelIcerik.Text = "-";
            // 
            // txbGenislik
            // 
            this.txbGenislik.Location = new System.Drawing.Point(21, 125);
            this.txbGenislik.Name = "txbGenislik";
            this.txbGenislik.Size = new System.Drawing.Size(100, 20);
            this.txbGenislik.TabIndex = 3;
            this.txbGenislik.Text = "121";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Genişlik :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Uzunluk :";
            // 
            // txbUzunluk
            // 
            this.txbUzunluk.Location = new System.Drawing.Point(21, 168);
            this.txbUzunluk.Name = "txbUzunluk";
            this.txbUzunluk.Size = new System.Drawing.Size(100, 20);
            this.txbUzunluk.TabIndex = 3;
            this.txbUzunluk.Text = "106";
            // 
            // btAyarla
            // 
            this.btAyarla.Location = new System.Drawing.Point(21, 194);
            this.btAyarla.Name = "btAyarla";
            this.btAyarla.Size = new System.Drawing.Size(102, 23);
            this.btAyarla.TabIndex = 1;
            this.btAyarla.Text = "Ayarla";
            this.btAyarla.UseVisualStyleBackColor = true;
            this.btAyarla.Click += new System.EventHandler(this.btAyarla_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btAyarla);
            this.groupBox1.Controls.Add(this.cboxDeneme);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.labelSayisi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.labelIndex);
            this.groupBox1.Controls.Add(this.labelIcerik);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txbGenislik);
            this.groupBox1.Controls.Add(this.txbUzunluk);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 265);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Temel İşlemler";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txbAktar);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button9);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.txbEkle);
            this.groupBox2.Controls.Add(this.cboxEkle);
            this.groupBox2.Controls.Add(this.txbIndex);
            this.groupBox2.Controls.Add(this.txbVeri);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.button11);
            this.groupBox2.Controls.Add(this.button10);
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Location = new System.Drawing.Point(456, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(394, 257);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ekleme ve Çıkarma  İşlemleri";
            // 
            // txbAktar
            // 
            this.txbAktar.Location = new System.Drawing.Point(276, 24);
            this.txbAktar.Multiline = true;
            this.txbAktar.Name = "txbAktar";
            this.txbAktar.Size = new System.Drawing.Size(112, 169);
            this.txbAktar.TabIndex = 22;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(183, 136);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 28);
            this.button7.TabIndex = 17;
            this.button7.Text = "Dizi Ekle";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(183, 82);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 48);
            this.button6.TabIndex = 18;
            this.button6.Text = "Kontrol Ederek Ekle";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(183, 53);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 19;
            this.button5.Text = "Temizle";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(183, 24);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 20;
            this.button9.Text = "Ekle";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button4_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(183, 170);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 21;
            this.button4.Text = "Aktar Dizi ->";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // txbEkle
            // 
            this.txbEkle.Location = new System.Drawing.Point(6, 24);
            this.txbEkle.Name = "txbEkle";
            this.txbEkle.Size = new System.Drawing.Size(160, 20);
            this.txbEkle.TabIndex = 16;
            this.txbEkle.Text = "Text Ekle";
            // 
            // cboxEkle
            // 
            this.cboxEkle.FormattingEnabled = true;
            this.cboxEkle.Location = new System.Drawing.Point(6, 51);
            this.cboxEkle.Name = "cboxEkle";
            this.cboxEkle.Size = new System.Drawing.Size(160, 21);
            this.cboxEkle.TabIndex = 15;
            // 
            // txbIndex
            // 
            this.txbIndex.Location = new System.Drawing.Point(55, 119);
            this.txbIndex.Name = "txbIndex";
            this.txbIndex.Size = new System.Drawing.Size(111, 20);
            this.txbIndex.TabIndex = 13;
            this.txbIndex.Text = "2";
            // 
            // txbVeri
            // 
            this.txbVeri.Location = new System.Drawing.Point(55, 93);
            this.txbVeri.Name = "txbVeri";
            this.txbVeri.Size = new System.Drawing.Size(111, 20);
            this.txbVeri.TabIndex = 14;
            this.txbVeri.Text = "insert";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Konum :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Veri :";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(6, 224);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(160, 23);
            this.button11.TabIndex = 8;
            this.button11.Text = "RemoveAt";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(6, 195);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(160, 23);
            this.button10.TabIndex = 9;
            this.button10.Text = "Remove";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(6, 166);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(160, 23);
            this.button8.TabIndex = 10;
            this.button8.Text = "Insert";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.cboxIlceler);
            this.groupBox3.Controls.Add(this.cboxIller);
            this.groupBox3.Location = new System.Drawing.Point(12, 283);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(438, 131);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Listeleme İşlemleri";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "İlçeler :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "İller :";
            // 
            // cboxIlceler
            // 
            this.cboxIlceler.FormattingEnabled = true;
            this.cboxIlceler.Location = new System.Drawing.Point(73, 56);
            this.cboxIlceler.Name = "cboxIlceler";
            this.cboxIlceler.Size = new System.Drawing.Size(121, 21);
            this.cboxIlceler.TabIndex = 10;
            // 
            // cboxIller
            // 
            this.cboxIller.FormattingEnabled = true;
            this.cboxIller.Location = new System.Drawing.Point(73, 29);
            this.cboxIller.Name = "cboxIller";
            this.cboxIller.Size = new System.Drawing.Size(121, 21);
            this.cboxIller.TabIndex = 11;
            this.cboxIller.SelectedIndexChanged += new System.EventHandler(this.cboxIller_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txtSonuc);
            this.groupBox4.Controls.Add(this.cmbIslemSec);
            this.groupBox4.Controls.Add(this.txtIkinciSayi);
            this.groupBox4.Controls.Add(this.txtIlkSayi);
            this.groupBox4.Location = new System.Drawing.Point(464, 283);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(385, 131);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Aritmetik İşlem Yap";
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(223, 26);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(142, 99);
            this.button12.TabIndex = 8;
            this.button12.Text = "İşlemleri Ekle";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 108);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Sonuç :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "İşlem Seç :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "İkinci Sayı :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "İlk Sayı :";
            // 
            // txtSonuc
            // 
            this.txtSonuc.Location = new System.Drawing.Point(67, 105);
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.Size = new System.Drawing.Size(121, 20);
            this.txtSonuc.TabIndex = 3;
            // 
            // cmbIslemSec
            // 
            this.cmbIslemSec.FormattingEnabled = true;
            this.cmbIslemSec.Location = new System.Drawing.Point(67, 78);
            this.cmbIslemSec.Name = "cmbIslemSec";
            this.cmbIslemSec.Size = new System.Drawing.Size(121, 21);
            this.cmbIslemSec.TabIndex = 2;
            this.cmbIslemSec.SelectedIndexChanged += new System.EventHandler(this.cmbIslemSec_SelectedIndexChanged);
            // 
            // txtIkinciSayi
            // 
            this.txtIkinciSayi.Location = new System.Drawing.Point(67, 52);
            this.txtIkinciSayi.Name = "txtIkinciSayi";
            this.txtIkinciSayi.Size = new System.Drawing.Size(121, 20);
            this.txtIkinciSayi.TabIndex = 1;
            // 
            // txtIlkSayi
            // 
            this.txtIlkSayi.Location = new System.Drawing.Point(67, 26);
            this.txtIlkSayi.Name = "txtIlkSayi";
            this.txtIlkSayi.Size = new System.Drawing.Size(121, 20);
            this.txtIlkSayi.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 421);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
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

        private System.Windows.Forms.ComboBox cboxDeneme;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelSayisi;
        private System.Windows.Forms.Label labelIndex;
        private System.Windows.Forms.Label labelIcerik;
        private System.Windows.Forms.TextBox txbGenislik;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbUzunluk;
        private System.Windows.Forms.Button btAyarla;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txbAktar;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txbEkle;
        private System.Windows.Forms.ComboBox cboxEkle;
        private System.Windows.Forms.TextBox txbIndex;
        private System.Windows.Forms.TextBox txbVeri;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboxIlceler;
        private System.Windows.Forms.ComboBox cboxIller;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.ComboBox cmbIslemSec;
        private System.Windows.Forms.TextBox txtIkinciSayi;
        private System.Windows.Forms.TextBox txtIlkSayi;
        private System.Windows.Forms.Button button12;
    }
}

