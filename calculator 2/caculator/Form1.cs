using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caculator
{
    public partial class Form1 : Form
    {
        double a, b,Result;
        string c;

        public Form1()
        {
            InitializeComponent();
             
        }

        private void button12_Click(object sender, EventArgs e)
        {
            c = "+";
            textBox1.Text = "+";
            switch (c)
            {
                case "+":
                    Result = a + b;
                    break;
                default:
                    textBox1.Text = "sdlkgmkfhmsfdp";
                    break;
            }
            textBox1.Text = "" + Result;

            }

        private void C_Click(object sender, EventArgs e)
        {
            a = 0;
            b = 0;
            c = "";
            textBox1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (c == "")
                a = 1;
            else
                b = 1;
            textBox1.Text = "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (c == "")
                a = 2;
            else
                b = 2;
            textBox1.Text = "2";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (c == "")
                a = 3;
            else
                b = 3;
            textBox1.Text = "3";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (c == "")
                a = 4;
            else
                b = 4;
            textBox1.Text = "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (c == "")
                a = 5;
            else
                b = 5;
            textBox1.Text = "5";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (c == "")
                a = 6;
            else
                b = 6;
            textBox1.Text = "6";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (c == "")
                a = 7;
            else
                b = 7;
            textBox1.Text = "7";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (c == "")
                a = 8;
            else
                b = 8;
            textBox1.Text = "8";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (c == "")
                a = 9;
            else
                b = 9;
            textBox1.Text = "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (c == "")
                a = 0;
            else
                b = 0;
            textBox1.Text = "0";

        }

        private void button13_Click(object sender, EventArgs e)
        {
            c = "-";
            textBox1.Text = "-";

        }

        private void button14_Click(object sender, EventArgs e)
        {
            c = "*";
            textBox1.Text = "*";
        }

        private void Bequals_Click(object sender, EventArgs e)
        {
            switch (c)
            {
                case "+":
                    Result = a + b;
                    break;
                case "-":
                    Result = a - b;
                    break;
                case "*":
                    Result = a * b;
                    break;
                case "/":
                    Result = a / b;
                    break;
                default:
                    textBox1.Text = "something went wrong please try again";
                    break;
            }
           textBox1.Text = ""+Result;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            c = "/";
            textBox1.Text = "/";
        }
    }
}
