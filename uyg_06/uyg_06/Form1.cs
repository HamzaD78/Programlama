using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uyg_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Start();
            staProgBar.Maximum = 59;
            staProgBar.Minimum = 0;
            staProgBar.Step = 1;
            richTextBox1.Text = "Herkes, beraberinde taşıdığı bir parmaklığın ardında yaşıyor. F.Kafka" + Environment.NewLine + "http:\\www.google.com.tr";
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string saat = DateTime.Now.ToLongTimeString();
            string saniye = DateTime.Now.Second.ToString();
            staProgBar.Value = Convert.ToInt32(saniye);
            staLabSaat.Text = "Saat :" + saat;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolTipAyarla();
        }

        private void toolTipAyarla()
        {
            ttBilgi.AutoPopDelay = 5000;
            ttBilgi.InitialDelay = 1000;
            ttBilgi.ReshowDelay = 500;
            ttBilgi.ToolTipIcon = ToolTipIcon.Info;
            ttBilgi.ToolTipTitle = "Uyarı..!";
            ttBilgi.IsBalloon = true;
            ttBilgi.SetToolTip(textBox1, "Buradan kayıt işlemleri yapılır...");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                richTextBox1.DetectUrls = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                richTextBox1.DetectUrls = false;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            richTextBox1.ZoomFactor = trackBar1.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(richTextBox1.SelectedText);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionBackColor = Color.Red;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Font fnt = new Font("Verdana", 15, FontStyle.Bold);
            FontDialog fd = new FontDialog();

            if (fd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fd.Font;
            }
            //richTextBox1.SelectionFont = fnt;
            //richTextBox1.Font = fnt;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                richTextBox1.SelectionIndent = 8;
            }
            else
            {
                richTextBox1.SelectionIndent = 0;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                richTextBox1.SelectionBullet = true;
            }
            else
            {
                richTextBox1.SelectionBullet = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionCharOffset = 10;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionCharOffset = -10;
        }

        private void btnKontrol(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Name == "btnIleri")
            {
                if (this.richTextBox1.CanUndo)
                {
                    richTextBox1.Undo();
                }
                else return;
            }
            else if (btn.Name == "btnGeri")
            {
                if (this.richTextBox1.CanRedo)
                {
                    richTextBox1.Redo();
                }
                else return;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            // Exe'nin bulunduğu yolu al...
            //string yol = System.Reflection.Assembly.GetEntryAssembly().Location.ToString();
            //string yol = Application.ExecutablePath;
            string yol = Application.StartupPath;

            SaveFileDialog sv = new SaveFileDialog();
            sv.InitialDirectory = yol;
            sv.Filter = "Zengin Metin | *.rtf";
            if (sv.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(sv.FileName);
            }
        }

        private void tabPageControl(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                tabControl1.Alignment = TabAlignment.Top;
            }
            else if (radioButton7.Checked)
            {
                tabControl1.Alignment = TabAlignment.Bottom;
            }
            else if (radioButton8.Checked)
            {
                tabControl1.Alignment = TabAlignment.Left;
            }
            else if (radioButton9.Checked)
            {
                tabControl1.Alignment = TabAlignment.Right;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                int aktif = tabControl1.SelectedIndex, tabSayisi = tabControl1.TabPages.Count;
                if (tabSayisi > aktif + 1)
                {
                    tabControl1.SelectTab(++aktif);
                }
                else return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                int aktif = tabControl1.SelectedIndex;
                if (aktif - 1 >= 0)
                {
                    tabControl1.SelectTab(--aktif);
                }
                else return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DateTime sdt = dtStart.Value.Date;
            DateTime edt = dtEnd.Value.Date;

            TimeSpan ts = edt - sdt;

            int days = ts.Days;
            int months = ((edt.Year - sdt.Year) * 12) + edt.Month - sdt.Month;
            int years = (edt.Year - sdt.Year);

            label2.Text = "Yıl : " + years.ToString();
            label3.Text = "Ay : " + months.ToString();
            label4.Text = "Gün : " + days.ToString();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("{0} nolu sayfa aktif...", tabControl1.SelectedIndex.ToString()));
            if (tabControl1.SelectedIndex == 1)
            {
                dtStart.Value = new DateTime(2000, 08, 15);
            }
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Satranc(flowLayoutPanel1,0);
            Satranc(flowLayoutPanel2,3);
        }

        private void Satranc(FlowLayoutPanel fpp ,int bosluk)
        {
            fpp.Controls.Clear();
            int i = 0, j = 0, yer = 0, sayac = 1;
            for (i = 0; i < 8; i++) //satır
            {
                for (j = 0; j < 8; j++) //sütun
                {
                    if (i % 2 == 0)
                    {
                        if (yer == 1)
                        {
                            Button btn = new Button() { Name = "btn"+string.Format(sayac.ToString()), Text = sayac.ToString() };
                            btn.BackColor = Color.Black;
                            btn.ForeColor = Color.White;
                            btn.Margin = new Padding(bosluk);
                            btn.Size = new Size(30, 30);
                            btn.Click += new EventHandler(btn_click);
                            fpp.Controls.Add(btn);
                            yer = 0;
                            sayac++;
                        }
                        else
                        {
                            yer++;
                            Button btn = new Button() { Name = "btn" + string.Format(sayac.ToString()), Text = sayac.ToString() };
                            btn.BackColor = Color.White;
                            btn.ForeColor = Color.Black;
                            btn.Margin = new Padding(bosluk);
                            btn.Size = new Size(30, 30);
                            btn.Click += new EventHandler(btn_click);
                            fpp.Controls.Add(btn);
                            sayac++;
                        }
                    }
                    else
                    {
                        if (yer == 0)
                        {
                            Button btn = new Button() { Name = "btn" + string.Format(sayac.ToString()), Text = sayac.ToString() };
                            btn.BackColor = Color.Black;
                            btn.ForeColor = Color.White;
                            btn.Margin = new Padding(bosluk);
                            btn.Size = new Size(30, 30);
                            btn.Click += new EventHandler(btn_click);
                            fpp.Controls.Add(btn);
                            yer++;
                            sayac++;
                        }
                        else
                        {
                            yer = 0;
                            Button btn = new Button() { Name = "btn" + string.Format(sayac.ToString()), Text = sayac.ToString() };
                            btn.BackColor = Color.White;
                            btn.ForeColor = Color.Black;
                            btn.Margin = new Padding(bosluk);
                            btn.Size = new Size(30, 30);
                            btn.Click += new EventHandler(btn_click);
                            fpp.Controls.Add(btn);
                            sayac++;
                        }
                    }
                }
            }
        }
        private void btn_click(object sender, EventArgs e)
        {
            Button btn = sender as Button; // veya (Button)sender;
            MessageBox.Show(string.Format("{0} nolu buton tıklandı", btn.Name.ToString()));

        }

        private void flowLayoutPanel1_ControlAdded(object sender, ControlEventArgs e)
        {
            //if (e.Control.Name == "btn1")
            //{
            //    MessageBox.Show("btn1 eklendi");
            //}
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ep1.Clear();
            if (txKimlik.Text == string.Empty)
            {
                ep1.SetError(txKimlik, "Tc Kimlik No Giriniz...");
                txKimlik.Focus();
            }
            else if (txTelNo.Text == string.Empty)
            {
                ep1.SetError(txTelNo, "Bir Telefon Numarası Giriniz...");
                txTelNo.Focus();
            }
            else if (txKimlik.TextLength != 11)
            {
                ep1.SetError(txKimlik, "11 haneli Tc Kimlik No Giriniz...");
                txKimlik.Focus();
            }
            else if (lbKayit.Items.Contains(txKimlik.Text + " " + txTelNo.Text))
            {
                ep1.SetError(txKimlik, "Daha Önce Eklendi");
                ep1.SetError(txTelNo, "Daha Önce Eklendi");
            }
            else
            {
                lbKayit.Items.Add(txKimlik.Text + " " + txTelNo.Text);
                txKimlik.Text = string.Empty;
                txTelNo.Text = string.Empty;
                ep1.Clear();
                txKimlik.Focus();
            }
        }

        private void txKimlik_Validating(object sender, CancelEventArgs e)
        {
            //ep1.Clear();
            //int rakam;
            //bool rakamvar = false;
            //rakamvar = int.TryParse(txKimlik.Text, out rakam);
            //if (rakamvar==false)
            //{
            //    ep1.SetError(txKimlik, "Bu alana harf girilmez..!");
            //    txKimlik.Focus();
            //}
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            MessageBox.Show(monthCalendar1.SelectionStart.ToLongDateString());
        }

        private void button12_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0: notifyIcon1.BalloonTipIcon = ToolTipIcon.None; break;
                case 1: notifyIcon1.BalloonTipIcon = ToolTipIcon.Info; break;
                case 2: notifyIcon1.BalloonTipIcon = ToolTipIcon.Warning; break;
                case 3: notifyIcon1.BalloonTipIcon = ToolTipIcon.Error; break;
            }
            notifyIcon1.ShowBalloonTip(int.Parse(txSure.Text), txBaslik.Text, txMesaj.Text, notifyIcon1.BalloonTipIcon);
        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            MessageBox.Show("NotifyIcon'a ait balon tıklandı");
        }
        private void programıKapaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void programıAçToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
