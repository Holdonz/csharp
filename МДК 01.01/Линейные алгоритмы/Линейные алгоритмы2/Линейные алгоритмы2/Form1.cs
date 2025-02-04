using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Линейные_алгоритмы2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void True(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            textBox4.Text += Environment.NewLine + "A = " + a.ToString();

            double b = double.Parse(textBox2.Text);
            textBox4.Text += Environment.NewLine + "B = " + b.ToString();

            double x = double.Parse(textBox3.Text);
            textBox4.Text += Environment.NewLine + "X = " + x.ToString();

            double q = a * x - Math.Sqrt(b);
            double w = 5.7 * (x * x + b * b);
            double r = Math.Abs(x + b) - (a * a);
            double p = x * x;
            double t = Math.Pow(Math.Tan(b), 2);

            double y = (a / w) - (r  / p) * t;

            textBox4.Text += Environment.NewLine + "Результат: Y = " + y.ToString();
            textBox4.Text += Environment.NewLine + "";
        }
    }
}
