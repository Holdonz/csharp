using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            BackColor = Color.Thistle;
            textBox1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            BackColor = Color.LightCyan;
            textBox1.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = "1";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = "1";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = "МИНА!";
            button6.BackColor = Color.Red;
            MessageBox.Show("Нажмите «Повторить»", "Вы проиграли!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = "2";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = "1";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = "МИНА!";
            button9.BackColor = Color.Red;
            MessageBox.Show("Нажмите «Повторить»", "Вы проиграли!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.Text = "3";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.Text = "МИНА!";
            button11.BackColor = Color.Red;
            MessageBox.Show("Нажмите «Повторить»", "Вы проиграли!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.Text = "3";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.Text = "1";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            button17.Text = "МИНА!";
            button17.BackColor = Color.Red;
            MessageBox.Show("Нажмите «Повторить»", "Вы проиграли!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            button19.Text = "2";
        }

        private void button26_Click(object sender, EventArgs e)
        {
            button26.Text = "МИНА!";
            button26.BackColor = Color.Red;
            MessageBox.Show("Нажмите «Повторить»", "Вы проиграли!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            button20.Text = "МИНА!";
            button20.BackColor = Color.Red;
            MessageBox.Show("Нажмите «Повторить»", "Вы проиграли!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            button23.Text = "МИНА!";
            button23.BackColor = Color.Red;
            MessageBox.Show("Нажмите «Повторить»", "Вы проиграли!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.Text = "2";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button16.Text = "3";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.Text = "3";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            button18.Text = "1";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            button24.Text = "2";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            button25.Text = "2";
        }

        private void button27_Click(object sender, EventArgs e)
        {
            button27.Text = "1";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            button22.Text = "2";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            button21.Text = "3";
        }

        private void button28_Click(object sender, EventArgs e)
        {
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button10.Text = "";
            button11.Text = "";
            button12.Text = "";
            button13.Text = "";
            button14.Text = "";
            button15.Text = "";
            button16.Text = "";
            button17.Text = "";
            button18.Text = "";
            button19.Text = "";
            button19.Text = "";
            button20.Text = "";
            button21.Text = "";
            button22.Text = "";
            button23.Text = "";
            button24.Text = "";
            button25.Text = "";
            button26.Text = "";
            button27.Text = "";
            button6.BackColor = Color.Gainsboro;
            button9.BackColor = Color.Gainsboro;
            button11.BackColor = Color.Gainsboro;
            button17.BackColor = Color.Gainsboro;
            button20.BackColor = Color.Gainsboro;
            button23.BackColor = Color.Gainsboro;
            button26.BackColor = Color.Gainsboro;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            button30.Size = new System.Drawing.Size(100, 40);
            button30.Location = new Point(154, 162);
            button31.Location = new Point(154, 240);
            button32.Location = new Point(154, 100);
            button29.Location = new Point(154, 265);
            button29.Size = new Size(90, 100);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            button29.Location = new Point(38, 160);
            button31.Location = new Point(38, 294);
            button31.Size = new Size(200, 25);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            button32.Size = new Size(50, 50);
            button32.Location = new Point(190, 220);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            button29.Size = new Size(78, 25);
            button29.Location = new Point(38, 177);
            button30.Size = new Size(78, 25);
            button30.Location = new Point(38, 228);
            button32.Size = new Size(78, 25);
            button32.Location = new Point(38, 285);
            button31.Size = new Size(78, 25);
            button31.Location = new Point(38, 135);
        }
    }
}
