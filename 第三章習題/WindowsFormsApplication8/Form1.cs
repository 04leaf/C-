using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class Form1 : Form
    {
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char n;

            n = Char.Parse((sender as Button).Text);
            double a, b, c, d, x=0, y=0;
            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            c = double.Parse(textBox3.Text);
            d = double.Parse(textBox4.Text);
            switch(n)
            {
                case '+':
                    x = a + c;
                    y = b + d;
                    break;
                case '-':
                    x = a - c;
                    y = b - d;
                    break;
                case '*':
                    x = a * c - b * d;
                    y = a * d + b * c;
                    break;
                case '/':
                    x = (a * c + b * d) / (a * a + d * d);
                    y = (b * c - a * d) / (a * a + d * d);
                    break;
            }
            if(y>0)
            {
                label5.Text = "= " + x.ToString() + "+" + y.ToString() + "i";
            }
            else if(y==0)
            {
                label5.Text = "= " + x.ToString();
            }
            else if(y<0)
            {
                label5.Text = "= " + x.ToString() + y.ToString() + "i";
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a, b, c, d, f;
            a = int.Parse(textBox5.Text) * 1000;
            b = int.Parse(textBox6.Text) * 100;
            c = int.Parse(textBox7.Text) * 10;
            d = int.Parse(textBox8.Text);
            f = a + b + c + d;
            label6.Text = f.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a, b, c;
            double d, f, g;
            a = int.Parse(textBox9.Text) * 100;
            b = int.Parse(textBox10.Text) * 10;
            c = int.Parse(textBox11.Text);
            d = Double.Parse(textBox12.Text)*0.1;
            f = Double.Parse(textBox13.Text)*0.01;
            g = a + b + c + d+ f;
            label8.Text = g.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a;
            a = int.Parse(textBox14.Text);
            label9.Text = (a/1000).ToString()+"*10^3+"+ ((a%1000) / 100).ToString() + "*10^2+" + ((a%100) / 10).ToString() + "*10+" + (a % 10).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a, b;
            a = int.Parse(textBox15.Text);
            b = a%2+a/2%2*10+a/2/2%2*100+a/2/2/2%2*1000;
            label10.Text = b.ToString();
        }
    }
}
