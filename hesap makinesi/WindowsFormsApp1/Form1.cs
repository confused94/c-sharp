using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double sonuc = 0;
        bool operatordurum = true;
        string eskiopt = "";
        string eskitextbox = "";


        public Form1()
        {
            InitializeComponent(); 
           
        }
         
        
         

        

        private void rakambuton(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || operatordurum)
            {
                textBox1.Clear();
            }
            operatordurum = false;
            Button btn = (Button)sender;
            textBox1.Text += btn.Text;
             eskitextbox= textBox1.Text;
            


        }

        private void islem(object sender, EventArgs e)
        {
            Button btn=(Button)sender;
            
            operatordurum = true;
            string yeniopt = btn.Text;
             label1.Text += eskitextbox + yeniopt;
            switch (eskiopt)
            {
                case "*": textBox1.Text = (sonuc*Double.Parse(textBox1.Text)).ToString(); break;
                case "/": textBox1.Text = (sonuc / Double.Parse(textBox1.Text)).ToString(); break;
                case "-": textBox1.Text = (sonuc - Double.Parse(textBox1.Text)).ToString(); break;
                case "+": textBox1.Text = (sonuc + Double.Parse(textBox1.Text)).ToString(); break;

            }
            eskiopt = yeniopt;
            sonuc = Double.Parse(textBox1.Text);
            textBox1.Text = sonuc.ToString();
           
            
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label1.Text = "";
            eskiopt = "";

        }

        private void button15_Click(object sender, EventArgs e)
        {
            
            operatordurum = true;
            string label = label1.Text;
            label1.Text = "";

            
            switch (eskiopt)
            {
                case "*": textBox1.Text = (sonuc * Double.Parse(textBox1.Text)).ToString(); break;
                case "/": textBox1.Text = (sonuc / Double.Parse(textBox1.Text)).ToString(); break;
                case "-": textBox1.Text = (sonuc - Double.Parse(textBox1.Text)).ToString(); break;
                case "+": textBox1.Text = (sonuc + Double.Parse(textBox1.Text)).ToString(); break;

            }
            
            eskiopt = "";
            sonuc = Double.Parse(textBox1.Text);
            textBox1.Text = sonuc.ToString();
            label1.Text = label + eskitextbox+ "=";

        }
    }
}
