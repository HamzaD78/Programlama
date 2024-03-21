using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace uyg_05
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbBirinci.Items.Add(txbEkle.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbBirinci.SelectionMode = SelectionMode.One;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lbBirinci.SelectionMode = SelectionMode.None;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            lbBirinci.SelectionMode = SelectionMode.MultiSimple;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            lbBirinci.SelectionMode = SelectionMode.MultiExtended;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lbAktar.Items.Clear();
            //1.yol
            foreach (object selectedItem in lbBirinci.SelectedItems)
            {
                lbAktar.Items.Add(selectedItem);
            }
            //2.yol
            int[] indisler = new int[lbBirinci.SelectedIndices.Count];
            lbBirinci.SelectedIndices.CopyTo(indisler, 0);
            for (int i = 0; i < indisler.Length; i++)
            {
                lbAktar.Items.Add(lbBirinci.Items[indisler[i]]);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            lbBirinci.SelectedIndices.Add(int.Parse(txbIndices.Text));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            lbBirinci.SelectedIndices.Remove(int.Parse(txbIndices.Text));
        }

        private void button9_Click(object sender, EventArgs e)
        {
            lbAktar.Sorted = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (lbBirinci.FindString(txbBul.Text)>-1)
            {
                lbBirinci.SelectedIndex = (lbBirinci.FindString(txbBul.Text));
            }
            else
            {
                lbBirinci.ClearSelected();
                MessageBox.Show("Aranan değer bulunamadı...");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (lbBirinci.SelectedIndex < 0)
            {
                button10_Click(null, EventArgs.Empty);
            }
            else
            {
                int bas = lbBirinci.SelectedIndex;
                if (lbBirinci.FindString(txbBul.Text, bas) > -1)
                {
                    bas = lbBirinci.FindString(txbBul.Text, bas);
                    if (bas != 0)
                    {
                        lbBirinci.SelectedIndex = bas;
                    }
                    else MessageBox.Show("Bulunamadı");
                }
                else MessageBox.Show("Bulunamadı");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            lbAsal.Items.Clear();
            int sayi;
            if (!int.TryParse(txbSayi.Text, out sayi))
            {
                return;
            }

            if (sayi<0)
            {
                sayi = Math.Abs(sayi);
            }

            uint asalBolen = 2;
            for (; asalBolen <= sayi;)
            {
                if (sayi % asalBolen == 0)
                {
                    sayi = sayi / (int)asalBolen;
                    lbAsal.Items.Add(asalBolen);
                }
                else
                {
                    if (!asalmi(++asalBolen))
                    {
                        //break;
                        continue;
                    }
                }
            }
        }

        private bool asalmi(uint gelenSayi)
        {
            if (gelenSayi == 2)
            {
                return true;
            }
            for (int i = 2; i <= gelenSayi-1; i++)
            {
                if (gelenSayi % i == 0)
                {
                    return false;
                }
            }
            return true;

        }

        string[] kelimeler;

        private void Form1_Load(object sender, EventArgs e)
        {
            kelimeler = File.ReadAllLines(@".\kelimeler.txt",Encoding.Default);
            kelimeOku(true);
        }

        private void kelimeOku(bool turkce)
        {
            lbKelimeler.Items.Clear();
            foreach (string satir in kelimeler)
            {
                string[] parcala = satir.Split(';');
                string kelime = string.Empty;
                kelime = turkce ? parcala[3] : parcala[0]; //?:
                lbKelimeler.Items.Add(kelime);
            }
        }

        private void rbTreng_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTreng.Checked)
            {
                kelimeOku(true);
            }
        }

        private void rbEngtr_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEngtr.Checked)
            {
                kelimeOku(false);
            }
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            if (txbKelime.Text == string.Empty) return;

            int sira = lbKelimeler.FindString(txbKelime.Text);
            if (sira < 0)
            {
                MessageBox.Show("Bulunamadı");
            }
            else
            {
                lbKelimeler.SelectedIndex = sira;
                string satir = kelimeler[sira];
                string[] parcala = satir.Split(';');

                lblBirinci.Text = "Birinci Hali :" + parcala[0];
                lblIkınci.Text = "İkinci Hali :" + parcala[1];
                lblUcuncu.Text = "Üçüncü Hali :" + parcala[2];
                lblAnlami.Text = "Anlamı :" + parcala[3];

            }
        }
    }
}
