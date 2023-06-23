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
    

    public partial class derece : Form
    {
        private float fahrenheit;
        private float celcius;
        public derece()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty&&textBox2.Text!=string.Empty)
            {
                celcius = (Int16.Parse(textBox2.Text)-32)/1.8000f;
                textBox1.Text=celcius.ToString();
                celcius = 0;
            }
            else if (textBox1.Text != string.Empty && textBox2.Text == string.Empty)
            {
                fahrenheit=Int16.Parse(textBox1.Text)*1.8f+32;
                textBox2.Text=fahrenheit.ToString();
                fahrenheit = 0;
            }
            else
            {
                MessageBox.Show("Lütfen açıklamayı okuyun");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text= string.Empty;
            textBox2.Text = string.Empty;
        }
    }
}
