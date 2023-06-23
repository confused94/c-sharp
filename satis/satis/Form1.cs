using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace satis
{
    public partial class Form1 : Form
    {
        float mısır = 20f;
        float cay = 10f;
        float su = 5f;
        float bilet = 50f;
        double indirim = 0;
        float indirimTutari=0;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            indirim = 0;
           label13.Text=hesapla().ToString()+"TL";
            label14.Text = "Mısır:" +mısır+ "*" + numericmısır.Value+" "+"Adet";
            label15.Text = "Çay:" +cay+ "*" + numericcay.Value + " " + "Adet";
            label16.Text = "Su:" +su+ "*" + numericsu.Value + " " + "Adet";
            label17.Text = "Bilet:" +bilet+ "*" + numericbilet.Value + " " + "Adet";
            label18.Text = indirimTutari+"TL"+" "+ "İndirim Uygulanmıştır";
            label13.Visible = true; label14.Visible=true; label15.Visible=true; label16.Visible=true;
            label17.Visible=true;label18.Visible=true;


        }

        private float hesapla()
        {
            if (numericbilet.Value >= 2)
            {
                float biletadet = (float)numericbilet.Value;
                indirim = Math.Floor(biletadet / 2f);
            }
            indirimTutari = ((float)numericmısır.Value*mısır)-((float)numericmısır.Value - (float)indirim) * mısır;
            float hesap=((float)numericmısır.Value-(float)indirim)*mısır+cay*(float)numericcay.Value+
                su* (float)numericsu.Value+bilet* (float)numericbilet.Value;
            return hesap;
        }
       

    }
}
