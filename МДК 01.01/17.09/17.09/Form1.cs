using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17._09
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
            var Form1 = new Form2();
            Form1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var Form1 = new Form3();
            Form1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var Form1 = new Form4();
            Form1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var Form1 = new Form5();
            Form1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var Form1 = new Form6();
            Form1.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var Form1 = new Form7();
            Form1.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var Form1 = new Form8();
            Form1.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var Form1 = new Form9();
            Form1.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var Form1 = new Form10();
            Form1.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var Form1 = new Form12();
            Form1.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var Form1 = new Form13();
            Form1.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            var Form1 = new Form14();
            Form1.Show();
        }
    }
}
        