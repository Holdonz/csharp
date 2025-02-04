using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "******";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.AliceBlue;
            textBox1.Text = "++++++";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            button4.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {

            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button7.Visible = false;
            button4.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button5.Visible = false;
            button3.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Visible = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            button11.Visible = true;
            button12.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            button10.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            button9.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            button11.Visible = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            label1.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.Enabled = false;
            button14.Text = "Не активна";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.Enabled = false;
            button15.Text = "Не активна";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button16.Enabled = false;
            button16.Text = "Не активна";
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            button14.Enabled = true;
            button14.Text = "Активна";
            button15.Enabled = true;
            button15.Text = "Активна";
            button16.Enabled = true;
            button16.Text = "Активна";
        }

        private void button17_Click(object sender, EventArgs e)
        {
           label5.Text = textBox2.Text;

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            label5.Text = "Начало работы";
            BackColor = Color.LightBlue;
            textBox2.Clear();
        }
    }
}
