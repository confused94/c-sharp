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


namespace sayı_tahmin
{
    
    public partial class Form1 : Form
    {
        string[] lotoSayi;
        string[] girilenSayi;
        Label[] labelsayi;
        int sayac = 0;


        int i=0;
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            
          
        }

        private void button1_Click(object sender, EventArgs e)

        {
            

            lotoSayi=new string[6];
            girilenSayi=new string[] { textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text };
            labelsayi=new Label[] { label1, label2, label3, label4, label5, label6 };
            for(int k = 0; k < lotoSayi.Length;k++)
            {

                lotoSayi[k] = random.Next(1, 10).ToString();
            }
            timer1.Start();
          




        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if(i<6)
            {
                
                timer1.Interval = 2000;
                
                labelsayi[i].Text = lotoSayi[i];
                if (girilenSayi.Contains(lotoSayi[i])){
                    sayac++;
                    label7.Text=sayac.ToString();
                }
                    
                
                i++;

            }
            else
            {
                timer1.Stop();
                if(sayac >= 3)
                {
                    pictureBox7.Visible=true;
                }
            }


        }
    }
}
            

            
            
            

            

            


