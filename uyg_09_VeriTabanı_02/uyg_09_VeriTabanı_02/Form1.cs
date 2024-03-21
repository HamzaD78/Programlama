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
using System.Data.OleDb;

namespace uyg_09_VeriTabanı_02
{
    public partial class Form1 : Form
    {
        static string con1 = "Provider=Microsoft.Jet.OLEDB.4.0;" +
            "Data Source=" + Application.StartupPath + "\\dataBase\\ticaretsade.mdb";

        static string con2 = "Provider=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=" + Application.StartupPath + "\\dataBase\\ticaretsade.accdb;" +
            "Jet OLEDB:Database Password=4444";
        OleDbConnection bag = new OleDbConnection(con1);
        OleDbCommand komut = new OleDbCommand();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            //dg1 ayarları
            dg1.RowCount = Convert.ToInt32(txGridSayisi.Text);
            dg1.ColumnCount = Convert.ToInt32(txGridSayisi.Text);
            dg1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dg1.ColumnHeadersVisible = false;
            dg1.RowHeadersVisible = false;
            

            //dg2 ayarları
            dg2.RowCount = Convert.ToInt32(txGridSayisi.Text);
            dg2.ColumnCount = Convert.ToInt32(txGridSayisi.Text);
            dg2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            for (int i = 0; i < dg2.Columns.Count; i++)
            {
                dg2.Columns[i].HeaderText = (i+1).ToString();
            }

