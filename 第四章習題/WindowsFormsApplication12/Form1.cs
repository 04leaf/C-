using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication12
{
    public partial class Form1 : Form
    {
        bool game = false;
        int a = 100,count=0,money=100;
        int count2 = 0,guess1=0,guess2=100,guess=0;
        int A = 0, b = 0, c = 0, d = 0;


        public Form1()
        {
            InitializeComponent();
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            label1.Text = "平年";
            if(a%4==0)
            {
                label1.Text = "閏年";
                if(a%100==0)
                {
                    label1.Text = "平年";
                    if(a%400==0)
                    {
                        label1.Text = "閏年";
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox2.Text),b=0;
            if(a<=300000)
            {
                b = a / 100 * 6;
            }
            else if(a>300000 && a<=800000)
            {
                b = 300000 / 100 * 6 + (a - 300000) / 100 * 13;
            }
            else if(a>800000 && a<=2000000)
            {
                b = 300000 / 100 * 6 + 500000 / 100 * 13 + (a - 800000) / 100 * 21;
            }
            else if (a > 2000000)
            {
                b = 300000 / 100 * 6 + 500000 / 100 * 13 + 1200000 / 100 * 21+(a-2000000)/100*30;
            }
            label3.Text = "納稅金額" + b.ToString() + "元";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox3.Text), b = 0;
            if (a > 12)
            {
                b = a + 3;
            }
            else if (a >= 5 && a <= 12)
            {
                b = a * a;
            }
            else if (a > 0 && a < 5)
            {
                b = Math.Sqrt(a) ;
            }
            label5.Text = "y=" + b.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox4.Text), b = 100 * a;
            if(a>=500)
            {
                b = 70 * a;
            }
            else if(a>=300 && a<=499)
            {
                b = 80 * a;
            }
            else if (a >= 100 && a <= 299)
            {
                b = 90 * a;
            }
            label7.Text = b.ToString() + "元";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            count = count + 1;
            int b = int.Parse(textBox5.Text);
            int win = 0;

            if(count < 6 && count >= 4)
            {
                win = 10;
            }
            else if(count<4&&count>1)
            {
                win = 300;
            }
            else if(count==1)
            {
                win = 500;
            }

            if(game==false)
            {
                money = money - 10;
                game = true;
                Random r = new Random();
                a = r.Next(0,100);
            }
            if(b == a)
            {
                game = false;
                money = money + win;
                if(win>0)
                {
                    label10.Text = "猜中了，猜了" + count.ToString() + "次，得到" + win.ToString() + "元";
                    label9.Text = "猜數字一輪10元，現在有" + money.ToString() + "元";
                }
                else if(win<=0)
                {
                    label10.Text = "猜中了，猜了" + count.ToString() + "次，沒有獎勵";
                    if(money<=0)
                    {
                        button5.Enabled = false;
                        label9.Text = "猜數字一輪10元，籌碼用盡";
                    }
                }
                count = 0;
            }
            else if(b > a)
            {
                label10.Text = "太大";
            }
            else if (b < a)
            {
                label10.Text = "太小";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button a = sender as Button;
            Random r = new Random();
            if (a.Text=="開始")
            {
                guess1 = 0;
                guess2 = 100;
                count2 = -1;
                a.Enabled = false;
                guess = r.Next(0, 100);
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
            }
            count2 = count2 + 1;
            if (a.Text=="太小")
            {
                guess1 = guess + 1;
                guess = r.Next(guess1, guess2);
            }
            if (a.Text == "太大")
            {
                guess2 = guess;
                guess = r.Next(guess1, guess2);
            }
            label12.Text = guess.ToString();
            if (a.Text == "答對" || guess1 == guess2)
            {
                button9.Enabled = true;
                label12.Text = "猜了"+count2.ToString()+"次，答案是"+guess.ToString();
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            double a, b, c, d, r;
            a = double.Parse(textBox6.Text);
            b = double.Parse(textBox7.Text);
            r = a + b;
            if (textBox8.Text != "")
            {
                c = double.Parse(textBox8.Text);
                r = r + c;
                if(textBox9.Text != "")
                {
                    d = double.Parse(textBox9.Text);
                    r = r + d;
                }
            }
            label13.Text = "R=" + r.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            double a, b, c, d, r;
            a = double.Parse(textBox6.Text);
            b = double.Parse(textBox7.Text);
            r = (1/a + 1/b);
            if (textBox8.Text != "")
            {
                c = double.Parse(textBox8.Text);
                r = 1 / (1 / a + 1 / b + 1 / c);
                if (textBox9.Text != "")
                {
                    d = double.Parse(textBox9.Text);
                    r = 1 / (1 / a + 1 / b + 1 / c + 1 / d);
                }
            }
            label13.Text = "R=" + r.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {

            Random r = new Random();
            if(button12.Text=="開始")
            {
                A = r.Next(10, 100);
                b = r.Next(10, 100);
                c = r.Next(10, 100);
                d = A + b + c;
                label14.Text = A.ToString() + "+" + b.ToString() + "+" + c.ToString() + "=?";
                button12.Text = "作答";
            }
            else if (button12.Text == "作答")
            {
                if (int.Parse(textBox10.Text) == d)
                {
                    label14.Text = A.ToString() + "+" + b.ToString() + "+" + c.ToString() + "=" + d.ToString() + "，正確";
                }
                else if (int.Parse(textBox10.Text) != a + b + c)
                {
                    label14.Text = A.ToString() + "+" + b.ToString() + "+" + c.ToString() + "=" + d.ToString() + "，錯誤";
                }
                button12.Text = "開始";
            }
        }

    }
}
