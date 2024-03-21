using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace uyg_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AcceptButton = btnAccept;
            this.CancelButton = btnCancel;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            trackBarAyarla();
        }

        private void trackBarAyarla()
        {
            trackBar1.Minimum = 0;
            trackBar1.Maximum = 100;
            trackBar1.Value = 100;
            trackBar1.TickFrequency = 1;
            label1.Text = "Değer = " + trackBar1.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string baslik = Interaction.InputBox("Form başlığını giriniz :", "Bilgi Giriş Ekranı");
            this.Text = baslik;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog cld = new ColorDialog();
            if (cld.ShowDialog()==DialogResult.OK)
            {
                this.BackColor = cld.Color;
                MessageBox.Show("Arka plan rengi " + cld.Color.Name.ToString() + " olarak değiştirildi...",
                    "Bilgi Ekranı", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Arka plan rengi değiştirilmedi...",
                    "Bilgi Ekranı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Resimi Seç";
            ofd.Filter = "Resim Dosyaları | *.jpg;*.png;*.gif;*.bmp;";

            if (ofd.ShowDialog()==DialogResult.OK)
            {
                Bitmap resim = new Bitmap(ofd.FileName);
                this.BackgroundImage = resim;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.BackgroundImageLayout = ImageLayout.None;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.BackgroundImageLayout = ImageLayout.Tile;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.BackgroundImageLayout = ImageLayout.Center;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Text = "Deneme Formu";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string degerAl = Interaction.InputBox("Ana renkler için 1, RGB renkleri için 2 giriniz", "Seçim Ekranı");
            switch (degerAl)
            {
                case "1": this.BackColor = Color.Red; break;
                case "2": 
                        Random rng = new Random();
                        int r, g, b;
                        r = rng.Next(0, 256);
                        g = rng.Next(0, 256);
                        b = rng.Next(0, 256);
                        this.BackColor = Color.FromArgb(r, g, b);
                    
                    break;
                default:
                    MessageBox.Show("Yanlış bir giriş yaptınız..!",
                "Bilgi Ekranı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    break;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                this.Font = fd.Font;
                MessageBox.Show("Formun fontu değiştirildi...",
                    "Bilgi Ekranı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Formun fontu değiştirilmedi...",
                    "Bilgi Ekranı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Font fnt = new Font("Verdana", 10, FontStyle.Italic);
            this.Font = fnt;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            ColorDialog cld = new ColorDialog();
            if (cld.ShowDialog() == DialogResult.OK)
            {
                this.ForeColor = cld.Color;
                MessageBox.Show("Ön plan rengi " + cld.Color.Name.ToString() + " olarak değiştirildi...",
                    "Bilgi Ekranı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ön plan rengi değiştirilmedi...",
                    "Bilgi Ekranı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.ForeColor = Color.Red;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = "Değer = " + trackBar1.Value.ToString() ;
            this.Opacity = (double)trackBar1.Value / 100;
        }


        private void button17_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Thread.Sleep(5000);
            this.Enabled = true;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            string projectAddress = Environment.CurrentDirectory;
            ofd.InitialDirectory = projectAddress;

            ofd.Title = "İkon Resmini Seç";
            ofd.Filter = "ico Dosyaları | *.ico;";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Icon ico = new Icon(ofd.FileName);
                this.Icon = ico;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Icon ico = new Icon(@".\uni.ico");
            this.Icon = ico;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            this.ShowIcon = true;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.ShowIcon = false;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            this.AutoScroll = true;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            this.AutoScroll = false;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            this.AutoSize = true;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            this.AutoSize = false;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            this.AutoSizeMode = AutoSizeMode.GrowOnly;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

        }

        private void button32_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

        }

        private void button34_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;

        }

        private void button35_Click(object sender, EventArgs e)
        {
            this.MaximizeBox = true;
        }

        private void button36_Click(object sender, EventArgs e)
        {
            this.MinimizeBox = true;
        }

        private void button37_Click(object sender, EventArgs e)
        {
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.HelpButton = true;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show(e.CloseReason.ToString());
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var kapama = new Form2();
            kapama.StartPosition = FormStartPosition.CenterScreen;
            if (kapama.ShowDialog() == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            //MessageBox.Show(string.Format("Formun boyutları değiştirildi. Yeni genişlik {0}, Yeni Yükseklik {1} oldu...", this.Width, this.Height));
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            int w = Convert.ToInt32(textBox1.Text), h = Convert.ToInt32(textBox2.Text);
            this.Size = new Size(w, h);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show(e.KeyCode.ToString());
            if (e.KeyCode == Keys.Space)
            {
                MessageBox.Show("Space butonuna basıldı");
            }
        }

        private void Form1_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            MessageBox.Show("Help dosyasına yönlendiriliyorsunuz");
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
