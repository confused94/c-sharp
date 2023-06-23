using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gectikaldı
{
    public partial class Form1 : Form
    {
        bool gectikaldı = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Label l1=new Label();
            
            l1.Visible = false;




            if (textBox1.Text!=""&&textBox2.Text!=""&&textBox3.Text!=""&&comboBox1!=null&&textBox4.Text!="")
            {
                if (Int16.Parse(textBox4.Text) > 60)
                {
                    
                    l1.Text = "GEÇTİ";
                   
                }
                else
                {
                    
                    l1.Text = "KALDI";
                    
                }
                l1.Visible=true;
                ogrenci ogrenci = new ogrenci();ogrenci.ogrenciekle(textBox1.Text, textBox2.Text, textBox3.Text, comboBox1.Text, Int16.Parse(textBox4.Text));
                listBox1.Items.Add(ogrenci.getOkul + " " + ogrenci.getAd + " " + ogrenci.getsoyad + " "
                + ogrenci.getSinif + " " + ogrenci.getNot+" "+l1.Text);
                
            }
            else
            {
                MessageBox.Show("Boş Alanları doldurunuz","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
            
          
            
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            comboBox1.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
          
            List<ogrenci> list = new List<ogrenci>();
            list.Add(new ogrenci()
           



        }
    }
}
