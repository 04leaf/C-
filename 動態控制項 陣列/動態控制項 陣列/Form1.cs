using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 動態控制項_陣列
{
    public partial class Form1 : Form
    {
        TextBox[] txta;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            txta = new TextBox[a];
            for (int i = 0; i <= a-1; i++)
            {
                txta[i] = new TextBox();
                txta[i].Left = 30;
                txta[i].Top = 60 + 30 * i;
                txta[i].Text = i.ToString();
                this.Controls.Add(txta[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int sum = 0;
            for (int i = 0; i <= a - 1; i++)
            {
                sum = sum + int.Parse(txta[i].Text);
            }
            label2.Text = "平均值為" + sum / a;
        }
    }
}
