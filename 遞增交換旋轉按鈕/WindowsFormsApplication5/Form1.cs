using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        int a = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a++;
            label1.Text = a.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a=a+10;
            label1.Text = a.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a--;
            label1.Text = a.ToString();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            a = a - 10;
            label1.Text = a.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int b, c,t;
            b = int.Parse(textBox1.Text);
            c = int.Parse(textBox2.Text);
            t = b;
            b = c;
            c = t;
            textBox1.Text = b.ToString();
            textBox2.Text = c.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int t;
            t = int.Parse(label2.Text);
            label2.Text = label5.Text;
            label5.Text = label4.Text;
            label4.Text = label3.Text;
            label3.Text = t.ToString();
        }
    }
}
