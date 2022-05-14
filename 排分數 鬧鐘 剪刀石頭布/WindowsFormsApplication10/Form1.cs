using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication10
{
    public partial class Form1 : Form
    {
        int s, m, h,wp=0,wc=0;
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Enabled = true;
            label10.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int a, b, c, t=0;
            string x, y, z, t1 = "";
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            c = int.Parse(textBox3.Text);
            x = textBox4.Text;
            y = textBox5.Text;
            z = textBox6.Text;

            if (a>b)
            {
                t = a;
                a = b;
                b = t;

                t1 = x;
                x = y;
                y = t1;
                if (b > c)
                {
                    t = b;
                    b = c;
                    c = t;

                    t1 = y;
                    y = z;
                    z = t1;
                }
            }
            if (a > b)
            {
                t = a;
                a = b;
                b = t;

                t1 = x;
                x = y;
                y = t1;
            }
            label1.Text = x + a.ToString() + "分," + y + b.ToString() + "分," + z + c.ToString() + "分";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            s = s + 1;
            if(s>=60)
            {
                s = 0;
                m = m + 1;
            }
            if(m>=60)
            {
                m = 0;
                h = h + 1;
            }
            if(h>=11)
            {
                h = 0;
                if(label7.Text=="上午")
                {
                    label7.Text = "下午";
                }
                else if (label7.Text == "下午")
                {
                    label7.Text = "上午";
                }
            }
            label4.Text = h.ToString();
            label5.Text = m.ToString();
            label6.Text = s.ToString();
            if(h==0)
            {
                if(m==0)
                {
                    if(s==5)
                    {
                        Console.Beep();
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int r1;
            string c="";
            Random r=new Random();
            r1=r.Next(0, 3);
            switch(r1)
            {
                case 0:
                    c = "剪刀";
                    break;
                case 1:
                    c = "石頭";
                    break;
                case 2:
                    c = "布";
                    break;
            }
            string n = (sender as Button).Text;


            switch(n)
            {
                case "剪刀":
                    switch (c)
                    {
                        case "剪刀":
                            label8.Text = "平手";
                            break;
                        case "石頭":
                            label8.Text = "你輸了";
                            wc = wc + 1;
                            break;
                        case "布":
                            label8.Text = "你贏了";
                            wp = wp + 1;
                            break;
                    }
                    break;
                case "石頭":
                    switch (c)
                    {
                        case "剪刀":
                            label8.Text = "你贏了";
                            wp = wp + 1;
                            break;
                        case "石頭":
                            label8.Text = "平手";
                            break;
                        case "布":
                            label8.Text = "你輸了";
                            wc = wc + 1;
                            break;
                    }
                    break;
                case "布":
                    switch (c)
                    {
                        case "剪刀":
                            label8.Text = "你輸了";
                            wc = wc + 1;
                            break;
                        case "石頭":
                            label8.Text = "你贏了";
                            wp = wp + 1;
                            break;
                        case "布":
                            label8.Text = "平手";
                            break;
                    }
                    break;

            }
            label8.Text = "你出" + n + "\n電腦出" + c + "\n"+label8.Text ;
            label9.Text = "勝負結果\n你贏了" + wp.ToString() + "次\n電腦贏" + wc.ToString() + "次";
            if(label10.Text=="")
            {
                if (wc >= 3)
                {
                    label10.Text = "電腦勝";
                }
                if (wp >= 3)
                {
                    label10.Text = "玩家勝";
                }
            }
        }
    }
}
