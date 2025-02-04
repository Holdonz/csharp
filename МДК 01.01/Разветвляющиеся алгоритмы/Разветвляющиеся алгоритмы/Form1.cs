using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Разветвляющиеся_алгоритмы
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radioButton1.Checked = true;
        }

        private void True(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            textBox3.Text += "При X =  " + x + 
                Environment.NewLine; 

            double y = double.Parse(textBox2.Text);
            textBox3.Text += "При Y =  " + y + 
                Environment.NewLine;

            double c;
            if (radioButton1.Checked)
            {
                if (x - y == 0)
                {
                    c = Math.Sin(Math.Sinh(x)) + Math.Cos(Math.Cosh(y));
                    textBox3.Text += "X - Y = 0" + 
                        Environment.NewLine;
                    textBox3.Text += "C = " + c +
                       Environment.NewLine;
                }
                else if (x - y > 0)
                {
                    c = Math.Tan(Math.Tanh(x + y));
                    textBox3.Text += "X - Y > 0" +
                        Environment.NewLine;
                    textBox3.Text += "C = " + c +
                       Environment.NewLine;
                }
                else if (x - y < 0)
                {
                    c = (Math.Sin(Math.Sign(x)) * Math.Sin(Math.Sign(x))) + (Math.Cos(Math.Cosh(y)) * Math.Cos(Math.Cosh(y)));
                    textBox3.Text += "X - Y < 0" +
                        Environment.NewLine;
                    textBox3.Text += "C = " + c +
                       Environment.NewLine;
                }
            }
            else if (radioButton2.Checked)
            {
                if (x - y == 0)
                {
                    c = Math.Sin(x * x) + Math.Cos(y * y);
                    textBox3.Text += "X - Y = 0" +
                        Environment.NewLine;
                    textBox3.Text += "C = " + c +
                       Environment.NewLine;
                }
                else if (x - y > 0)
                {
                    c = Math.Tan((x * x) + (y * y));
                    textBox3.Text += "X - Y > 0" +
                        Environment.NewLine;
                    textBox3.Text += "C = " + c +
                       Environment.NewLine;
                }
                else if (x - y < 0)
                {
                    c = Math.Pow(Math.Sin(x * x), 2) + Math.Pow(Math.Cos(y * y), 2);
                    textBox3.Text += "X - Y < 0" +
                        Environment.NewLine;
                    textBox3.Text += "C = " + c +
                       Environment.NewLine;
                }
            }
            else if (radioButton3.Checked) 
            {
                if (x - y == 0)
                {
                    c = Math.Sin(Math.Exp(x)) + Math.Cos(Math.Exp(y));
                    textBox3.Text += "X - Y = 0" +
                        Environment.NewLine;
                    textBox3.Text += "C = " + c +
                        Environment.NewLine;
                }
                else if (x - y > 0)
                {
                    c = Math.Tan(Math.Exp(x) + Math.Exp(y));
                    textBox3.Text += "X - Y > 0" +
                        Environment.NewLine;
                    textBox3.Text += "C = " + c +
                         Environment.NewLine;
                }
                else if (x - y < 0)
                {
                    c = Math.Pow(Math.Sin(Math.Exp(x)), 2) + Math.Pow(Math.Exp(y), 2);
                    textBox3.Text += "X - Y < 0" +
                        Environment.NewLine;
                    textBox3.Text += "C = " + c +
                        Environment.NewLine;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}
