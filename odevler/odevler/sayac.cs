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
    public partial class sayac : Form
    {
        private int sayi = 10;
        private bool kontrol = false;
        public sayac()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 1000;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayi--;
            label1.Text= sayi.ToString();
            if (sayi == 0) { timer1.Stop(); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!kontrol)
            {
                timer1.Stop();
                kontrol = true;
            }
            else if (kontrol)
            {
                timer1.Start();
                kontrol = false;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sayi = 10;
            timer1.Start();

        }
    }
}
