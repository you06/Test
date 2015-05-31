using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public double a = 0;
        public double b = 0;
        public bool inputStatus = true;
        public int num = 0;
        public int method = 0;
        public bool start = true;
        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!start)
            {
                label1.Text = "";
                start = true;
            }
            if (inputStatus)
            {
                if (num == 0)
                {
                    a = 10 * a + 1;
                    label1.Text += "1";
                }
                else
                {
                    a = a + 1 * Math.Pow(10, -num);
                    num++;
                    label1.Text += "1";
                }
            }
            else
            {
                if (num == 0)
                {
                    b = 10 * b + 1;
                    label1.Text += "1";
                }
                else
                {
                    b = b + 1 * Math.Pow(10, -num);
                    num++;
                    label1.Text += "1";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!start)
            {
                label1.Text = "";
                start = true;
            }
            if (inputStatus)
            {
                if (num == 0)
                {
                    a = 10 * a + 2;
                    label1.Text += "2";
                }
                else
                {
                    a = a + 2 * Math.Pow(10, -num);
                    num++;
                    label1.Text += "2";
                }
            }
            else
            {
                if (!start) label1.Text = "";
                if (num == 0)
                {
                    b = 10 * b + 2;
                    label1.Text += "2";
                }
                else
                {
                    b = b + 2 * Math.Pow(10, -num);
                    num++;
                    label1.Text += "2";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!start)
            {
                label1.Text = "";
                start = true;
            }
            if (inputStatus)
            {
                if (num == 0)
                {
                    a = 10 * a + 3;
                    label1.Text += "3";
                }
                else
                {
                    a = a + 3 * Math.Pow(10, -num);
                    num++;
                    label1.Text += "3";
                }
            }
            else
            {
                if (num == 0)
                {
                    b = 10 * b + 3;
                    label1.Text += "3";
                }
                else
                {
                    b = b + 3 * Math.Pow(10, -num);
                    num++;
                    label1.Text += "3";
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!start)
            {
                label1.Text = "";
                start = true;
            }
            if (inputStatus)
            {
                if (num == 0)
                {
                    a = 10 * a + 4;
                    label1.Text += "4";
                }
                else
                {
                    a = a + 4 * Math.Pow(10, -num);
                    num++;
                    label1.Text += "4";
                }
            }
            else
            {
                if (num == 0)
                {
                    b = 10 * b + 4;
                    label1.Text += "4";
                }
                else
                {
                    b = b + 4 * Math.Pow(10, -num);
                    num++;
                    label1.Text += "4";
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!start)
            {
                label1.Text = "";
                start = true;
            }
            if (inputStatus)
            {
                if (num == 0)
                {
                    a = 10 * a + 5;
                    label1.Text += "5";
                }
                else
                {
                    a = a + 5 * Math.Pow(10, -num);
                    num++;
                    label1.Text += "5";
                }
            }
            else
            {
                if (num == 0)
                {
                    b = 10 * b + 5;
                    label1.Text += "5";
                }
                else
                {
                    b = b + 5 * Math.Pow(10, -num);
                    num++;
                    label1.Text += "5";
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!start)
            {
                label1.Text = "";
                start = true;
            }
            if (inputStatus)
            {
                if (num == 0)
                {
                    a = 10 * a + 6;
                    label1.Text += "6";
                }
                else
                {
                    a = a + 6 * Math.Pow(10, -num);
                    num++;
                    label1.Text += "6";
                }
            }
            else
            {
                if (num == 0)
                {
                    b = 10 * b + 6;
                    label1.Text += "6";
                }
                else
                {
                    b = b + 6 * Math.Pow(10, -num);
                    num++;
                    label1.Text += "6";
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!start)
            {
                label1.Text = "";
                start = true;
            }
            if (inputStatus)
            {
                if (num == 0)
                {
                    a = 10 * a + 7;
                    label1.Text += "7";
                }
                else
                {
                    a = a + 7 * Math.Pow(10, -num);
                    num++;
                    label1.Text += "7";
                }
            }
            else
            {
                if (num == 0)
                {
                    b = 10 * b + 7;
                    label1.Text += "7";
                }
                else
                {
                    b = b + 7 * Math.Pow(10, -num);
                    num++;
                    label1.Text += "7";
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!start)
            {
                label1.Text = "";
                start = true;
            }
            if (inputStatus)
            {
                if (num == 0)
                {
                    a = 10 * a + 8;
                    label1.Text += "8";
                }
                else
                {
                    a = a + 8 * Math.Pow(10, -num);
                    num++;
                    label1.Text += "8";
                }
            }
            else
            {
                if (num == 0)
                {
                    b = 10 * b + 8;
                    label1.Text += "8";
                }
                else
                {
                    b = b + 8 * Math.Pow(10, -num);
                    num++;
                    label1.Text += "8";
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!start)
            {
                label1.Text = "";
                start = true;
            }
            if (inputStatus)
            {
                if (num == 0)
                {
                    a = 10 * a + 9;
                    label1.Text += "9";
                }
                else
                {
                    a = a + 9 * Math.Pow(10, -num);
                    num++;
                    label1.Text += "9";
                }
            }
            else
            {
                if (num == 0)
                {
                    b = 10 * b + 9;
                    label1.Text += "9";
                }
                else
                {
                    b = b + 9 * Math.Pow(10, -num);
                    num++;
                    label1.Text += "9";
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (!start)
            {
                label1.Text = "";
                start = true;
            }
            if (inputStatus)
            {
                if (num == 0)
                {
                    a = 10 * a;
                    label1.Text += "0";
                }
                else
                {
                    num++;
                    label1.Text += "0";
                }
            }
            else
            {
                if (num == 0)
                {
                    b = 10 * b;
                    label1.Text += "0";
                }
                else
                {
                    num++;
                    label1.Text += "0";
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            num = 1;
            label1.Text += ".";
        }
        public void forbid(bool status)
        {
            button19.Enabled = status;
            button20.Enabled = status;
            button21.Enabled = status;
            button22.Enabled = status;
            button23.Enabled = status;
        }
        private void button0_Click(object sender, EventArgs e)
        {
            a = 0;
            b = 0;
            inputStatus = true;
            num = 0;
            label1.Text = "";
            start = true;
            forbid(true);
        }
        private void button12_Click(object sender, EventArgs e)
        {
            inputStatus = false;
            method = 1;
            label1.Text += "+";
            forbid(false);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            inputStatus = false;
            method = 2;
            label1.Text += "-";
            forbid(false);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            inputStatus = false;
            method = 3;
            label1.Text += "*";
            forbid(false);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            inputStatus = false;
            method = 4;
            label1.Text += "/";
            forbid(false);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            inputStatus = false;
            method = 5;
            label1.Text = "pow   " + label1.Text + "  ";
            forbid(false);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            inputStatus = false;
            method = 6;
            label1.Text = "min   " + label1.Text + "  ";
            forbid(false);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            inputStatus = false;
            method = 7;
            label1.Text = "max   " + label1.Text + "  ";
            forbid(false);
        }
        public void reset()
        {
            a = 0;
            b = 0;
            inputStatus = true;
            num = 0;
            start = false;
            forbid(true);
        }
        private void button00_Click(object sender, EventArgs e)
        {
            switch (method)
            {
                case 1:
                    label1.Text += "\n";
                    label1.Text += Convert.ToString(a + b);
                    reset();
                    break;
                case 2:
                    label1.Text += "\n";
                    label1.Text += Convert.ToString(a - b);
                    reset();
                    break;
                case 3:
                    label1.Text += "\n";
                    label1.Text += Convert.ToString(a * b);
                    reset();
                    break;
                case 4:
                    label1.Text += "\n";
                    try
                    {
                        label1.Text += Convert.ToString(a / b);
                    }
                    catch (DivideByZeroException)
                    {
                        MessageBox.Show("除数不能为0>_<");
                    }
                    reset();
                    break;
                case 5:
                    label1.Text += "\n";
                    label1.Text += Convert.ToString(Math.Pow(a,b));
                    reset();
                    break;
                case 6:
                    label1.Text += "\n";
                    label1.Text += Convert.ToString((a > b) ? b : a);
                    reset();
                    break;
                case 7:
                    label1.Text += "\n";
                    label1.Text += Convert.ToString((a < b) ? b : a);
                    reset();
                    break;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            label1.Text += "\n";
            label1.Text += Convert.ToString(Math.Sin(a));
            reset();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            label1.Text += "\n";
            label1.Text += Convert.ToString(Math.Cos(a));
            reset();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            label1.Text += "\n";
            label1.Text += Convert.ToString(Math.Log(a));
            reset();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            label1.Text += "\n";
            label1.Text += Convert.ToString(Math.Log10(a));
            reset();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            label1.Text += "\n";
            label1.Text += Convert.ToString(Math.Sqrt(a));
            reset();
        }
    }
}
