using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uyg_10_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class Araba
        {
            private int kapiSayisi;
            private int model;
            public string Renk { get; set; } = "Yeşil";

            public Araba() //constructors (parametresiz yapıcı fonksiyon)
            {
                MessageBox.Show("Araba nesnesi üretildi");
            }

            public Araba(int kapi, int mod, string color) //constructors (yapıcı fonksiyon)
            {
                this.kapiSayisi = kapi;
                this.model = mod;
                this.Renk = color;
                MessageBox.Show("Araba nesnesi üretildi");
            }

            public int KapiSayisi
            {
                get { return kapiSayisi; }
                set { kapiSayisi = value; }
            }
            public int Model
            {
                get { return model; }
                set {
                    if (value <1980)
                    {
                        model = 1990;
                    }
                    else
                    {
                        model = value;
                    }
                }
            }
            public override string ToString()
            {
                string a;
                a = "Bu arabanın modeli =" + this.model +
                    " rengi =" + this.Renk +
                    " kapı sayısı = " + this.kapiSayisi;
                return a;
            }
            ~Araba() //destructors
            {
                MessageBox.Show("Class işlemini tamamladı");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Araba toyota = new Araba();
            toyota.KapiSayisi = 5;
            toyota.Model = 1970;
            toyota.Renk = "kırmızı";
            Araba honda = new Araba(5, 1991, "mavi");
            MessageBox.Show(toyota.KapiSayisi.ToString()+" "+ toyota.Model.ToString() + " " + toyota.Renk.ToString());
            MessageBox.Show(honda.ToString());          
        }




        sinema salon;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                salon = new sinema(textBox1.Text, Convert.ToInt32(textBox2.Text));
                label3.Text = "Salon Oluşturuldu. Koltuk sayısı : " + salon.BosKoltukOgren();
            }
            catch (Exception ex)
            {
                label3.Text = "Salon Oluşturulamadı. Bilgileri kontrol edin.";
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            salon.BiletSat(checkBox1.Checked);
            label3.Text = "Bilet satıldı. Kalan koltuk sayısı : " + salon.BosKoltukOgren();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            salon.BiletIptal(checkBox1.Checked);
            label3.Text = "Bilet iptal edildi. Kalan koltuk sayısı : " + salon.BosKoltukOgren();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label3.Text = "Şu anki bakiye " + salon.BakiyeOgren() + " TL";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Text = "Boş koltuk sayısı " + salon.BosKoltukOgren();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            deneme aaa = new deneme();
            aaa.setKapi(15);
            MessageBox.Show(aaa.getKapi().ToString());
            deneme bbb = new deneme(4,2000,"kırmızı");

            MessageBox.Show(aaa.ToString());
            MessageBox.Show(bbb.ToString());

        }

        private void button8_Click(object sender, EventArgs e)
        {
            ogrenci ali = new ogrenci();
            ali.Ad = "Ali";
            ali.Soyad = "Dene";
            ali.ogrNo = 14654654;
            //ali.setDonem(-5);
           // MessageBox.Show(ali.getDonem().ToString());
            

            ogrenci veli = new ogrenci(146,"Veli","deneme",3);
            //veli.Ad = "Veli";
            //veli.Soyad = "Deneme";
            //veli.ogrNo = 146;
            //veli.setDonem(3);

            MessageBox.Show(ali.ToString());
        }
    }
}
