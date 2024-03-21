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
using System.Diagnostics;

namespace uyg_07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getir()
        {
            string[] suruculer = Directory.GetLogicalDrives(); //System.IO ekli olmalı, mevcut mantıksal sürücüler alınır.
            foreach (string surucu in suruculer) // sürücüler sırasıyla surucu değişkenine aktarılır
            {
                treeView1.Nodes.Add(surucu);//treeview bileşenine herbir sürücü düğüm olarak eklenir.
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getir();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string yol = treeView1.SelectedNode.Text; //seçilen düğüme ait yol alınır...
            try
            {
                string[] dosyalar = Directory.GetFiles(yol); //seçilen düğümün altındaki dosyalar alınır.
                string[] klasorler = Directory.GetDirectories(yol);//seçilen düğümün altındaki klasörler alınır.

                foreach (string f in dosyalar)
                {
                    e.Node.Nodes.Add(f);//alınan dosyalar seçilen düğümün altına eklenir.
                }
                foreach (string d in klasorler)
                {
                    e.Node.Nodes.Add(d);//alınan klasörler seçilen düğümün altına eklenir.
                }
            }
            catch (Exception)
            {
                try
                {
                    System.Diagnostics.Process.Start(yol);//seçilen düğümün bir klasör olmaması durumunda o dosyayı çalıştırma işlemi yapılır.
                }
                catch (Exception)
                {
                    ;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            treeView1.ExpandAll(); //Tüm düğümleri açmak için kullanılır.
        }

        private void button3_Click(object sender, EventArgs e)
        {
            treeView1.CollapseAll();//tüm düğümleri kapamak için kullanılır.
        }

        private void button4_Click(object sender, EventArgs e)
        {
            treeView2.Nodes.Clear();//treeview'in temizlenmesi için kullanılmaktadır.
            TreeNode[] tNode = { new TreeNode("Alt Başlık 1"), new TreeNode("Alt Başlık 2") };//tNode dizisine yeni düğümler ekleniyor.
            TreeNode tUc = new TreeNode("Ana Başlık", tNode);//tUc düğümünü üst düğüm ve tNode dizisindeki düğümler alt düğüm olarak ekleniyor.
            treeView2.Nodes.Add(tUc);//oluşturulan düğüm yapısı treeview bileşenine aktarılıyor.
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TreeNode tAlt1 = new TreeNode("En alt başlık 1");//yeni düğüm oluşturuluyor
            TreeNode tAlt2 = new TreeNode("En alt başlık 2");//yeni düğüm oluşturuluyor
            TreeNode[] tAlt = new TreeNode[2];//oluşturulan yeni düğümleri alabilmek için bir düğüm dizisi oluşturuluyor
            tAlt[0] = tAlt1;//yeni düğümler diziye aktarılıyor
            tAlt[1] = tAlt2;
            TreeNode tAltAlt = new TreeNode("Alt Başlık 3", tAlt);//düğüm dizisi bu oluturulan tAltAlt düğümünün altına alınıyor.
            treeView2.Nodes[0].Nodes[1].Nodes.Add(tAltAlt);//tAltAlt 0.düğümün altındaki 1.düğümün altına eklenerek treeview bileşenine aktarılıyor.
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string[] icerik1 = { "aaa", "bbb", "1234" };//listview için içerik oluşturuluyor
            string[] icerik2 = { "ccc", "ddd", "5678" };

            ListViewItem item1 = new ListViewItem(icerik1);// içerikler bir dizi olarak listview nesnesine aktarılıyor
            ListViewItem item2 = new ListViewItem(icerik2);

            listView1.Items.Add(item1);// listviewitem ları listview içine aktarılıyor
            listView1.Items.Add(item2);
            listView1.SmallImageList = image16;//listview'in küçük resim imageList bileşeni tanımlanıyor
            listView1.LargeImageList = image32;//listview'in büyük resim imageList bileşeni tanımlanıyor
            listView1.Items[0].ImageIndex = 0;//listviewitem larının imageList'deki hangi indeksteki resmi kullanacağı belirleniyor
            listView1.Items[1].ImageIndex = 1;

            listView1.CheckBoxes = true;//listview'deki checkbox özelliği aktif ediliyor
        }

        private void projeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;//tabcontol'ün 0 indeksili sayfası aktif ediliyor
        }

        private void dosyaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;//tabcontol'ün 1 indeksili sayfası aktif ediliyor

        }

        private void listView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (listView1.Items[0].Checked)// 0. bileşen seçilmiş mi
            {
                MessageBox.Show(listView1.Items[0].SubItems[1].Text);//0.item'ın altındaki 1. özelliği göster
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listView1.CheckBoxes = false;
            listView1.View = View.Details;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listView1.CheckBoxes = false;
            listView1.View = View.LargeIcon;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listView1.CheckBoxes = false;
            listView1.View = View.List;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            listView1.CheckBoxes = false;
            listView1.View = View.SmallIcon;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            listView1.CheckBoxes = false;
            listView1.View = View.Tile;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // Listview için başlıklar resimli bir şekilde oluşturuluyor
            listView2.SmallImageList = image16;//listview in hangi imagelist i kullanacağı belirleniyor
            ColumnHeader pAdi = new ColumnHeader();//bir başlık nesnesi oluşturuluyor
            pAdi.Text = "Personel Adı";// nesnenin text i belirleniyor
            pAdi.ImageIndex = 0;// hangi indeksli resmi kullanacağı belirleniyor
            pAdi.Width = 100;// kaç pixellik bir genişlik ayrıldığı belirleniyor
            ColumnHeader pSoyadi = new ColumnHeader();
            pSoyadi.Text = "Personel Soyadı";
            pSoyadi.ImageIndex = 1;
            pSoyadi.Width = 150;

            ColumnHeader[] basliklar = { pAdi, pSoyadi };// başlıklar bir diziye aktarılıyor
            listView2.Columns.AddRange(basliklar);// başlıklar listview bileşenine aktarılıyor

            // Listview Grupları oluşturuluyor
            ListViewGroup group1 = new ListViewGroup("Grup 1", HorizontalAlignment.Right);//gruplar ve konumsal yeri belirleniyor
            ListViewGroup group2 = new ListViewGroup("Grup 2", HorizontalAlignment.Center);
            ListViewGroup group3 = new ListViewGroup("Grup 3", HorizontalAlignment.Left);

            ListViewGroup[] gruplar = { group1, group2, group3 };// gruplar diziye aktarılıyor
            listView2.Groups.AddRange(gruplar);// gruplar listview bileşenine uygulanıyor

            //Listview itemlar oluşturuluyor
            string[] item1Str = { "Ahmet", "CAN" };//listview itemları tanımlanıyor
            string[] item2Str = { "Mehmet", "KAN" };
            string[] item3Str = { "Veli", "SON" };
            //string[] item4Str = { "Ali", "SOM" };

            ListViewItem item1 = new ListViewItem(item1Str);//string olarak oluşturulan itemlar listviewitem nesnesine aktarılıyor
            ListViewItem item2 = new ListViewItem(item2Str);
            ListViewItem item3 = new ListViewItem(item3Str);
            ListViewItem item4 = new ListViewItem();//burada bir dizi olarak yukarıdaki gibi tanımlama yapılmazsa nasıl bir atama yapılacağına örnek
            item4.Text = "Ali";                     // verilmiştir, ikinci özellik subitems olarak tanımlanmıştır, dikkat!!!
            item4.SubItems.Add("SOM");

            listView2.Items.Add(item1); //Bu kısımda listviewitem dizisi oluşturulup addrange kullanılabilirdi
            listView2.Items.Add(item2);
            listView2.Items.Add(item3);
            listView2.Items.Add(item4);

            //listview itemları gruplara aktarılıyor
            listView2.Items[0].Group = listView2.Groups[0];//itemların hangi gruba ait oldukları belirleniyor
            listView2.Items[1].Group = listView2.Groups[0];
            listView2.Items[2].Group = listView2.Groups[1];
            listView2.Items[3].Group = listView2.Groups[2];

            //Listview için sunum şekli değiştiriliyor
            listView2.View = View.Details;

        }

        private void button13_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbDialog = new FolderBrowserDialog();//dialog nesnesi tanımlanıyor
            if (fbDialog.ShowDialog()==DialogResult.OK)//dialog açıldıktan sonra seçim yapılıp Tamam'a basıldımı
            {
                clbVeriler.Items.Clear();//checklistboxdaki verileri temizle
                clbVeriler.Items.AddRange(Directory.GetFiles(fbDialog.SelectedPath));//clb'e belirtilen konumdaki dosyaları ekle
            }
        }

        string yeniKonum;//yeni konum değişkeni başka fonksiyonlarda da kullanabilmesi için lokal değil global tanımlanmıştır.
        private void button14_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbDialogYeni = new FolderBrowserDialog();
            if (fbDialogYeni.ShowDialog() == DialogResult.OK)
            {
                yeniKonum = fbDialogYeni.SelectedPath;//seçilen ve kopyalama için hedef konum alınıyor
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            // Eğer kopyalama için seçilen birşey yoksa veya kopyalanacak konum girilmediyse işlem yapma
            if (clbVeriler.CheckedItems.Count == 0 || yeniKonum == string.Empty) return;

            // seçilen verileri tek tek tara ve uygun olanları kopyala
            foreach (var item in clbVeriler.CheckedItems)
            {
                if (File.Exists(item.ToString())) //Kopyalanacak dosya belirtilen konumda var mı? silinme ihtimaline karşı
                {
                    string yeni = Path.Combine(yeniKonum, Path.GetFileName(item.ToString())); //kopyalanacak dosyanın adı yeni konum adresine aktarılıyor.
                    if (File.Exists(yeni)) continue; //kopyalanacağı konumda bu dosya var mı? varsa kopyalama işlemini atla,sıradaki dosyaya geç.
                    File.Copy(item.ToString(), yeni); // kopyalama işlemi kaynaktan hedefe doğru yapılıyor...
                }
            }
            Process.Start(yeniKonum);//Hedef konum gösteriliyor...

        }

        private void asdasdasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("tıklandı");
        }

        private void sdasdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Menu tıklandı");
        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eleman1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("deneme");
        }
    }
}
