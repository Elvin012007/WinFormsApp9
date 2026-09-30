namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool click;
        private void button12_Click(object sender, EventArgs e)
        {
            if (click)
            {
                richTextBox1.Text = "";
                click = false;
            }
            if (richTextBox1.Text = "0")
            {
                richTextBox1.Text = "";
            }
            richTextBox1.Text += 3;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 1)
            {
                richTextBox1.Text = richTextBox11.Text.Substring(0, richTextBox1.Text.Length - 1);
            }
            else
            {
                richTextBox1.Text = "0";
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (click)
            {
                richTextBox1.Text = "";
                click = false;
            }
            if (richTextBox1.Text = "0")
            {
                richTextBox1.Text = "";
            }
            richTextBox1.Text += 1;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (click)
            {
                richTextBox1.Text = "";
                click = false;
            }
            if (richTextBox1.Text = "0")
            {
                richTextBox1.Text = "";
            }
            richTextBox1.Text += 2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (click)
            {
                richTextBox1.Text = "";
                click = false;
            }
            if (richTextBox1.Text = "0")
            {
                richTextBox1.Text = "";
            }
            richTextBox1.Text += 4;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (click)
            {
                richTextBox1.Text = "";
                click = false;
            }
            if (richTextBox1.Text = "0")
            {
                richTextBox1.Text = "";
            }
            richTextBox1.Text += 5;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (click)
            {
                richTextBox1.Text = "";
                click = false;
            }
            if (richTextBox1.Text = "0")
            {
                richTextBox1.Text = "";
            }
            richTextBox1.Text += 6;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (click)
            {
                richTextBox1.Text = "";
                click = false;
            }
            if (richTextBox1.Text = "0")
            {
                richTextBox1.Text = "";
            }
            richTextBox1.Text += 7;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (click)
            {
                richTextBox1.Text = "";
                click = false;
            }
            if (richTextBox1.Text = "0")
            {
                richTextBox1.Text = "";
            }
            richTextBox1.Text += 8;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (click)
            {
                richTextBox1.Text = "";
                click = false;
            }
            if (richTextBox1.Text = "0")
            {
                richTextBox1.Text = "";
            }
            richTextBox1.Text += 9;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (click)
            {
                richTextBox1.Text = "";
                click = false;
            }
            if (richTextBox1.Text = "0")
            {
                richTextBox1.Text = "";
            }
            richTextBox1.Text += 0;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!richTextBox1.Text.Contains("."))
            {
                richTextBox1.Text += ".";
            }
        }
        char operand;
        private void button16_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == string.Empty)
            {
                richTextBox1.Text = "Invalid value";
            }
            else
            {
                operand = '+';
                click = true;
                a = Convert.ToDouble(richTextBox1.Text);

            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == string.Empty)
            {
                richTextBox1.Text = "Invalid value";
            }
            else
            {
                operand = '-';
                click = true;
                a = Convert.ToDouble(richTextBox1.Text);

            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == string.Empty)
            {
                richTextBox1.Text = "Invalid value";
            }
            else
            {
                operand = 'x';
                click = true;
                a = Convert.ToDouble(richTextBox1.Text);

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == string.Empty)
            {
                richTextBox1.Text = "Invalid value";
            }
            else
            {
                operand = '/';
                click = true;
                a = Convert.ToDouble(richTextBox1.Text);

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            switch (operand)
            {
                case '+':
                    c = richTextBox1.Text;
                    richTextBox1.Text=(a+Convert.ToDouble(richTextBox1.Text)); ToString();
                    listBox1.Items.Add(a.ToString()+"");
                    break;
                case '-':
                    richTextBox1.Text = (a + Convert.ToDouble(richTextBox1.Text)); ToString(); break;
                case 'x':
                    richTextBox1.Text = (a + Convert.ToDouble(richTextBox1.Text)); ToString(); break;
                case '/':
                    richTextBox1.Text = (a + Convert.ToDouble(richTextBox1.Text)); ToString(); break;
            }
        }
    }
}
