using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 動態控制項_矩陣相乘
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int i, j, k, m, n, p, t;
        private void button1_Click(object sender, EventArgs e)
        {
            /*
            if (Controls.Find("i", true).Length > 0)
            {
                int count = Controls.Find("i", true).Length;
                TextBox[] remove = new TextBox[count];
                for (i = 0; i < count; i++)
                {
                    remove[i] = (TextBox)Controls.Find("i", true)[i];
                }
                for (i = 0; i < count; i++)
                {
                    Controls.Remove(remove[i]);
                }
            }
            */
            button1.Enabled = false;
            button2.Enabled = true;
            m = int.Parse(textBox1.Text);
            n = int.Parse(textBox2.Text);
            p = int.Parse(textBox3.Text);
            t = m;
            if(m>n)
            {
                t = n;
            }
            TextBox[,] cin = new TextBox[p, m];
            for (i = 0; i < p; i++)
            {
                for (j = 0; j < m; j++)
                {
                    cin[i, j] = new TextBox();
                    cin[i, j].Top = 50 + 30 * i;
                    cin[i, j].Left = 30 + 60 * j;
                    cin[i, j].Width = 50;
                    cin[i, j].Name = "c0i" + i.ToString() + "j" + j.ToString();
                    Controls.Add(cin[i, j]);
                }
            }
            cin = new TextBox[n, p];
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < p; j++)
                {
                    cin[i, j] = new TextBox();
                    cin[i, j].Top = 50 + 30 * i;
                    cin[i, j].Left = 60 + 60 * j+60*m;
                    cin[i, j].Width = 50;
                    cin[i, j].Name = "c1i" + i.ToString() + "j" + j.ToString();
                    Controls.Add(cin[i, j]);
                }
            }
        }


        TextBox[,] cout;


        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            cout = new TextBox[p, p];
            int a=0, b=0;

            for (i = 0; i < p; i++)
            {
                for (j = 0; j < p; j++)
                {
                    cout[i, j] = new TextBox();
                    cout[i, j].Top = 50 + 30 * i;
                    cout[i, j].Left = 90 + 60 * j + 60 * (m+p);
                    cout[i, j].Width = 50;

                    int sum = 0;
                    for(k=0;k<t;k++)
                    {
                        a = int.Parse(((TextBox)Controls.Find("c0i" + i.ToString() + "j" + k.ToString(), true)[0]).Text);
                        b = int.Parse(((TextBox)Controls.Find("c1i" + k.ToString() + "j" + j.ToString(), true)[0]).Text);
                        sum = sum + a * b;
                    }
                    cout[i, j].Text = sum.ToString();

                    cout[i, j].Name = "c2i" + i.ToString() + "j" + j.ToString();
                    Controls.Add(cout[i, j]);
                }
            }
        }
    }
}
