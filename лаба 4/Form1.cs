using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лаба_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // считывание начальных данных
            double x0 = Convert.ToDouble(textBox1.Text);
            double xk = Convert.ToDouble(textBox2.Text);
            double dx = Convert.ToDouble(textBox3.Text);
            double a = Convert.ToDouble(textBox4.Text);
            double b = Convert.ToDouble(textBox5.Text);

            textBox6.Text = "Результат" + Environment.NewLine;

            //цикл для табулирования функции 
            double x = x0;
            while (x <= (xk+dx/2))
            {
                double y = Math.Pow(10,-1) * a * Math.Pow(x,3) * Math.Tan(a - b * x);
                textBox6.Text += "x = " + Convert.ToString(x) +
                                 "; y = " + Convert.ToString(y) + Environment.NewLine;
                x = x + dx;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
