using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17._09
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            double y = double.Parse(textBox2.Text);
            double z = double.Parse(textBox3.Text);

            double f;

            if (radioButton1.Checked)
            {
                f = Math.Sinh(x);
            }
            else if (radioButton2.Checked)
            {
                f = Math.Pow(x, 2);
            }
            else if (radioButton3.Checked)
            {
                f = Math.Exp(x);
            }
            else { return; }

            double a = Math.Min(f*(x) - y, y - z);
            double b = Math.Max(f * (x), y);

            double n = a / b;
            textBox4.Text = "n = " + n.ToString() + Environment.NewLine;
            textBox4.Text += "X = " + x.ToString() + Environment.NewLine;
            textBox4.Text += "Y = " + y.ToString() + Environment.NewLine;
            textBox4.Text += "Z = " + z.ToString() + Environment.NewLine;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Text = String.Empty;
        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }
    }
}
