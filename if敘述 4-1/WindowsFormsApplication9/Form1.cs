using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication9
{
    public partial class Form1 : Form
    {
        int w = 0;

        public Form1()
        {
            InitializeComponent();
            button3.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            label3.Enabled = false;
            button4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            label4.Enabled = false;
            label5.Enabled = false;
            label6.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a,b;
            a = int.Parse(textBox1.Text);

            b = a * 3;
            if(a>100)
            {
                b = 300 + (a - 100) * 5;
                if (a > 300)
                {
                    b = 1300 + (a - 300) * 6;
                }
            }

            label1.Text = "度自來水，" + b.ToString() + "元";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if(textBox2.Text=="123")
            {
                button2.Enabled = false;
                label2.Text = "密碼正確";
                button3.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                label3.Enabled = true;
                button4.Enabled = true;
                textBox5.Enabled = true;
                textBox6.Enabled = true;
                textBox7.Enabled = true;
                label4.Enabled = true;
                label5.Enabled = true;
                label6.Enabled = true;
            }
            if(textBox2.Text!="123")
            {
                w = w + 1;
                if(w==3)
                {
                    Close();
                }
                label2.Text = "密碼錯誤"+w.ToString()+"次"; 
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double x, y;
            x = double.Parse(textBox3.Text);
            y = double.Parse(textBox4.Text);

            if (x == 0)
            {
                label3.Text = "落在y軸上";
                if (y == 0)
                {
                    label3.Text = "落在原點";
                }
            }
            if (y == 0)
            {
                label3.Text = "落在x軸上";
                if (x == 0)
                {
                    label3.Text = "落在原點";
                }
            }

            if(x > 0)
            {
                if(y > 0)
                {
                    label3.Text = "位在第一象限";
                }
                if (y < 0)
                {
                    label3.Text = "位在第四象限";
                }
            }
            if (x < 0)
            {
                if (y > 0)
                {
                    label3.Text = "位在第二象限";
                }
                if (y < 0)
                {
                    label3.Text = "位在第三象限";
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double a, b, c, x, y;
            x = double.Parse(textBox3.Text);
            y = double.Parse(textBox4.Text);
            a = double.Parse(textBox5.Text);
            b = double.Parse(textBox6.Text);
            c = double.Parse(textBox7.Text);
            label6.Text = "=0，沒有落在直線上";
            if (a*x+b*y+c==0)
            {
                label6.Text = "=0，有落在直線上";
            }
        }
    }
}
