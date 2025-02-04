using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Классы_и_объекты
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Restart();
        }

        private void tabPage1_MouseClick(object sender, MouseEventArgs e)
        {
            Button button = new Button();
            button.Text = $"({e.X}, {e.Y})";
            button.Size = new Size(100, 25);
            button.Location = new Point(e.X, e.Y);
            tabPage1.Controls.Add(button);
        }

        private void splitContainer1_Panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Button button = new Button();
            button.Size = new Size(100, 25);
            button.Location = new Point(e.X, e.Y);
            splitContainer1.Panel1.Controls.Add(button);
        }

        private void splitContainer1_Panel2_MouseClick(object sender, MouseEventArgs e)
        {
            Label label = new Label();
            label.Text = "label";
            label.Location = new Point(e.X, e.Y);
            splitContainer1.Panel2.Controls.Add(label);
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Button button = new Button();
            button.Size = new Size(100, 25);
            button.Location = new Point(e.X, e.Y);
            panel1.Controls.Add(button);
        }

        private void tabPage3_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox textBox = new TextBox();
            textBox.Location = new Point(e.X, e.Y);
            tabPage3.Controls.Add(textBox);

        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            Button button = new Button();
            button.Location = new Point(e.X, e.Y);
            panel3.Controls.Add(button);
        }

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox textBox = new TextBox();
            textBox.Location = new Point(e.X, e.Y);
            panel4.Controls.Add(textBox);
        }

        private void panel4_MouseClick(object sender, MouseEventArgs e)
        {
            Label label = new Label();
            label.Text = "label";
            label.Location = new Point(e.X, e.Y);
            panel2.Controls.Add(label);
        }

        private void tabPage5_MouseClick(object sender, MouseEventArgs e)
        {
            int rows = 7;
            int columns = 7;

            int buttonWidth = 50;
            int buttonHeight = 30;

            int spacing = 10;
            int gridWidth = columns * buttonWidth + (columns - 1) * spacing;
            int gridHeight = rows * buttonHeight + (rows - 1) * spacing;
            int gridX = (ClientSize.Width - gridWidth) / 7;
            int gridY = (ClientSize.Height - gridHeight) / 7;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Button button = new Button();
                    button.Text = $"Button {i + 1},{j + 1}"; button.Width = buttonWidth;
                    button.Height = buttonHeight;
                    button.Location = new Point(gridX + j * (buttonWidth + spacing), gridY + i * (buttonHeight + spacing));
                    tabPage5.Controls.Add(button);
                }
            }
        }

        int controlCounter;
        private void tabPage6_MouseClick(object sender, MouseEventArgs e)
        {
            if (controlCounter % 2 == 0)
            {
                Button button = new Button();
                button.Text = $"Button {controlCounter + 1}";
                button.Location = new Point(e.X, e.Y);
                button.Size = new Size(100, 25);
                tabPage6.Controls.Add(button);
            }
            else
            {
                TextBox textBox = new TextBox();
                textBox.Location = new Point(e.X - 100, e.Y - 20);
                tabPage6.Controls.Add(textBox);
            }
            controlCounter++;
        }


        int buttonCounter;
        int labelCounter;
        int txtCounter;
        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            int p1 = tabPage7.Size.Width;
            int p2 = tabPage7.Size.Height;
            int s1 = button1.Size.Width;
            int s2 = button1.Size.Height;
            Random rnd = new Random();

            button1.Visible = true;
            Button button = new Button();
            button.Text = $"button";
            button.Location = new Point(rnd.Next(p1 - s1), rnd.Next(p2 - s2));
            button.Size = new Size(80, 30);
            tabPage7.Controls.Add(button);
            controlCounter++;
            buttonCounter++;
            label3.Text = $"{buttonCounter}";
            label2.Text = $"{controlCounter}";
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            int p1 = tabPage7.Size.Width;
            int p2 = tabPage7.Size.Height;
            int s1 = label1.Size.Width;
            int s2 = label1.Size.Height;
            Random rnd = new Random();

            button1.Visible = true;
            Label label = new Label();
            label.Text = $"label";
            label.Location = new Point(rnd.Next(p1 - s1), rnd.Next(p2 - s2));
            label.Size = new Size(80, 30);
            tabPage7.Controls.Add(label);
            controlCounter++;
            labelCounter++;
            label2.Text = $"{controlCounter}";
            label4.Text = $"{labelCounter}";
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int p1 = tabPage7.Size.Width;
            int p2 = tabPage7.Size.Height;
            int s1 = textBox1.Size.Width;
            int s2 = textBox1.Size.Height;
            Random rnd = new Random();

            textBox1.Visible = true;
            TextBox txtbox = new TextBox();
            txtbox.Text = $"textBox";
            txtbox.Location = new Point(rnd.Next(p1 - s1), rnd.Next(p2 - s2));
            txtbox.Size = new Size(100, 22);
            tabPage7.Controls.Add(txtbox);
            controlCounter++;
            txtCounter++;
            label5.Text = $"{txtCounter}";
            label2.Text = $"{controlCounter}";
        }

        private Type GetRandomControlType()
        {
            Random random = new Random();
            int controlIndex = random.Next(0, 6);

            switch (controlIndex)
            {
                case 0:
                    return typeof(Button);
                case 1:
                    return typeof(TextBox);
                case 2:
                    return typeof(Label);
                case 3:
                    return typeof(CheckBox);
                case 4:
                    return typeof(RadioButton);
                case 5:
                    return typeof(ComboBox);
                default:
                    return typeof(Button);
            }
        }

        int nButton;
        int nTextBox;
        int nLabel;
        int nCheckBox;
        int nRadioButton;
        int nComboBox;
        private void panel5_MouseClick(object sender, MouseEventArgs e)
        {
            Type controlType = GetRandomControlType();

            Control control = (Control)Activator.CreateInstance(controlType);

            control.Size = new Size(100, 30);
            control.Location = new Point(e.X - control.Width / 2, e.Y - control.Height / 2);
            if (control is Button)
            {
                ((Button)control).Text = $"({e.X}, {e.Y})";
                nButton++;
                label18.Text = $"{nButton}";
            }
            else if (control is TextBox)
            {
                ((TextBox)control).Text = $"({e.X}, {e.Y})";
                nTextBox++;
                label19.Text = $"{nTextBox}";
            }
            else if (control is Label)
            {
                ((Label)control).Text = $"({e.X}, {e.Y})";
                nLabel++;
                label20.Text = $"{nLabel}";
            }
            else if (control is CheckBox)
            {
                ((CheckBox)control).Text = $"({e.X}, {e.Y})";
                nCheckBox++;
                label21.Text = $"{nCheckBox}";
            }
            else if (control is RadioButton)
            {
                ((RadioButton)control).Text = $"({e.X}, {e.Y})";
                nRadioButton++;
                label22.Text = $"{nRadioButton}";
            }
            else if (control is ComboBox)
            {
                ((ComboBox)control).Text = $"({e.X}, {e.Y})";
                nComboBox++;
                label23.Text = $"{nComboBox}";
            }
            panel5.Controls.Add(control);
            controlCounter++;
            label17.Text = $"{controlCounter}";
        }

        private void tabPage8_MouseClick(object sender, MouseEventArgs e)
        {
            Type controlType = GetRandomControlType();

            Control control = (Control)Activator.CreateInstance(controlType);

            control.Size = new Size(100, 30);
            control.Location = new Point(e.X - control.Width / 2, e.Y - control.Height / 2);
            if (control is Button)
            {
                ((Button)control).Text = $"({e.X}, {e.Y})";
                nButton++;
                label18.Text = $"{nButton}";
            }
            else if (control is TextBox)
            {
                ((TextBox)control).Text = $"({e.X}, {e.Y})";
                nTextBox++;
                label19.Text = $"{nTextBox}";
            }
            else if (control is Label)
            {
                ((Label)control).Text = $"({e.X}, {e.Y})";
                nLabel++;
                label20.Text = $"{nLabel}";
            }
            else if (control is CheckBox)
            {
                ((CheckBox)control).Text = $"({e.X}, {e.Y})";
                nCheckBox++;
                label21.Text = $"{nCheckBox}";
            }
            else if (control is RadioButton)
            {
                ((RadioButton)control).Text = $"({e.X}, {e.Y})";
                nRadioButton++;
                label22.Text = $"{nRadioButton}";
            }
            else if (control is ComboBox)
            {
                ((ComboBox)control).Text = $"({e.X}, {e.Y})";
                nComboBox++;
                label23.Text = $"{nComboBox}";
            }
            tabPage8.Controls.Add(control);
            controlCounter++;
            label17.Text = $"{controlCounter}";
        }

        int buttom11 = 0;
        int buttom10 = 0;
        int buttom9 = 0;
        int buttom8 = 0;
        int buttom7 = 0;
        int buttom6 = 0;
        private void tabPage9_MouseClick(object sender, MouseEventArgs e)
        {
            Random random = new Random();
            int controlIndex = random.Next(0, 6);
            Type controlType = GetRandomControlType();
            Control control = (Control)Activator.CreateInstance(controlType);
            control.Size = new Size(100, 30);
            control.Location = new Point(e.X - control.Width / 2, e.Y - control.Height / 2);
            if (control is Button)
            {
                ((Button)control).Text = "Button";
                buttom11++;
                label30.Text = $"{buttom11}";
                control.Width = random.Next(50, 200);
                control.Height = random.Next(20, 50);
            }
            else if (control is TextBox)
            {
                ((TextBox)control).Text = "TextBox"; buttom10++;
                label28.Text = $"{buttom10}";
                control.Width = random.Next(50, 200);
                control.Height = random.Next(20, 50);
            }
            else if (control is Label)
            {
                ((Label)control).Text = "Label"; buttom9++;
                label26.Text = $"{buttom9}";
                control.Width = random.Next(50, 200);
                control.Height = random.Next(20, 50);
            }
            else if (control is CheckBox)
            {
                ((CheckBox)control).Text = "CheckBox";
                buttom8++; label24.Text = $"{buttom8}";
                control.Width = random.Next(50, 200);
                control.Height = random.Next(20, 50);
            }
            else if (control is RadioButton)
            {
                ((RadioButton)control).Text = "RadioButton";
                buttom7++; label22.Text = $"{buttom7}";
                control.Width = random.Next(50, 200);
                control.Height = random.Next(20, 50);
            }
            else if (control is ComboBox)
            {
                ((ComboBox)control).Text = "ComboBox";
                buttom6++; label20.Text = $"{buttom6}";
                control.Width = random.Next(50, 200);
                control.Height = random.Next(20, 50);
            }
            tabPage9.Controls.Add(control);
        }

        private void tabPage10_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            Random r = new Random();
            switch (r.Next(0, 2))
            {
                case 0:
                    Button b = new Button();
                    b.Location = new Point(x, y);
                    b.Size = new Size(100, 22);

                    b.Text = "button";
                    tabPage10.Controls.Add(b);


                    break;
                case 1:
                    Label lab = new Label();
                    lab.Location = new Point(x, y);
                    lab.Size = new Size(51, 16);
                    lab.Text = "label";
                    tabPage10.Controls.Add(lab);
                    break;
            }
            controlCounter++;
            if (e.Button == MouseButtons.Right)
            {
                tabPage10.Controls.Clear();
            }
        }

        private void tabPage11_MouseClick(object sender, MouseEventArgs e)
        {
            if (controlCounter % 2 == 0)
            {
                Button button = new Button();
                button.Text = $"button {controlCounter + 1}";
                button.Location = new Point(e.X, e.Y);
                button.Size = new Size(100, 22);
                tabPage11.Controls.Add(button);
            }
            else
            {
                TextBox textBox = new TextBox();
                textBox.Location = new Point(e.X - 100, e.Y - 22);
                textBox.Size = new Size(100, 22);
                tabPage11.Controls.Add(textBox);
            }
            controlCounter++;
            if (e.Button == MouseButtons.Right)
            {
                tabPage11.Controls.Clear();
            }
        }

        private List<Panel> panels = new List<Panel>();
        private void button2_Click(object sender, EventArgs e)
        {
            int p1 = tabPage12.Size.Width;
            int p2 = tabPage12.Size.Height;
            int s1 = label1.Size.Width;
            int s2 = label1.Size.Height;
            Random rnd = new Random();
            Panel panel = new Panel();
            panel.Location = new Point(rnd.Next(p1 - s1), rnd.Next(p2 - s2));
            panel.Size = new Size(200, 100);
            panel.BackColor = Color.LightGray;
            panels.Add(panel);
            tabPage12.Controls.Add(panel);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Panel panel in panels)
            {
                TextBox textbox = new TextBox();
                textbox.Location = new Point(10, 5);
                textbox.Size = new Size(180, 20);
                panel.Controls.Add(textbox);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int p1 = tabPage13.Size.Width;
            int p2 = tabPage13.Size.Height;
            int s1 = label1.Size.Width;
            int s2 = label1.Size.Height;
            Random rnd = new Random();
            switch (rnd.Next(0, 2))
            {
                case 0:
                    Button b = new Button();
                    b.Location = new Point(rnd.Next(p1 - s1), rnd.Next(p2 - s2));
                    b.Size = new Size(100, 22);
                    b.Text = "button";
                    tabPage13.Controls.Add(b);


                    break;
                case 1:
                    TextBox txb = new TextBox();
                    txb.Location = new Point(rnd.Next(p1 - s1), rnd.Next(p2 - s2));
                    txb.Size = new Size(100, 22);
                    txb.Multiline = true;
                    tabPage13.Controls.Add(txb);
                    break;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (Control c in tabPage13.Controls)
            {
                if (c is TextBox)
                {
                    c.Height *= 2;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
