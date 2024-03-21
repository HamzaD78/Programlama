using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uyg_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            labelSayisi.Text = cboxDeneme.Items.Count.ToString();
            illerOku();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            cboxDeneme.DropDownStyle = ComboBoxStyle.Simple;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cboxDeneme.DropDownStyle = ComboBoxStyle.DropDown;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cboxDeneme.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cboxDeneme_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelIndex.Text = cboxDeneme.SelectedIndex.ToString();
            labelIcerik.Text = cboxDeneme.SelectedItem.ToString();
        }

        private void btAyarla_Click(object sender, EventArgs e)
        {
            int genislik = Convert.ToInt32(txbGenislik.Text), uzunluk = Convert.ToInt32(txbUzunluk.Text);
            cboxDeneme.DropDownWidth = genislik;
            cboxDeneme.DropDownHeight = uzunluk;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cboxEkle.Items.Add(txbEkle.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cboxEkle.Items.Clear();
            cboxEkle.Text = string.Empty;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!cboxEkle.Items.Contains(txbEkle.Text))
            {
                cboxEkle.Items.Add(txbEkle.Text);
                txbEkle.Text = "";
            }
            else
            {
                MessageBox.Show("Bu değer mevcut listede bulunmaktadır...");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string[] dizi = new string[] { "Ankara", "Antalya", "Konya", "İstanbul" };

            cboxEkle.Items.AddRange(dizi);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                cboxEkle.Items.Insert(Convert.ToInt32(txbIndex.Text), txbVeri.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            string[] dizi = new string[cboxEkle.Items.Count];

            cboxEkle.Items.CopyTo(dizi, 0);
            txbAktar.Lines = dizi;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            cboxEkle.Items.Remove(txbVeri.Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                cboxEkle.Items.RemoveAt(Convert.ToInt32(txbIndex.Text));
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
}

        private void illerOku()
        {
            string il;
            StreamReader str = new StreamReader(@".\iller\iller.txt");

            try
            {
                while ((il = str.ReadLine()) != null)
                {
                    cboxIller.Items.Add(il);
                }
                cboxIller.SelectedIndex = -1;
                cboxIller.Text = "İl seçiniz";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                str.Close();
            }
        }

        private void cboxIller_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboxIlceler.Items.Clear();
            string ilceler;
            StreamReader str = new StreamReader(@".\iller\" + cboxIller.Text + ".txt");
            try
            {
                while ((ilceler = str.ReadLine()) != null)
                {
                    cboxIlceler.Items.Add(ilceler);
                }
                cboxIlceler.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                str.Close();
            }
        }

        private void cmbIslemSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            int islem=cmbIslemSec.SelectedIndex;

            switch (islem)
            {
                case 0: txtSonuc.Text = (Convert.ToInt16(txtIlkSayi.Text) + Convert.ToInt16(txtIkinciSayi.Text)).ToString(); break;
                case 1: txtSonuc.Text = (Convert.ToInt16(txtIlkSayi.Text) - Convert.ToInt16(txtIkinciSayi.Text)).ToString(); break;
                case 2: txtSonuc.Text = (Convert.ToInt16(txtIlkSayi.Text) * Convert.ToInt16(txtIkinciSayi.Text)).ToString(); break;

                default:
                    break;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string[] dizi = new string[] { "Toplama", "Çıkarma", "Çarpma", "Bölme" };

            cmbIslemSec.Items.AddRange(dizi);
        }

    }
}
