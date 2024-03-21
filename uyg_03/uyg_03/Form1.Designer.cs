namespace uyg_03
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnBul = new System.Windows.Forms.Button();
            this.btnYapistir = new System.Windows.Forms.Button();
            this.btnKopyala = new System.Windows.Forms.Button();
            this.btnKes = new System.Windows.Forms.Button();
            this.btnTumunuSec = new System.Windows.Forms.Button();
            this.btnSec = new System.Windows.Forms.Button();
            this.txtBul = new System.Windows.Forms.TextBox();
            this.txtMain = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSayi = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtHedef = new System.Windows.Forms.TextBox();
            this.txtKaynak = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWrap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaxLenght = new System.Windows.Forms.TextBox();
            this.txtLower = new System.Windows.Forms.TextBox();
            this.txtUpper = new System.Windows.Forms.TextBox();
            this.txtReadOnly = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtNormal = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKaynak_1 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtUnluSayisi = new System.Windows.Forms.TextBox();
            this.txtOnlyDigits = new System.Windows.Forms.TextBox();
            this.txtUpper_1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnDegistir);
            this.panel1.Controls.Add(this.btnTemizle);
            this.panel1.Controls.Add(this.btnBul);
            this.panel1.Controls.Add(this.btnYapistir);
            this.panel1.Controls.Add(this.btnKopyala);
            this.panel1.Controls.Add(this.btnKes);
            this.panel1.Controls.Add(this.btnTumunuSec);
            this.panel1.Controls.Add(this.btnSec);
            this.panel1.Controls.Add(this.txtBul);
            this.panel1.Controls.Add(this.txtMain);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 273);
            this.panel1.TabIndex = 0;
            // 
            // btnDegistir
            // 
            this.btnDegistir.Location = new System.Drawing.Point(372, 237);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(100, 23);
            this.btnDegistir.TabIndex = 9;
            this.btnDegistir.Text = "Değiştir";
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(372, 208);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(100, 23);
            this.btnTemizle.TabIndex = 8;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(372, 179);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(100, 23);
            this.btnBul.TabIndex = 7;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // btnYapistir
            // 
            this.btnYapistir.Location = new System.Drawing.Point(372, 124);
            this.btnYapistir.Name = "btnYapistir";
            this.btnYapistir.Size = new System.Drawing.Size(100, 23);
            this.btnYapistir.TabIndex = 5;
            this.btnYapistir.Text = "Yapıştır";
            this.btnYapistir.UseVisualStyleBackColor = true;
            this.btnYapistir.Click += new System.EventHandler(this.btnYapistir_Click);
            // 
            // btnKopyala
            // 
            this.btnKopyala.Location = new System.Drawing.Point(372, 95);
            this.btnKopyala.Name = "btnKopyala";
            this.btnKopyala.Size = new System.Drawing.Size(100, 23);
            this.btnKopyala.TabIndex = 4;
            this.btnKopyala.Text = "Kopyala";
            this.btnKopyala.UseVisualStyleBackColor = true;
            this.btnKopyala.Click += new System.EventHandler(this.btnKopyala_Click);
            // 
            // btnKes
            // 
            this.btnKes.Location = new System.Drawing.Point(372, 66);
            this.btnKes.Name = "btnKes";
            this.btnKes.Size = new System.Drawing.Size(100, 23);
            this.btnKes.TabIndex = 3;
            this.btnKes.Text = "Kes";
            this.btnKes.UseVisualStyleBackColor = true;
            this.btnKes.Click += new System.EventHandler(this.btnKes_Click);
            // 
            // btnTumunuSec
            // 
            this.btnTumunuSec.Location = new System.Drawing.Point(372, 37);
            this.btnTumunuSec.Name = "btnTumunuSec";
            this.btnTumunuSec.Size = new System.Drawing.Size(100, 23);
            this.btnTumunuSec.TabIndex = 2;
            this.btnTumunuSec.Text = "Tümünü Seç";
            this.btnTumunuSec.UseVisualStyleBackColor = true;
            this.btnTumunuSec.Click += new System.EventHandler(this.btnTumunuSec_Click);
            // 
            // btnSec
            // 
            this.btnSec.Location = new System.Drawing.Point(372, 8);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(100, 23);
            this.btnSec.TabIndex = 1;
            this.btnSec.Text = "Seç";
            this.btnSec.UseVisualStyleBackColor = true;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // txtBul
            // 
            this.txtBul.Location = new System.Drawing.Point(372, 153);
            this.txtBul.Name = "txtBul";
            this.txtBul.Size = new System.Drawing.Size(100, 20);
            this.txtBul.TabIndex = 6;
            this.txtBul.Text = "Den";
            // 
            // txtMain
            // 
            this.txtMain.HideSelection = false;
            this.txtMain.Location = new System.Drawing.Point(3, 3);
            this.txtMain.Multiline = true;
            this.txtMain.Name = "txtMain";
            this.txtMain.Size = new System.Drawing.Size(363, 257);
            this.txtMain.TabIndex = 0;
            this.txtMain.Text = "Deneme Metni";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnSayi);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.txtHedef);
            this.panel2.Controls.Add(this.txtKaynak);
            this.panel2.Location = new System.Drawing.Point(495, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(348, 273);
            this.panel2.TabIndex = 1;
            // 
            // btnSayi
            // 
            this.btnSayi.Location = new System.Drawing.Point(271, 219);
            this.btnSayi.Name = "btnSayi";
            this.btnSayi.Size = new System.Drawing.Size(60, 23);
            this.btnSayi.TabIndex = 9;
            this.btnSayi.Text = "SatSay";
            this.btnSayi.UseVisualStyleBackColor = true;
            this.btnSayi.Click += new System.EventHandler(this.btnSayi_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(181, 219);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(60, 23);
            this.button7.TabIndex = 7;
            this.button7.Text = "Sağa Yasla";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(271, 190);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(60, 23);
            this.button6.TabIndex = 8;
            this.button6.Text = "Ortala";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(181, 190);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "Sola Yasla";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(181, 160);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Bazı Değerleri Aktar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 219);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Değer Aktar ->";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Değer Ata";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 26);
            this.button1.TabIndex = 1;
            this.button1.Text = "Birden Çok Satır Aç";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtHedef
            // 
            this.txtHedef.Location = new System.Drawing.Point(181, 3);
            this.txtHedef.Multiline = true;
            this.txtHedef.Name = "txtHedef";
            this.txtHedef.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHedef.Size = new System.Drawing.Size(150, 150);
            this.txtHedef.TabIndex = 4;
            // 
            // txtKaynak
            // 
            this.txtKaynak.Location = new System.Drawing.Point(3, 3);
            this.txtKaynak.Name = "txtKaynak";
            this.txtKaynak.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtKaynak.Size = new System.Drawing.Size(172, 20);
            this.txtKaynak.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtWrap);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtMaxLenght);
            this.panel3.Controls.Add(this.txtLower);
            this.panel3.Controls.Add(this.txtUpper);
            this.panel3.Controls.Add(this.txtReadOnly);
            this.panel3.Controls.Add(this.txtPass);
            this.panel3.Controls.Add(this.txtNormal);
            this.panel3.Controls.Add(this.txtSifre);
            this.panel3.Controls.Add(this.txtKaynak_1);
            this.panel3.Location = new System.Drawing.Point(12, 291);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(477, 122);
            this.panel3.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(313, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Wrap";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(158, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Küçük";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(313, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "MaxLenght";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Pass";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(158, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Büyük";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(313, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "ReadOnly";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Normal";
            // 
            // txtWrap
            // 
            this.txtWrap.Location = new System.Drawing.Point(379, 66);
            this.txtWrap.Multiline = true;
            this.txtWrap.Name = "txtWrap";
            this.txtWrap.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtWrap.Size = new System.Drawing.Size(93, 51);
            this.txtWrap.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kaynak";
            // 
            // txtMaxLenght
            // 
            this.txtMaxLenght.Location = new System.Drawing.Point(379, 40);
            this.txtMaxLenght.MaxLength = 5;
            this.txtMaxLenght.Name = "txtMaxLenght";
            this.txtMaxLenght.Size = new System.Drawing.Size(93, 20);
            this.txtMaxLenght.TabIndex = 0;
            this.txtMaxLenght.TextChanged += new System.EventHandler(this.txtMaxLenght_TextChanged);
            // 
            // txtLower
            // 
            this.txtLower.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtLower.Location = new System.Drawing.Point(207, 66);
            this.txtLower.Name = "txtLower";
            this.txtLower.Size = new System.Drawing.Size(100, 20);
            this.txtLower.TabIndex = 0;
            // 
            // txtUpper
            // 
            this.txtUpper.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUpper.Location = new System.Drawing.Point(207, 40);
            this.txtUpper.Name = "txtUpper";
            this.txtUpper.Size = new System.Drawing.Size(100, 20);
            this.txtUpper.TabIndex = 0;
            // 
            // txtReadOnly
            // 
            this.txtReadOnly.Location = new System.Drawing.Point(379, 14);
            this.txtReadOnly.Name = "txtReadOnly";
            this.txtReadOnly.ReadOnly = true;
            this.txtReadOnly.Size = new System.Drawing.Size(93, 20);
            this.txtReadOnly.TabIndex = 0;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(52, 66);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(100, 20);
            this.txtPass.TabIndex = 0;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // txtNormal
            // 
            this.txtNormal.Location = new System.Drawing.Point(207, 14);
            this.txtNormal.Name = "txtNormal";
            this.txtNormal.Size = new System.Drawing.Size(100, 20);
            this.txtNormal.TabIndex = 0;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(52, 40);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '+';
            this.txtSifre.Size = new System.Drawing.Size(100, 20);
            this.txtSifre.TabIndex = 0;
            // 
            // txtKaynak_1
            // 
            this.txtKaynak_1.Location = new System.Drawing.Point(52, 14);
            this.txtKaynak_1.Name = "txtKaynak_1";
            this.txtKaynak_1.Size = new System.Drawing.Size(100, 20);
            this.txtKaynak_1.TabIndex = 0;
            this.txtKaynak_1.TextChanged += new System.EventHandler(this.txtKaynak_1_TextChanged);
            this.txtKaynak_1.Enter += new System.EventHandler(this.txtKaynak_1_Enter);
            this.txtKaynak_1.Leave += new System.EventHandler(this.txtKaynak_1_Leave);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txtUnluSayisi);
            this.panel4.Controls.Add(this.txtOnlyDigits);
            this.panel4.Controls.Add(this.txtUpper_1);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Location = new System.Drawing.Point(495, 291);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(348, 122);
            this.panel4.TabIndex = 3;
            // 
            // txtUnluSayisi
            // 
            this.txtUnluSayisi.Location = new System.Drawing.Point(93, 63);
            this.txtUnluSayisi.Name = "txtUnluSayisi";
            this.txtUnluSayisi.Size = new System.Drawing.Size(238, 20);
            this.txtUnluSayisi.TabIndex = 0;
            this.txtUnluSayisi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.unluSayiyiBul);
            // 
            // txtOnlyDigits
            // 
            this.txtOnlyDigits.Location = new System.Drawing.Point(93, 37);
            this.txtOnlyDigits.Name = "txtOnlyDigits";
            this.txtOnlyDigits.Size = new System.Drawing.Size(238, 20);
            this.txtOnlyDigits.TabIndex = 0;
            this.txtOnlyDigits.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOnlyDigits_KeyPress);
            // 
            // txtUpper_1
            // 
            this.txtUpper_1.Location = new System.Drawing.Point(93, 11);
            this.txtUpper_1.Name = "txtUpper_1";
            this.txtUpper_1.Size = new System.Drawing.Size(238, 20);
            this.txtUpper_1.TabIndex = 0;
            this.txtUpper_1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tusBasilinca);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 69);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Ünlü Sayısı";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Sadece Sayılar";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Ctrl+U ve Ctrl+L";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 427);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Button btnYapistir;
        private System.Windows.Forms.Button btnKopyala;
        private System.Windows.Forms.Button btnKes;
        private System.Windows.Forms.Button btnTumunuSec;
        private System.Windows.Forms.Button btnSec;
        private System.Windows.Forms.TextBox txtBul;
        private System.Windows.Forms.TextBox txtMain;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtHedef;
        private System.Windows.Forms.TextBox txtKaynak;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLower;
        private System.Windows.Forms.TextBox txtUpper;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtNormal;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtKaynak_1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtWrap;
        private System.Windows.Forms.TextBox txtMaxLenght;
        private System.Windows.Forms.TextBox txtReadOnly;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtUpper_1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUnluSayisi;
        private System.Windows.Forms.TextBox txtOnlyDigits;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSayi;
    }
}

