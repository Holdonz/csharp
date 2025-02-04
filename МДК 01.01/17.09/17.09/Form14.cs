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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void tabPage1_MouseClick(object sender, MouseEventArgs e)
        {
            Button button = new Button();
            button.Text = $"({e.X}, {e.Y})";
            button.Size = new Size(100, 30);
            button.Location = new Point(e.X, e.Y);
            tabPage1.Controls.Add(button);
        }

        private void splitContainer1_Panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Button button = new Button();
            button.Size = new Size(100, 30);
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

        private void tabPage5_Click(object sender, EventArgs e)
        {
            int rows = 7; 
            int cols = 7;

            int buttonWidth = 50; 
            int buttonHeight = 30;

            int spacing = 10;
            int gridWidth = cols * buttonWidth + (cols - 1) * spacing;
            int gridHeight = rows * buttonHeight + (rows - 1) * spacing;
            int gridX = (ClientSize.Width - gridWidth) / 7;
            int gridY = (ClientSize.Height - gridHeight) / 7;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
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
                button.Size = new Size(80, 30);
                tabPage6.Controls.Add(button);
            }
            else 
            {
                TextBox textBox = new TextBox();
                textBox.Location = new Point(e.X - 80, e.Y - 20); 
                textBox.Size = new Size(80, 20);
                tabPage6.Controls.Add(textBox);
            }
            controlCounter++;
        }
        int buttonCounter;
        int labelCounter;
        int txbCounter;
        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            int p1 = tabPage7.Size.Width; 
            int p2 = tabPage7.Size.Height;
            int s1 = button1.Size.Width; 
            int s2 = button1.Size.Height;
            Random rnd = new Random();

            button1.Visible = true; 
            Button button = new Button();
            button.Text = $"Button"; 
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
            label.Text = $"Label"; 
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
            TextBox texbox = new TextBox(); 
            texbox.Text = $"TextBox";
            texbox.Location = new Point(rnd.Next(p1 - s1), rnd.Next(p2 - s2)); 
            texbox.Size = new Size(80, 30);
            tabPage7.Controls.Add(texbox); 
            controlCounter++;
            txbCounter++;
            label5.Text = $"{txbCounter}";
            label2.Text = $"{ controlCounter}";
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
                label9.Text = $"{nButton}";
            }
            else if (control is TextBox)
            {
                ((TextBox)control).Text = $"({e.X}, {e.Y})";
                nTextBox++;
                label15.Text = $"{nTextBox}";
            }
            else if (control is Label)
            {
                ((Label)control).Text = $"({e.X}, {e.Y})";
                nLabel++;
                label11.Text = $"{nLabel}";
            }
            else if (control is CheckBox)
            {
                ((CheckBox)control).Text = $"({e.X}, {e.Y})";
                nCheckBox++;
                label13.Text = $"{nCheckBox}";
            }
            else if (control is RadioButton)
            {
                ((RadioButton)control).Text = $"({e.X}, {e.Y})";
                nRadioButton++;
                label17.Text = $"{nRadioButton}";
            }
            else if (control is ComboBox)
            {
                ((ComboBox)control).Text = $"({e.X}, {e.Y})";
                nComboBox++;
                label19.Text = $"{nComboBox}";
            }
            panel5.Controls.Add(control);
            controlCounter++;
            label6.Text = $"{controlCounter}";
        }
        int nButton;
        int nTextBox;
        int nLabel;
        int nCheckBox;
        int nRadioButton;
        int nComboBox;
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
                label9.Text = $"{nButton}";
            }
            else if (control is TextBox)
            {
                ((TextBox)control).Text = $"({e.X}, {e.Y})";
                nTextBox++;
                label15.Text = $"{nTextBox}";
            }
            else if (control is Label)
            {
                ((Label)control).Text = $"({e.X}, {e.Y})";
                nLabel++;
                label11.Text = $"{nLabel}";
            }
            else if (control is CheckBox)
            {
                ((CheckBox)control).Text = $"({e.X}, {e.Y})";
                nCheckBox++;
                label13.Text = $"{nCheckBox}";
            }
            else if (control is RadioButton)
            {
                ((RadioButton)control).Text = $"({e.X}, {e.Y})";
                nRadioButton++;
                label17.Text = $"{nRadioButton}";
            }
            else if (control is ComboBox)
            {
                ((ComboBox)control).Text = $"({e.X}, {e.Y})";
                nComboBox++;
                label19.Text = $"{nComboBox}";
            }
            tabPage8.Controls.Add(control);
            controlCounter++;

            label6.Text = $"{controlCounter}";
        }
        int buttom11 = 0; int buttom10 = 0;
        int buttom9 = 0; int buttom8 = 0;
        int buttom7 = 0; int buttom6 = 0;
        private void tabPage9_MouseClick(object sender, MouseEventArgs e)
        {
            Random random = new Random(); int controlIndex = random.Next(0, 6);
            Type controlType = GetRandomControlType(); Control control = (Control)Activator.CreateInstance(controlType);
            control.Size = new Size(100, 30); control.Location = new Point(e.X - control.Width / 2, e.Y - control.Height / 2); if (control is Button)
            {
                ((Button)control).Text = "Button";
                buttom11++;
                label30.Text = $"{buttom11}"; control.Width = random.Next(50, 200);
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
                label26.Text = $"{buttom9}"; control.Width = random.Next(50, 200);
                control.Height = random.Next(20, 50);
            }
            else if (control is CheckBox)
            {
                ((CheckBox)control).Text = "CheckBox";
                buttom8++; label24.Text = $"{buttom8}";
                control.Width = random.Next(50, 200); control.Height = random.Next(20, 50);
            }
            else if (control is RadioButton)
            {
                ((RadioButton)control).Text = "RadioButton";
                buttom7++; label22.Text = $"{buttom7}";
                control.Width = random.Next(50, 200); control.Height = random.Next(20, 50);
            }
            else if (control is ComboBox)
            {
                ((ComboBox)control).Text = "ComboBox";
                buttom6++; label20.Text = $"{buttom6}";
                control.Width = random.Next(50, 200); control.Height = random.Next(20, 50);
            }
            tabPage9.Controls.Add(control);
        }

        private void tabPage10_MouseDown(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            Random r = new Random();
            switch (r.Next(0, 2))
            {
                case 0:
                    Button b = new Button();
                    b.Location = new Point(x, y);
                    b.Size = new Size(150, 30);

                    b.Text = "Button";
                    tabPage10.Controls.Add(b);


                    break;
                case 1:
                    Label lab = new Label();
                    lab.Location = new Point(x, y);
                    lab.Size = new Size(150, 30);
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
                button.Text = $"Button {controlCounter + 1}";
                button.Location = new Point(e.X, e.Y);
                button.Size = new Size(80, 30);
                tabPage11.Controls.Add(button);
            }
            else
            {
                TextBox textBox = new TextBox();
                textBox.Location = new Point(e.X - 80, e.Y - 20);
                textBox.Size = new Size(80, 20);
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
                    b.Size = new Size(150, 30);
                    b.Text = "Button";
                    tabPage13.Controls.Add(b);


                    break;
                case 1:
                    TextBox txb = new TextBox();
                    txb.Location = new Point(rnd.Next(p1 - s1), rnd.Next(p2 - s2));
                    txb.Size = new Size(150, 30);
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
            string controlType = textBox2.Text.ToUpper();
            int x = int.Parse(textBox3.Text);
            int y = int.Parse(textBox4.Text);

            Control newControl = null;

            switch (controlType)
            {
                case "К":
                    newControl = new Button();
                    ((Button)newControl).Text = "Новая кнопка";
                    break;
                case "П":
                    newControl = new TextBox();
                    break;
                case "М":
                    newControl = new Label();
                    ((Label)newControl).Text = "Новая метка";
                    break;
                default:
                    MessageBox.Show("Неверный тип элемента управления");
                    return;
            }

            newControl.Location = new Point(x, y);
            tabPage14.Controls.Add(newControl);
            
        }
        private int smallCount = 0;
        private int bigCount = 0;
        private void button7_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox5.Text);
            int y = int.Parse(textBox6.Text);
            int width = int.Parse(textBox7.Text);
            int height = int.Parse(textBox8.Text);

            Label label = new Label();
            label.Text = "Новая метка";
            label.Location = new Point(x, y);
            label.Size = new Size(width, height);

            if (width < 50 && height < 50)
            {
                smallCount++;
            }
            else
            {
                bigCount++;
            }

            tabPage15.Controls.Add(label);
            Title();
        }
        private void Title()
        {
            Text = $"Метки: Маленькие ({smallCount}), Большие ({bigCount})";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            foreach (Control control in tabPage16.Controls)
            {
                if (control is Label)
                {
                    control.Width *= 2;
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            foreach (Control control in tabPage16.Controls)
            {
                if (control is TextBox)
                {
                    control.Height /= 2;
                }
            }
        }

        private void tabPage16_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            Random r = new Random();
            switch (r.Next(0, 2))
            {
                case 0:
                    TextBox tb = new TextBox();
                    tb.Location = new Point(x, y);
                    tb.Size = new Size(150, 100);
                    tb.Multiline = true;
                    tb.Text = "textBox";
                    tabPage16.Controls.Add(tb);


                    break;
                case 1:
                    Label lab = new Label();
                    lab.BackColor = Color.Gray;
                    lab.Location = new Point(x, y);
                    lab.Size = new Size(150, 30);
                    lab.Text = "label";
                    tabPage16.Controls.Add(lab);
                    break;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int x = tabPage17.Size.Width;
            int y = tabPage17.Size.Height;
            int width = button1.Size.Width;
            int height = button1.Size.Height;

            if (IsPlacementValid(x, y, width, height))
            {
                Control control = random.Next(0, 2) == 0 ? (Control)new Button() : (Control)new TextBox();

                control.Location = new Point(random.Next(x - width), random.Next(y - height));
                control.Size = new Size(width, height);
                if (control is Button)
                {
                    ((Button)control).Text = "Кнопка";
                }

                tabPage17.Controls.Add(control);
            }
            else
            {
                MessageBox.Show("Нет места для добавления элемента управления!");
            }

        }
        private bool IsPlacementValid(int x, int y, int width, int height)
        {
            foreach (Control control in Controls)
            {
                if (control.Bounds.IntersectsWith(new Rectangle(x, y, width, height)))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
