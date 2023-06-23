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
    public partial class Form1 : Form
    {
        private int toplam;
        private int ort;
        private int kontrolsayi;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(int.TryParse(textBox1.Text ,out kontrolsayi)&&int.TryParse(textBox2.Text,out kontrolsayi)&& int.TryParse(textBox3.Text, out kontrolsayi)) 
            {
                
                toplam=Convert.ToInt16(textBox1.Text)+Convert.ToInt16(textBox2.Text)+Convert.ToInt16(textBox3.Text);
                ort = toplam / 3;
                label5.Text= ort.ToString();
            
            
            
            }
            else
            {
                MessageBox.Show("Lütfen sadece sayı giriniz!!","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }


            
        }
    }
}
