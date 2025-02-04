using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label5.Text = "Начало работы";
            BackColor = Color.LightCoral;
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            BackColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BackColor = Color.Yellow;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            BackColor = Color.Green;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = "Привет";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = "Досвидания";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label2.Text = textBox1.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label3.Text = textBox2.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label4.Text = textBox3.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.Text = textBox4.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.Text = textBox4.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.Text = textBox4.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label6.BackColor = Color.Red;
            label7.BackColor = Color.Blue;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            label6.BackColor = Color.Yellow;
            label7.BackColor = Color.Green;
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            label6.BackColor= Color.White;
            label7.BackColor = Color.White;
        }
    }
}
