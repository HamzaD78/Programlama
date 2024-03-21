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

namespace uyg_02
{
    public partial class Form1 : Form
    {
        public object Aplication { get; private set; }

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(btnMain.Location.Y.ToString());
            if (btnMain.Location.Y >=10)
            {
                btnMain.Location = new Point(btnMain.Location.X, btnMain.Location.Y-10);
            }
            else
            {
                btnMain.Location = new Point(btnMain.Location.X, 0);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            btnMain.Location = new Point(btnMain.Location.X, btnMain.Location.Y + 10);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            btnMain.Location = new Point(btnMain.Location.X-10, btnMain.Location.Y);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btnMain.Location = new Point(btnMain.Location.X + 10, btnMain.Location.Y);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i==0)
                    {
                        Thread.Sleep(1000);
                        btnMain.Location = new Point(btnMain.Location.X, btnMain.Location.Y - 10);
                        Application.DoEvents();
                    }
                    else if (i==1)
                    {
                        Thread.Sleep(1000);
                        btnMain.Location = new Point(btnMain.Location.X + 10, btnMain.Location.Y);
                        //Application.DoEvents();
                    }
                    else if (i==2)
                    {
                        Thread.Sleep(1000);
                        btnMain.Location = new Point(btnMain.Location.X, btnMain.Location.Y + 10);
                    }
                    else
                    {
                        Thread.Sleep(1000);
                        btnMain.Location = new Point(btnMain.Location.X - 10, btnMain.Location.Y);
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            btn1.ImageList = btn2.ImageList = btn3.ImageList = ımageList1;
            btn1.ImageIndex = 0;
            btn2.ImageIndex = 2;
            btn3.ImageIndex = 4;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            btn1.Size = new Size(120, 120);
            btn2.Size = new Size(120, 120);
            btn3.Size = new Size(120, 120);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            btn1.TextAlign = ContentAlignment.TopLeft;
            btn2.TextAlign = ContentAlignment.MiddleCenter;
            btn3.TextAlign = ContentAlignment.BottomRight;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            btn1.TextImageRelation = TextImageRelation.ImageAboveText;
            btn2.TextImageRelation = TextImageRelation.TextAboveImage;
            btn3.TextImageRelation = TextImageRelation.TextBeforeImage;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            btn1.ImageAlign = ContentAlignment.BottomLeft;
            btn2.ImageAlign = ContentAlignment.MiddleRight;
            btn3.ImageAlign = ContentAlignment.TopRight;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button11.PerformClick();
        }
    }
}
