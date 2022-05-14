using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, d;
            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            c = double.Parse(textBox3.Text);

            d = b * b - 4 * a * c;

            if(d==0)
            {
                label4.Text = "方程式有一解，x=" + (-b / 2 * a).ToString();
            }
            else if(d<0)
            {
                label4.Text = "方程式無解";
            }
            else if(d>0)
            {
                label4.Text = "方程式為兩解，x1=" + ((-b+Math.Sqrt(d))/a/2).ToString()+",x2=" + ((-b - Math.Sqrt(d)) / a / 2).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a1, b1, c1, a2, b2, c2, d;
            a1 = double.Parse(textBox4.Text);
            b1 = double.Parse(textBox5.Text);
            c1 = double.Parse(textBox6.Text);
            a2 = double.Parse(textBox7.Text);
            b2 = double.Parse(textBox8.Text);
            c2 = double.Parse(textBox9.Text);
            d = a1 * b2 - a2 * b1;
            if( a1/ a2 == b1/ b2 && a1 / a2 == c1 / c2)
            {
                label5.Text = "兩直線重合，方程式為無限多組解";
            }
            else if(d==0)
            {
                label5.Text = "兩直線平行，方程式為無解";
            }
            else
            {
                label5.Text = "x=" + ((c1 * b2 - c2 * b1) / d).ToString() + ",y=" + ((a1 * c2 - a2 * c1) / d).ToString();
            }
        }
    }
}
