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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            textBox1.Text = "3,251";
            textBox2.Text = "0,325";
            textBox3.Text = "0,466e-4";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            textBox4.Text = Environment.NewLine + "X = " + x.ToString();

            double y = double.Parse(textBox2.Text);
            textBox4.Text += Environment.NewLine + "Y = " + y.ToString();

            double z = double.Parse(textBox3.Text);
            textBox4.Text += Environment.NewLine + "Z = " + z.ToString();


            double a = Math.Pow(2, Math.Pow(y, x));
            double b = Math.Pow(Math.Pow(3, x), y);
            double c2 = y * (Math.Atan(z)-(Math.PI/6));
            double d = Math.Abs(x) + (1/(Math.Pow(y,2)+1));

            double c = a + b - (c2 / d);
            textBox4.Text += Environment.NewLine + "Результат C = " + c.ToString();

        }
    }
}
