using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace uyg_08_VeriTabanı_01
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
        

        private void Form1_Load(object sender, EventArgs e)
        {
            tumTabloListele("urun");      
        }

        private void tumTabloListele(string v)
        {
            string sqlKomut = "select * from " + v;
            DataTable dt = new DataTable();

            if (bag.State != ConnectionState.Open)
            {
                bag.Open();
            }
            komut.CommandText = sqlKomut;
            komut.Connection = bag;
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bag.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bag.Open();
            MessageBox.Show(bag.State.ToString());
            bag.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sqlKomut = "INSERT INTO urun (uno, uadi,fiyat,miktar) VALUES (" +
                txtUrunNo.Text+",'"+txtUrunAdi.Text+"',"+ txtUrunFiyat.Text + ","
                + txtUrunMiktar.Text + ");";
            try
            {
                if (bag.State != ConnectionState.Open)
                {
                    bag.Open();
                }
                komut.CommandText = sqlKomut;
                komut.Connection = bag;
                komut.ExecuteNonQuery();
                tumTabloListele("urun");
                bag.Close();
                MessageBox.Show("Yeni kayıt eklendi..!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                bag.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sqlKomut = "update urun set uno ="+ txtUrunNo.Text
                + ", uadi='" + txtUrunAdi.Text + "',fiyat=" + txtUrunFiyat.Text +
                ", miktar=" + txtUrunMiktar.Text + " where uno="+txtUrunNo.Text;
            try
            {
                if (bag.State!=ConnectionState.Open) bag.Open();
                komut = new OleDbCommand(sqlKomut, bag);
                komut.ExecuteNonQuery();
                tumTabloListele("urun");
                MessageBox.Show("Veri Güncellemesi Yapıldı");
                bag.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                bag.Close();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sqlKomut = "Delete From urun where uno="+txtUrunNo.Text+";";
            try
            {
                DialogResult dg =MessageBox.Show("Kayıt Silinsin mi?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dg == DialogResult.Yes)
                {
                    if (bag.State != ConnectionState.Open) bag.Open();
                    komut = new OleDbCommand(sqlKomut, bag);
                    komut.ExecuteNonQuery();
                    tumTabloListele("urun");
                    MessageBox.Show("Silme İşlemi Gerçekleştirildi");
                    bag.Close(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                bag.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                //dataGridView1.CurrentRow.Selected = true;
                txtUrunNo.Text = dataGridView1.Rows[e.RowIndex].Cells["uno"].FormattedValue.ToString();
                txtUrunAdi.Text = dataGridView1.Rows[e.RowIndex].Cells["uadi"].FormattedValue.ToString();
                txtUrunFiyat.Text = dataGridView1.Rows[e.RowIndex].Cells["fiyat"].FormattedValue.ToString();
                txtUrunMiktar.Text = dataGridView1.Rows[e.RowIndex].Cells["miktar"].FormattedValue.ToString();
            }
        }
    }
}
