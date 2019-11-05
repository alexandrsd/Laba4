using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double y;
            double x = Convert.ToDouble(textBox1.Text);
            y = (2 * x - 7) / (Math.Sqrt(3 * x + 21));
            label1.Text = Convert.ToString(y);

            double q;
            double w = Convert.ToDouble(textBox2.Text);
            q = Math.Sqrt(w / (w - 1));
            label2.Text = Convert.ToString(q);

            double r;
            double t = Convert.ToDouble(textBox3.Text);
            r = ((t + 1) / (t - 1)) + Math.Sqrt(t * t);
            label3.Text = Convert.ToString(r);

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double u, o, p;
            double i = Convert.ToDouble(textBox4.Text);
            u = (2 * i - 7) / (Math.Sqrt(3 * i + 21));
            o = Math.Sqrt(i / (i - 1));
            p = ((i + 1) / (i - 1)) + Math.Sqrt(i * i);
            label1.Text = Convert.ToString(u);
            label2.Text = Convert.ToString(o);
            label3.Text = Convert.ToString(p);
        }
    }
}
