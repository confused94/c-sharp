using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace caykahve
{
    public partial class Form1 : Form
    {
        Timer timer;
        bool secildi = true;
        string secim = "";
        public Form1()
        {
            InitializeComponent();
            
        }

        private void urun(object sender, EventArgs e)
        {
            Button btn=(Button)sender;
            btn.BackColor = Color.LightGreen;
           if(secildi)
            {
                
                pictureBox2.Visible = true;
                pictureBox3.Visible = false;
                //switch (btn.Text)
                //{
                //    case "ÇAY":secim=btn.Text;break;
                //    case "KAHVE":secim = btn.Text; break;
                //}
                secildi = false;    
            }
                
            if (secildi == false)
                { if (progressBar1.Value == 0) { label2.Text = "Your coffee is being prepared"; }
                     label2.Visible = true;
                     //progressBar2.Visible= true;
                     timer=new Timer();
                     timer.Interval = 50;
                     timer.Tick += timer1_Tick;
                     timer.Start();
                }  
                
         
            //label1.Visible = true;
            //progressBar1.Visible = true;
            //button4.Visible = true;
            //button3.Visible = true;

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar2.Value == 100)
            {
                timer.Stop();
                label2.Text = "Your coffee is ready";
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
                //if (secim == "ÇAY") { pictureBox1.Visible = true; label2.Text = "ÇAYINIZ HAZIR"; }
                //else if(secim=="KAHVE") { pictureBox2.Visible= true; label2.Text = "KAHVENİZ HAZIR"; }

            }
            if (progressBar2.Value < 100) { progressBar2.Value += 1; }
        }
            private void artazalt(object sender, EventArgs e)
            {
           
                  Button btn = (Button)sender;
                  if (btn.Text == "+" && progressBar1.Value < 10)
                     {
                       progressBar1.Value += 1;
                     }
                  if(btn.Text=="-"&&progressBar1.Value > 0)
                     {
                       progressBar1.Value -= 1;
                     }
            


            
                
            }

        

           
        
       
                                           
        
                   
    }
            
}
                    



             

            

