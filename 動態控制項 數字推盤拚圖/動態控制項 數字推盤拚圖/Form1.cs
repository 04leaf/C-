using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 動態控制項_數字推盤拚圖
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Visible = false;

        }

        int pos, a;
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            //初始化
            a = 3;
            Button start = sender as Button;
            if (start.Text == "中等")
            {
                a = 5;
            }
            else if (start.Text == "困難")
            {
                a = 7;
            }
            int[] b = new int[a * a];

            //產生亂數陣列b
            Random random = new Random();
            for (int i = 0; i < b.Length; i++)
            {
                int c = 0;
                bool end = true;
                while (end)
                {
                    end = false;
                    c = random.Next(1, b.Length + 1);
                    for (int j = 0; j < i; j++)
                    {
                        if (c == b[j])
                        {
                            end = true;
                        }
                    }
                }

                b[i] = c;
            }

            //動態生成控制項
            pos = 0;
            Button[] btn = new Button[b.Length];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {

                    btn[i * a + j] = new Button();
                    btn[i * a + j].Left = 20 + 30 * j;
                    btn[i * a + j].Top = 20 + 30 * i;
                    btn[i * a + j].Height = 30;
                    btn[i * a + j].Width = 30;
                    btn[i * a + j].Text = b[i * a + j].ToString();
                    btn[i * a + j].Name = "btn" + (i * a + j + 1).ToString();
                    btn[i * a + j].Click += new System.EventHandler(button2_Click);
                    Controls.Add(btn[i * a + j]);
                    if (b[i * a + j] == a * a)
                    {
                        btn[i * a + j].Visible = false;
                        pos = i * a + j + 1;
                    }
                    btn[i * a + j].Click += new System.EventHandler(button2_Click);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //交換按鈕
            Button btn = sender as Button;
            Button space = (Button)Controls.Find("btn" + pos.ToString(), true)[0];
            int index = int.Parse(btn.Name.Substring(3));
            if ((Math.Abs(index -pos)==1 && (pos%a)+(index%a)!=1) || index == pos + a || index == pos - a)
            {

                int t = index;
                index = pos;
                pos = t;
                
                Button Cself = new Button();
                Cself.Top = space.Top;
                Cself.Left = space.Left;
                Cself.Name = space.Name;
                Cself.Text = btn.Text;
                Cself.Height = 30;
                Cself.Width = 30;
                Cself.Click+= new System.EventHandler(button2_Click);
                Controls.Add(Cself);

                Button Cspace = new Button();
                Cspace.Top = btn.Top;
                Cspace.Left = btn.Left;
                Cspace.Name = btn.Name;
                Cspace.Text = space.Text;
                Cspace.Height = 30;
                Cspace.Width = 30;
                Cspace.Click += new System.EventHandler(button2_Click);
                Cspace.Visible = false;
                Controls.Add(Cspace);

                Controls.Remove(btn);
                Controls.Remove(space);
            }

            //掃描答案
            bool clear = true;
            for(int i=1;i<=a*a;i++)
            {
                Button btnclear = (Button)Controls.Find("btn" + i.ToString(), true)[0];
                if (int.Parse(btnclear.Text)!=i)
                {
                    clear = false;
                }
            }
            if(clear)
            {
                for (int i = 1; i <= a * a; i++)
                {
                    Button btnclear = (Button)Controls.Find("btn" + i.ToString(), true)[0];
                    btnclear.Enabled = false;
                }
                label2.Visible = true;
            }
        }
    }
}
