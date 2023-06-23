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
    public partial class saliselisayac : Form
    {
        public saliselisayac()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 1;

        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.Minute.ToString();
            label5.Text = DateTime.Now.Second.ToString();
            label6.Text = DateTime.Now.Millisecond.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
