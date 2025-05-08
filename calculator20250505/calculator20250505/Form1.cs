using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator20250505
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if(btn != null)
            {
                if(textBox1.Text == "0")
                {
                    textBox1.Text = btn.Text;

                }
                else
                {
                    textBox1.Text += btn.Text;
                }
            }
        }

        private void buttonAc_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.IndexOf(".") >= 0)
            {
                return;
            }
            else
            {
                textBox1.Text += ".";
            }
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Last() == '*' || textBox1.Text.Last() == '-' || textBox1.Text.Last() == '/' || textBox1.Text.Last() == '+')
                {
                    return; // 式の最後が演算子なら無視
                }

                string expression = textBox1.Text;
                var result = new DataTable().Compute(textBox1.Text, null);
                textBox1.Text = result.ToString();
                textBox2.Text = expression;
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                return;
            }
            else if (textBox1.Text.Last() == '*' || textBox1.Text.Last() == '-' || textBox1.Text.Last() == '/' || textBox1.Text.Last() == '+')
            {
                return;
            }

            else
            {
                textBox1.Text += "/";
            }
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                return;
            }
            else if (textBox1.Text.Last() == '*' || textBox1.Text.Last() == '-' || textBox1.Text.Last() == '/' || textBox1.Text.Last() == '+')
            {
                return;
            }

            else
            {
                textBox1.Text += "*";
            }
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                return;
            }
            else if (textBox1.Text.Last() == '*' || textBox1.Text.Last() == '-' || textBox1.Text.Last() == '/' || textBox1.Text.Last() == '+')
            {
                return;
            }

            else
            {
                textBox1.Text += "-";
            }
        }

        private void buttonPuls_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                return;
            }
            else if (textBox1.Text.Last() == '*' || textBox1.Text.Last() == '-' || textBox1.Text.Last() == '/' || textBox1.Text.Last() == '+')
            {
                return;
            }

            else
            {
                textBox1.Text += "+";
            }
        }
    }
}