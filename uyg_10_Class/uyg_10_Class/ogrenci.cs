using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uyg_10_Class
{
    class ogrenci
    {
        public int ogrNo;
        public string Ad;
        public string Soyad;
        //public int donem;
        //public int donem { get; set; }//autoproperties
        private int _donem;

        public ogrenci()
        {
            MessageBox.Show("Sınıf türetildi");
        }

        public ogrenci(int a, string b, string c, int d)
        {
            this.ogrNo = a;
            this.Ad = b;
            this.Soyad = c;
            this._donem = d;
        }

        public int Donem
        {
            get { return ++_donem; }
            set
            {
                if (value <0)
                {
                    _donem = 1;
                }else
                _donem = value; }
        }

        //public int getDonem()
        //{
        //    return ++_donem;
        //}

        //public void setDonem(int a)
        //{
        //    if (a<0)
        //    {
        //        _donem = 1;
        //    }else _donem = a;
        //}
                
        public override string ToString()
        {
            string a;
            a = "Ogr. Adı = " + this.Ad + ", Soyadı= " + this.Soyad +
                " numarası = " + this.ogrNo.ToString() + " donemı =" + this._donem.ToString();
            return a;
        }
    }
}
