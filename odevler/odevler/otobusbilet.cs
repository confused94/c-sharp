using Microsoft.SqlServer.Server;
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
    public partial class otobusbilet : Form
    {
        private string tarih;
        private string varis;
        private string saat;
        private string koltuk;
        public otobusbilet()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            tarih=dateTimePicker1.Value.ToString();
            varis=comboBox1.Text.ToString();
            saat=comboBox2.Text.ToString();
            koltuk=comboBox3.Text.ToString();
            Label secim = Controls.Find("Label" + koltuk, true).FirstOrDefault() as Label;
            secim.BackColor = Color.Red;
            Console.WriteLine();

            MessageBox.Show(string.Format("{0} tarihli {1} iline {2} saat için biletiniz alınmıştır hayırlı yolculuklar dilerim",tarih,varis,saat));
            





        }
    }
}
