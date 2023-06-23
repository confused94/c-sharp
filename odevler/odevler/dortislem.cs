using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odevler
{
    public partial class dortislem : Form
    {
        private int sayi1;
        private int sayi2;
        private int sonuc;
        public dortislem()
        {
            InitializeComponent();
        }

        private void islem(object sender, EventArgs e)
        {
            sayi1 = Int16.Parse(textBox1.Text);
            sayi2 = Int16.Parse(textBox2.Text);
            
            RadioButton radio=sender as RadioButton;
            if (radio.Tag == "topla")
            {
                sonuc = sayi1 + sayi2;
                textBox3.Text=sonuc.ToString();
            }
            else if(radio.Tag == "cikar")
            {
                
                    sonuc = sayi1 - sayi2;
                    textBox3.Text = sonuc.ToString();
                
            }
            else if (radio.Tag == "bol")
            {

                sonuc = sayi1 / sayi2;
                textBox3.Text = sonuc.ToString();

            }
            else if (radio.Tag == "carp")
            {

                sonuc = sayi1 * sayi2;
                textBox3.Text = sonuc.ToString();

            }
        }
    }
}
