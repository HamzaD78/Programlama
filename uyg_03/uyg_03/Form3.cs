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
    public partial class Form3 : Form
    {
        public string yeniMetin;
        public Form3()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.AcceptButton = btnTamam;
            this.CancelButton = btnIptal;
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            if (txtMetin.Text != string.Empty)
            {
                yeniMetin = txtMetin.Text;
            }
        }
    }
}
