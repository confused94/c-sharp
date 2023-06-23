using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gectikaldı
{
    
    internal class ogrenci
    {
        
   
        private string okul;
        private string ad;
        private string soyad;
        private string sinif;
        private int not;
        

        internal void ogrenciekle(string okul, string ad, string soyad, string sinif, int not)
        {
            

            this.ad = ad;
            this.soyad = soyad;
            this.okul = okul;
            this.sinif = sinif;
            this.not = not;


            

        }

        public string getAd { get { return this.ad; } }
        public string getsoyad { get { return this.soyad; } }
        public string getOkul{ get { return this.okul; }}
        public string getSinif{get { return this.sinif; }}
        public int getNot{get{return this.not;}}
    }
}




























