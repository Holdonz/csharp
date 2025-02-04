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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            textBox1.Text = "1";
            textBox2.Text = "2,2";
            textBox3.Text = "0,2";
            textBox4.Text = "3,2";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x0 = Convert.ToDouble(textBox1.Text);
            double xk = Convert.ToDouble(textBox2.Text);
            double dx = Convert.ToDouble(textBox3.Text);
            double b = Convert.ToDouble(textBox4.Text);
            textBox5.Text = "Работу выполнил Горин" + Environment.NewLine + Environment.NewLine;
            
            double x = x0;
            while (x <= xk)
            {
                double y = 9 * (Math.Pow(x, 3) + Math.Pow(b,3)) * Math.Tan(x);
                textBox5.Text += "x=" + Convert.ToString(x) + "; y=" + Convert.ToString(y) + Environment.NewLine ;
                x = x + dx;
            }
        }
    }
}