            //dg1 ve dg2 için rastgele veri doldur...
            for (int i = 0; i < dg1.Rows.Count; i++)
            {
                for (int j = 0; j < dg1.Columns.Count; j++)
                {
                    dg1[i, j].Value = rd.Next(0, 21);
                    dg2[i, j].Value = rd.Next(0, 21);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(dg1[0, 0].Value.ToString());
            dg3.RowCount = dg1.Rows.Count;
            dg3.ColumnCount = dg1.ColumnCount;

            for (int i = 0; i < dg3.ColumnCount; i++)
            {
                dg3.Columns[i].Width = 50;
            }

            if (rdToplama.Checked)
            {
                
                for (int i = 0; i < dg3.ColumnCount; i++)
                {
                    for (int j = 0; j < dg3.RowCount; j++)
                    {
                        dg3[i, j].Value = Convert.ToInt32(dg1[i, j].Value) + Convert.ToInt32(dg2[i, j].Value);
                    }
                }
            }
            else if (rdCikarma.Checked)
            {
                for (int i = 0; i < dg3.ColumnCount; i++)
                {
                    for (int j = 0; j < dg3.RowCount; j++)
                    {
                        dg3[i, j].Value = Convert.ToInt32(dg1[i, j].Value) - Convert.ToInt32(dg2[i, j].Value);
                    }
                }
            }
            else
            {
                MessageBox.Show("çarpma işlemini de siz kodlayın...:)");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // İki adet tablo oluşturma
            DataTable tablo1 = new DataTable("hasta");
            tablo1.Columns.Add("adi");
            tablo1.Columns.Add("id");
            tablo1.Rows.Add("ali", 1);
            tablo1.Rows.Add("veli", 2);

            DataTable tablo2 = new DataTable("ilaclar");
            tablo2.Columns.Add("id");
            tablo2.Columns.Add("ilac");
            tablo2.Rows.Add(1, "atenolol");
            tablo2.Rows.Add(2, "amoxicillin");

            // Oluşturulan tabloları datasete(sanal veri tabanı) aktarma  
            DataSet set = new DataSet("office");
            set.Tables.Add(tablo1);
            set.Tables.Add(tablo2);

            
            dg3.Rows.Clear();
            dg3.Columns.Clear();
            dg3.Refresh();
            //dg3.DataSource = set.Tables["ilaclar"];
            dg3.DataSource = set.Tables[0];
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbDataReader dReader;

            string sql1 = "select * from musteri";
            string sql2 = "select ad,soyad from musteri";
            if (tabControl1.SelectedIndex == 1)
            {
                //datareader kullanarak veri çekme işlemi
                if (bag.State != ConnectionState.Open) bag.Open();

                komut.CommandText = sql1;
                komut.Connection = bag;
                dReader= komut.ExecuteReader();

                while (dReader.Read())
                {
                    lbAd.Items.Add(dReader[1].ToString());
                    lbSoyad.Items.Add(dReader["soyad"].ToString());
                }
                bag.Close();

                //dataset kullanımı
                DataSet ds = new DataSet();
                OleDbDataAdapter da;
                DataTable dt = new DataTable("dtMusteri");
                ds.Tables.Add(dt);
                if (bag.State != ConnectionState.Open) bag.Open();
                da = new OleDbDataAdapter(sql2, bag);
                da.Fill(ds.Tables["dtMusteri"]);

                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    dataGridView1.Columns.Add(dt.Columns[i].ColumnName.ToString(), dt.Columns[i].ColumnName.ToString());
                }

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dataGridView1.Rows.Add(dr["ad"], dr["soyad"]);
                }
                bag.Close();

                //Parametre Kullanımı...
                komut.Parameters.Clear();
                DataTable dt1 = new DataTable();
                if (bag.State != ConnectionState.Open) bag.Open();
                komut = new OleDbCommand("Select * from urun where uno = @urunNo", bag);
                komut.Parameters.AddWithValue("@urunNo", textBox1.Text);
                dReader=komut.ExecuteReader();
                dt1.Load(dReader);

                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    comboBox1.Items.Add(dt1.Rows[i]["uadi"]);
                }
                bag.Close();

                tumTabloListele("urun");
            }
        }
        private void tumTabloListele(string v)
        {
            string sqlKomut = "select * from " + v +" order by uno";
            DataTable dt = new DataTable();

            if (bag.State != ConnectionState.Open)
            {
                bag.Open();
            }
            komut.CommandText = sqlKomut;
            komut.Connection = bag;
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            bag.Close();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            komut.Parameters.Clear();
            //string sqlKomut = "INSERT INTO urun (uno, uadi,fiyat,miktar) VALUES (" +
            //txtUrunNo.Text + ",'" + txtUrunAdi.Text + "'," + txtUrunFiyat.Text + ","
            //+ txtUrunMiktar.Text + ");";

            //string sqlKomut = "INSERT INTO urun (uno,uadi,fiyat,miktar) VALUES (?,?,?,?)";
            string sqlKomut = "INSERT INTO urun (uno,uadi,fiyat,miktar) VALUES (@uno,@uadi,@fiyat,@miktar)";
            try
            {
                if (bag.State != ConnectionState.Open)
                {
                    bag.Open();
                }
                komut.CommandText = sqlKomut;
                //komut.Parameters.Add("uno", OleDbType.Integer).Value = Convert.ToInt32(txtUrunNo.Text);
                //komut.Parameters.Add("uadi", OleDbType.VarChar, 25).Value = txtUrunAdi.Text;
                //komut.Parameters.Add("fiyat", OleDbType.Integer).Value = Convert.ToInt32(txtUrunFiyat.Text);
                //komut.Parameters.Add("miktar", OleDbType.Integer).Value = Convert.ToInt32(txtUrunMiktar.Text);

                komut.Parameters.AddWithValue("@uno", Convert.ToInt32(txtUrunNo.Text));
                komut.Parameters.AddWithValue("@uadi", txtUrunAdi.Text.ToString());
                komut.Parameters.AddWithValue("@fiyat", Convert.ToInt32(txtUrunFiyat.Text));
                komut.Parameters.AddWithValue("@miktar", Convert.ToInt32(txtUrunMiktar.Text));

                komut.Connection = bag;
                komut.ExecuteNonQuery();
                tumTabloListele("urun");
                bag.Close();
                MessageBox.Show("1 adet kayıt eklendi..!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                bag.Close();
            }
        }
    }
}
