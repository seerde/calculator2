using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator2
{
    public partial class Form1 : Form
    {
        Double sum = 0;
        Double mSum = 0;
        String data = "";
        bool isData = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (isData))
                textBox1.Clear();
            isData = false;
            Button button = (Button)sender;
            if(button.Text == ".")
            {
                if(!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + button.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + button.Text;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (sum != 0)
            {
                label1.Text = label1.Text + textBox1.Text + " ";
                button16.PerformClick();
                data = button.Text;
                label1.Text = label1.Text + data + " ";
                //label1.Text = label1.Text + sum + " " + data + " ";
                isData = true;
            }else
            {
                data = button.Text;
                sum = Double.Parse(textBox1.Text);
                //label1.Text = sum + " " + data + " ";
                label1.Text = textBox1.Text + " " + data + " ";
                isData = true;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            sum = 0;
            label1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            switch(data)
            {
                case "+":
                    textBox1.Text = (sum + Double.Parse(textBox1.Text)).ToString();
                    //label1.Text = "";
                    break;
                case "-":
                    textBox1.Text = (sum - Double.Parse(textBox1.Text)).ToString();
                    //label1.Text = "";
                    break;
                case "/":
                    textBox1.Text = (sum / Double.Parse(textBox1.Text)).ToString();
                    //label1.Text = "";
                    break;
                case "*":
                    textBox1.Text = (sum * Double.Parse(textBox1.Text)).ToString();
                    //label1.Text = "";
                    break;
                default:
                    break;
            }
            sum = Double.Parse(textBox1.Text);
            //label1.Text = "";
        }

        private void button29_Click(object sender, EventArgs e)
        {
            mSum = Double.Parse(textBox1.Text);
            label2.Text = mSum.ToString();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if(mSum != 0)
            {
                mSum += Double.Parse(textBox1.Text);
                label2.Text = mSum.ToString();
            }
            else
            {
                mSum = Double.Parse(textBox1.Text);
                label2.Text = mSum.ToString();
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (mSum != 0)
            {
                mSum -= Double.Parse(textBox1.Text);
                label2.Text = mSum.ToString();
            }
            else
            {
                if (mSum == 0)
                {
                    mSum -= Double.Parse(textBox1.Text);
                    label2.Text = mSum.ToString();
                }
                else
                {
                    mSum -= mSum;
                    label2.Text = mSum.ToString();
                    label2.Text = mSum.ToString();
                }
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            mSum = 0;
            label2.Text = mSum.ToString();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            textBox1.Text = mSum.ToString();
            label2.Text = mSum.ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if(sum != 0)
            {
                sum = sum * -1;
            }
            if(textBox1.Text != "0")
            {
                textBox1.Text = (Double.Parse(textBox1.Text) * -1).ToString();
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            if (textBox1.Text == "")
                textBox1.Text = "0";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            label1.Text = "sqr(" + Double.Parse(textBox1.Text) + ") ";
            textBox1.Text = (Double.Parse(textBox1.Text) * Double.Parse(textBox1.Text)).ToString();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            label1.Text = "1/(" + Double.Parse(textBox1.Text) + ") ";
            textBox1.Text = (1 / Double.Parse(textBox1.Text)).ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if(sum != 0)
            {
                textBox1.Text = (sum + (sum * Double.Parse(textBox1.Text) / 100)).ToString();
                label1.Text = label1.Text + textBox1.Text + " ";
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            label1.Text = "√(" + Double.Parse(textBox1.Text) + ") ";
            textBox1.Text = (Math.Sqrt(Double.Parse(textBox1.Text))).ToString();
        }
    }
}
