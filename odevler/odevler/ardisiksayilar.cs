using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odevler
{
    public partial class ardisiksayilar : Form
    {
        
        int y = 1;
        int x = 1;
        public ardisiksayilar()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            for(int i=0; i<100; i++)
            {
                
                x++;
                if (i%7==0)
                {
                    x = 1;
                    y++;
                }   
             Label label = new Label();
             label.Text = i.ToString();
             label.Location = new Point(x * 100, y*100);
             label.ForeColor = Color.Red;
             this.Controls.Add(label);
             await Task.Delay(500);


            }
        }
    }
}
