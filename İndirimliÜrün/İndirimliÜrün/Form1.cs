using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İndirimliÜrün
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double etiketfiyat, indirim, sonfiyat;
            etiketfiyat = Convert.ToDouble(textBox1.Text);
            indirim=etiketfiyat*0.10;
            sonfiyat = etiketfiyat - indirim;
            label3.Text = indirim.ToString();
            label4.Text = sonfiyat.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double etiketfiyat, indirim, sonfiyat;
            etiketfiyat = Convert.ToDouble(textBox1.Text);
            indirim = etiketfiyat * 0.25;
            sonfiyat = etiketfiyat - indirim;
            label3.Text = indirim.ToString();
            label4.Text = sonfiyat.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double etiketfiyat, indirim, sonfiyat;
            etiketfiyat = Convert.ToDouble(textBox1.Text);
            indirim = etiketfiyat * 0.50;
            sonfiyat = etiketfiyat - indirim;
            label3.Text = indirim.ToString();
            label4.Text = sonfiyat.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double etiketfiyat, indirim, sonfiyat;
            etiketfiyat = Convert.ToDouble(textBox1.Text);
            indirim = etiketfiyat * 0.75;
            sonfiyat = etiketfiyat - indirim;
            label3.Text = indirim.ToString();
            label4.Text = sonfiyat.ToString();
        }
    }
}
