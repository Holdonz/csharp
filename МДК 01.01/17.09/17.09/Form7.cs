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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Enabled=true;
        }

        private void Form7_Click(object sender, EventArgs e)
        {
            BackColor = Color.LightCoral;
            button1.Visible = false;
            button2.Visible = false;
            textBox1.Visible = false;
        }
    }
}
