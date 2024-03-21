using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uyg_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtKaynak.Multiline = true;
            txtKaynak.Size = new Size(150, 150);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] satirlar = new string[10];
            for (int i = 0; i < satirlar.Length; i++)
            {
                satirlar[i] = "Satır_" + (i + 1).ToString();
            }
            txtKaynak.Lines = satirlar;

            for (int i = 0; i < 5; i++)
            {
                txtKaynak.Text += Environment.NewLine + "Son Eklenen Değer"+i.ToString();

            }
            //txtKaynak.Text += Environment.NewLine + "Son Eklenen Değer";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] str = txtKaynak.Lines.ToArray();
            txtHedef.Lines = str;
            //txtHedef.Lines = txtKaynak.Lines;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] str = new string[0];
            //str = txtKaynak.Lines;
            for (int i = 1; i <= txtKaynak.Lines.Count(); i++)
            {
                if (i%2 == 1)
                {
                    Array.Resize(ref str, str.Length + 1);
                    str[str.Length - 1] = txtKaynak.Lines[i-1];
                }
            }
            txtHedef.Lines = str;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtHedef.TextAlign != HorizontalAlignment.Left)
            {
                txtHedef.TextAlign = HorizontalAlignment.Left;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtHedef.TextAlign != HorizontalAlignment.Center)
            {
                txtHedef.TextAlign = HorizontalAlignment.Center;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (txtHedef.TextAlign != HorizontalAlignment.Right)
            {
                txtHedef.TextAlign = HorizontalAlignment.Right;
            }
        }

        private void txtKaynak_1_TextChanged(object sender, EventArgs e)
        {
            txtSifre.Text = txtKaynak_1.Text;
            txtPass.Text = txtKaynak_1.Text;
            txtNormal.Text = txtKaynak_1.Text;
            txtUpper.Text = txtKaynak_1.Text;
            txtLower.Text = txtKaynak_1.Text;
            txtReadOnly.Text = txtKaynak_1.Text;
            txtMaxLenght.Text = txtKaynak_1.Text;
            txtWrap.Text = txtKaynak_1.Text;
        }

        private void txtMaxLenght_TextChanged(object sender, EventArgs e)
        {
            if (txtMaxLenght.Text.Length >= 5)
            {
                txtMaxLenght.Select(0, 5);
                txtMaxLenght.Text = txtMaxLenght.SelectedText;
            }
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            if (frm2.ShowDialog() == DialogResult.OK)
            {
                if (frm2.start > -1 && frm2.end > -1)
                {
                    txtMain.Select(frm2.start, frm2.end);
                }
            }
        }

        private void btnTumunuSec_Click(object sender, EventArgs e)
        {
            txtMain.SelectAll();
        }

        private void btnKes_Click(object sender, EventArgs e)
        {
            txtMain.Cut();
        }

        private void btnKopyala_Click(object sender, EventArgs e)
        {
            txtMain.Copy();
        }

        private void btnYapistir_Click(object sender, EventArgs e)
        {
            txtMain.Paste();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            //if (txtBul.Text != "")
            if (!string.IsNullOrEmpty(txtBul.Text))
            {
                //txtMain.SelectionStart = 0;
                int baslangic = txtMain.Text.IndexOf(txtBul.Text);
                
                
                if (baslangic != -1)
                {
                    txtMain.Select(baslangic, txtBul.Text.Length);
                }
                else
                {
                    MessageBox.Show("Aranan ifade bulunamadı...");
                }
            }
            else
            {
                MessageBox.Show("Lütfen aramak için bir değer giriniz");
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtMain.Clear();
            //txtMain.Text = "";
            //txtMain.Text = string.Empty;
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(txtMain.SelectionLength.ToString());

            if (txtMain.SelectionLength > 0)
            {
                Form3 frm3 = new Form3();

                if (frm3.ShowDialog() == DialogResult.OK)
                {
                    //txtMain.Text = frm3.yeniMetin; bu satırda tüm textbox içeriği değiştirilir
                    txtMain.SelectedText = frm3.yeniMetin; //bu satırda sadece seçilen alanın text'i değiştirilir.
                } 
            }
        }

        private void txtKaynak_1_Leave(object sender, EventArgs e)
        {
            txtKaynak_1.BackColor = Color.White;
            txtKaynak_1.ForeColor = Color.Black;
        }

        private void txtKaynak_1_Enter(object sender, EventArgs e)
        {
            txtKaynak_1.BackColor = Color.Yellow;
            txtKaynak_1.ForeColor = Color.Navy;
            txtKaynak_1.Font = new Font("Verdana", 8, FontStyle.Bold);
        }

        private void tusBasilinca(object sender, KeyEventArgs e)
        {
            
            if (e.Control && e.KeyCode==Keys.U)
            {
                txtUpper_1.Text = txtUpper_1.Text.ToUpper();
            }
            else if (e.Control && e.KeyCode == Keys.L)
            {
                txtUpper_1.Text = txtUpper_1.Text.ToLower();
            }

        }

        private void txtOnlyDigits_KeyPress(object sender, KeyPressEventArgs e)
        {

            //int a = Convert.ToInt32(e.KeyChar);

            //char b = '3';
            //int c = (int)b;
            //if (b == '3')//45)
            //{
            //    MessageBox.Show("uygun");
            //}
            //MessageBox.Show(e.KeyChar.ToString());
            //if (e.KeyChar == (char)Keys.Enter)
            //{
            //    MessageBox.Show("entere basıldı");
            //}


            if (e.KeyChar>=48 && e.KeyChar<=57 || e.KeyChar==(char)Keys.Back)
            {
                e.Handled = false;
            }
            else e.Handled = true;
        }


        int sayac = 0;
        char[] unluler = { 'a', 'e', 'u', 'ü', 'ı', 'i', 'o', 'ö' };

        private void unluSayiyiBul(object sender, KeyPressEventArgs e)
        {
            char girilen = (char)e.KeyChar;
            if (unluler.Contains(girilen))
            {
                sayac++;
                MessageBox.Show(string.Format("Toplamda {0} adet ünlü harf girildi...", sayac));
            }
        }

        private void btnSayi_Click(object sender, EventArgs e)
        {
            if (txtHedef.Lines.Count()>0)
            {
                MessageBox.Show("Satır Sayısı =" + txtHedef.Lines.Count().ToString());
            }
        }
    }
}
