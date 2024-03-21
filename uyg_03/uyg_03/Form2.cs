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
    public partial class Form2 : Form
    {
        public int start, end;
        public Form2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.AcceptButton = button2;
            this.CancelButton = button1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                start = Convert.ToInt32(txtStart.Text);
                end = Convert.ToInt32(txtEnd.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            start = -1;
            end = -1;
        }

    }
}
