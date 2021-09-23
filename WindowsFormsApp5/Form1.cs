using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        float a, b;
        int count;
        bool znak = true;
        public Form1()
        {
            InitializeComponent();
            panel1.Show();
            panel2.Hide();
            panel3.Hide();
        }

        private void button_num1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button_num2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button_num3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button_num4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button_num5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button_num6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button_num7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button_num8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button_num9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button_num0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void button_segment_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 4;
            label1.Text = a.ToString() + "/";
            znak = true;
        }

        private void button_multiply_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 3;
            label1.Text = a.ToString() + "*";
            znak = true;
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 2;
            label1.Text = a.ToString() + "-";
            znak = true;
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 1;
            label1.Text = a.ToString() + "+";
            znak = true;
        }

        private void button_equal_Click(object sender, EventArgs e)
        {
            calculate();
            label1.Text = "";
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }

        private void button_joke_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
        }

        private void конвертерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Show();
            panel3.Hide();
        }

        private void обычныйРежимToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Show();
            panel2.Hide();
            panel3.Hide();
        }
        private void режимПрограммистаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Hide();
            panel3.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton_smtonm.Checked)
            {
                double a = Convert.ToDouble(textBox_value.Text);
                double b = a * 10000000;
                textBox_transvalue.Text = Convert.ToString($"{b}");
            }
            else if (radioButton_smtodm.Checked)
            {
                double a = Convert.ToDouble(textBox_value.Text);
                double b = a / 10;
                textBox_transvalue.Text = Convert.ToString($"{b}");
            }
            else if(radioButton_smtom.Checked)
            {
                double a = Convert.ToDouble(textBox_value.Text);
                double b = a / 100;
                textBox_transvalue.Text = Convert.ToString($"{b}");
            }
            else if (radioButton_smtokm.Checked)
            {
                double a = Convert.ToDouble(textBox_value.Text);
                double b = a / 1000;
                textBox_transvalue.Text = Convert.ToString($"{b}");
            }
            else if(radioButton_nmtosm.Checked)
            {
                double a = Convert.ToDouble(textBox_value.Text);
                double b = a / 1e+7;
                textBox_transvalue.Text = Convert.ToString($"{b}");
            }
            else if (radioButton_dmtosm.Checked)
            {
                double a = Convert.ToDouble(textBox_value.Text);
                double b = a * 10;
                textBox_transvalue.Text = Convert.ToString($"{b}");
            }
            else if (radioButton_mtosm.Checked)
            {
                double a = Convert.ToDouble(textBox_value.Text);
                double b = a * 100;
                textBox_transvalue.Text = Convert.ToString($"{b}");
            }
            else if (radioButton_kmtosm.Checked)
            {
                double a = Convert.ToDouble(textBox_value.Text);
                double b = a * 1000;
                textBox_transvalue.Text = Convert.ToString($"{b}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(radioButton_FromTtoD.Checked)
            {
                int value = Convert.ToInt32(textBox3.Text);
                string BinaryCode = Convert.ToString(value, 2);
                textBox2.Text = BinaryCode;
            } 
            if (radioButton_fromDtoT.Checked)
            {
                ulong num = 0, ost = 0, result = 0, count = 0, s = 0;
                num = Convert.ToUInt32(textBox3.Text);
                while (num > 0)
                {
                    ost = num % 10;
                    s = Convert.ToUInt64(Math.Pow(2, count));
                    result = result + ost * s;
                    count += 1;
                    num = num / 10;
                }
                textBox2.Text = Convert.ToString(result);
            }
            if (radioButton_fromTtoE.Checked)
            {
                int value = Convert.ToInt32(textBox3.Text);
                string BinaryCode = Convert.ToString(value, 8);
                textBox2.Text = BinaryCode;
            }
            if (radioButton_fromEtoT.Checked)
            {
                ulong num = 0, ost = 0, result = 0, count = 0, s = 0;
                num = Convert.ToUInt32(textBox3.Text);
                while (num > 0)
                {
                    ost = num % 10;
                    s = Convert.ToUInt64(Math.Pow(8, count));
                    result = result + ost * s;
                    count += 1;
                    num = num / 10;
                }
                textBox2.Text = Convert.ToString(result);
            }
            if (radioButton_fromTtoHEX.Checked)
            {
                int value = Convert.ToInt32(textBox3.Text);
                string BinaryCode = Convert.ToString(value, 16);
                textBox2.Text = BinaryCode;
            }
            if (radioButton_fromHEXtoT.Checked)
            {
                ulong num = 0, ost = 0, result = 0, count = 0, s = 0;
                num = Convert.ToUInt32(textBox3.Text);
                while (num > 0)
                {
                    ost = num % 10;
                    s = Convert.ToUInt64(Math.Pow(16, count));
                    result = result + ost * s;
                    count += 1;
                    num = num / 10;
                }
                textBox2.Text = Convert.ToString(result);
            }
        }

        private void calculate()
        {
            switch (count)
            {
                case 1:
                    b = a + float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 2:
                    b = a - float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 3:
                    b = a * float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 4:
                    b = a / float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;

                default:
                    break;
            }

        }
    }
}
