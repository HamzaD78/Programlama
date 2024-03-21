using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uyg_10_Class
{
    class deneme
    {
        private int _kapiSayisi;
        private int _model;
        private string _renk;

        public int getKapi()
        {
            return _kapiSayisi;
        }

        public void setKapi(int deger)
        {
            _kapiSayisi= deger;
        }

        public deneme()
        {
            MessageBox.Show("sınıf üretildi");
        }

        public deneme(int a, int b, string c)
        {
            this._kapiSayisi = a;
            this._model = b;
            this._renk = c;
        }

        public override string ToString()
        {
            string a="Arabam " + this._renk + " rengindedir, modeli" +
                this._model + "dir ve kapi sayisi " + this._kapiSayisi ;
            return a;
        }

        ~deneme() //destructors
        {
            MessageBox.Show("Class işlemini tamamladı");
        }
    }
}
