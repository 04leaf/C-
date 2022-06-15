using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 運算子多載_型別轉換_分數加減乘除
{
    public partial class Form1 : Form
    {
        class fraction
        {
            int num, den;
            public fraction(int num, int den)
            {
                this.num = num;
                this.den = den;
            }

            public static fraction operator +(fraction a, fraction b)
            {
                return new fraction(a.num * b.den + a.den * b.num, a.den * b.den);
            }
            public static fraction operator -(fraction a, fraction b)
            {
                return new fraction(a.num * b.den - a.den * b.num, a.den * b.den);
            }
            public static fraction operator *(fraction a, fraction b)
            {
                return new fraction(a.num * b.num, a.den * b.den);
            }
            public static fraction operator /(fraction a, fraction b)
            {
                return new fraction(a.num * b.den, a.den * b.num);
            }

            public static implicit operator double(fraction a)
            {
                return (double)a.num / a.den;
            }

            public new string ToString()
            {
                string s;
                s = num + "/" + den;
                return s;
            }
        }
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fraction a = new fraction(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            fraction b = new fraction(int.Parse(textBox3.Text), int.Parse(textBox4.Text));
            fraction c=new fraction(1,1);
            Button button = sender as Button;
            switch(button.Text)
            {
                case "+":
                    c = a + b;
                    break;
                case "-":
                    c = a - b;
                    break;
                case "*":
                    c = a * b;
                    break;
                case "/":
                    c = a / b;
                    break;
            }

            label1.Text = "=" + c.ToString();
        }
    }
}
