namespace uyg_09_VeriTabanı_02
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txGridSayisi = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdCarpma = new System.Windows.Forms.RadioButton();
            this.rdCikarma = new System.Windows.Forms.RadioButton();
            this.rdToplama = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dg3 = new System.Windows.Forms.DataGridView();
            this.dg2 = new System.Windows.Forms.DataGridView();
            this.dg1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            this.txtUrunMiktar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUrunFiyat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUrunNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbSoyad = new System.Windows.Forms.ListBox();
            this.lbAd = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txGridSayisi);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.dg3);
            this.tabPage1.Controls.Add(this.dg2);
            this.tabPage1.Controls.Add(this.dg1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "DataGridView Uyg.";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Satır/Sütun Sayısı :";
            // 
            // txGridSayisi
            // 
            this.txGridSayisi.Location = new System.Drawing.Point(8, 41);
            this.txGridSayisi.Name = "txGridSayisi";
            this.txGridSayisi.Size = new System.Drawing.Size(110, 20);
            this.txGridSayisi.TabIndex = 5;
            this.txGridSayisi.Text = "3";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdCarpma);
            this.groupBox1.Controls.Add(this.rdCikarma);
            this.groupBox1.Controls.Add(this.rdToplama);
            this.groupBox1.Location = new System.Drawing.Point(348, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 113);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İslem";
            // 
            // rdCarpma
            // 
            this.rdCarpma.AutoSize = true;
            this.rdCarpma.Location = new System.Drawing.Point(6, 75);
            this.rdCarpma.Name = "rdCarpma";
            this.rdCarpma.Size = new System.Drawing.Size(61, 17);
            this.rdCarpma.TabIndex = 2;
            this.rdCarpma.Text = "Çarpma";
            this.rdCarpma.UseVisualStyleBackColor = true;
            // 
            // rdCikarma
            // 
            this.rdCikarma.AutoSize = true;
            this.rdCikarma.Location = new System.Drawing.Point(6, 52);
            this.rdCikarma.Name = "rdCikarma";
            this.rdCikarma.Size = new System.Drawing.Size(63, 17);
            this.rdCikarma.TabIndex = 1;
            this.rdCikarma.Text = "Çıkarma";
            this.rdCikarma.UseVisualStyleBackColor = true;
            // 
            // rdToplama
            // 
            this.rdToplama.AutoSize = true;
            this.rdToplama.Checked = true;
            this.rdToplama.Location = new System.Drawing.Point(6, 29);
            this.rdToplama.Name = "rdToplama";
            this.rdToplama.Size = new System.Drawing.Size(66, 17);
            this.rdToplama.TabIndex = 0;
            this.rdToplama.TabStop = true;
            this.rdToplama.Text = "Toplama";
            this.rdToplama.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(373, 330);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "DataSet";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(348, 144);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "İşlem Yap";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Grid Doldur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dg3
            // 
            this.dg3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg3.Location = new System.Drawing.Point(257, 174);
            this.dg3.Name = "dg3";
            this.dg3.Size = new System.Drawing.Size(304, 150);
            this.dg3.TabIndex = 2;
            // 
            // dg2
            // 
            this.dg2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg2.Location = new System.Drawing.Point(494, 25);
            this.dg2.Name = "dg2";
            this.dg2.Size = new System.Drawing.Size(222, 143);
            this.dg2.TabIndex = 1;
            // 
            // dg1
            // 
            this.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg1.Location = new System.Drawing.Point(135, 25);
            this.dg1.Name = "dg1";
            this.dg1.Size = new System.Drawing.Size(207, 143);
            this.dg1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.txtUrunMiktar);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtUrunFiyat);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtUrunAdi);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtUrunNo);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.lbSoyad);
            this.tabPage2.Controls.Add(this.lbAd);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "VeriTabanı";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(236, 244);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(548, 174);
            this.dataGridView2.TabIndex = 14;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(518, 207);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(174, 31);
            this.button6.TabIndex = 13;
            this.button6.Text = "Ekle";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // txtUrunMiktar
            // 
            this.txtUrunMiktar.Location = new System.Drawing.Point(592, 181);
            this.txtUrunMiktar.Name = "txtUrunMiktar";
            this.txtUrunMiktar.Size = new System.Drawing.Size(100, 20);
            this.txtUrunMiktar.TabIndex = 9;
            this.txtUrunMiktar.Text = "12";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(515, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Miktar :";
            // 
            // txtUrunFiyat
            // 
            this.txtUrunFiyat.Location = new System.Drawing.Point(592, 155);
            this.txtUrunFiyat.Name = "txtUrunFiyat";
            this.txtUrunFiyat.Size = new System.Drawing.Size(100, 20);
            this.txtUrunFiyat.TabIndex = 10;
            this.txtUrunFiyat.Text = "12";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(515, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fiyat :";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(592, 129);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(100, 20);
            this.txtUrunAdi.TabIndex = 11;
            this.txtUrunAdi.Text = "aaa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(515, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ürün Adı :";
            // 
            // txtUrunNo
            // 
            this.txtUrunNo.Location = new System.Drawing.Point(592, 103);
            this.txtUrunNo.Name = "txtUrunNo";
            this.txtUrunNo.Size = new System.Drawing.Size(100, 20);
            this.txtUrunNo.TabIndex = 12;
            this.txtUrunNo.Text = "14";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(515, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ürün No :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(559, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "10";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(501, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(191, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // lbSoyad
            // 
            this.lbSoyad.FormattingEnabled = true;
            this.lbSoyad.Location = new System.Drawing.Point(115, 26);
            this.lbSoyad.Name = "lbSoyad";
            this.lbSoyad.Size = new System.Drawing.Size(115, 212);
            this.lbSoyad.TabIndex = 2;
            // 
            // lbAd
            // 
            this.lbAd.FormattingEnabled = true;
            this.lbAd.Location = new System.Drawing.Point(8, 26);
            this.lbAd.Name = "lbAd";
            this.lbAd.Size = new System.Drawing.Size(101, 212);
            this.lbAd.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(236, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 212);
            this.dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdCarpma;
        private System.Windows.Forms.RadioButton rdCikarma;
        private System.Windows.Forms.RadioButton rdToplama;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dg3;
        private System.Windows.Forms.DataGridView dg2;
        private System.Windows.Forms.DataGridView dg1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txGridSayisi;
        private System.Windows.Forms.ListBox lbAd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox lbSoyad;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtUrunMiktar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUrunFiyat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUrunNo;
        private System.Windows.Forms.Label label5;
    }
}

