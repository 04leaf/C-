using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 動態控制項_矩陣相加相乘
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int i, j, k, m, n;

        private void button1_Click(object sender, EventArgs e)
        {
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
            button1.Enabled = false;
            button2.Enabled = true;
            m = int.Parse(textBox2.Text);
            n = int.Parse(textBox1.Text);
            for (i = 0; i <= 1; i++)
            {
                TextBox[,] cin = new TextBox[m, n];
                for (j = 0; j < m; j++)
                {
                    for (k = 0; k < n; k++)
                    {
                        cin[j, k] = new TextBox();
                        cin[j, k].Top = 50 + 30 * j;
                        cin[j, k].Left = 30 + 60 * k + (60 * n + 30) * i;
                        cin[j, k].Width = 50;
                        cin[j, k].Name = "i" + i.ToString() + "j" + j.ToString() + "k" + k.ToString();
                        Controls.Add(cin[j, k]);
                    }
                }
            }
        }
        TextBox[,] cout;
        private void button2_Click(object sender, EventArgs e)
        {

            button2.Enabled = false;
            cout = new TextBox[m, n];

            int a = 0, b = 0;
            for (j = 0; j < m; j++)
            {
                for (k = 0; k < n; k++)
                {
                    cout[j, k] = new TextBox();
                    a = int.Parse(((TextBox)Controls.Find("i0" + "j" + j.ToString() + "k" + k.ToString(), true)[0]).Text);
                    b = int.Parse(((TextBox)Controls.Find("i1" + "j" + j.ToString() + "k" + k.ToString(), true)[0]).Text);
                    cout[j, k].Top = 50 + 30 * j;
                    cout[j, k].Left = 30 + 60 * k + (60 * n + 30) * 2;
                    cout[j, k].Width = 50;
                    cout[j, k].Text = (a + b).ToString();
                    cout[j, k].Name = "i2" + "j" + j.ToString() + "k" + k.ToString();
                    Controls.Add(cout[j, k]);
                }
            }

        }
    }
}
