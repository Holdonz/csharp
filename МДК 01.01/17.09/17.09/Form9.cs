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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Size = new Size(200,200);
            button2.Location = new Point(250,250);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button3.Size = new Size(300, 100);
            button3.Location = new Point(500, 200);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button4.Size = new Size(100, 300);
            button4.Location = new Point(200, 500);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Size = new Size(300, 100);
            button1.Location = new Point(500, 400);
        }
    }
}
