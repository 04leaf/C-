using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x1, y1, x2,y2,z1,z2,c1,c2,x3,y3,z3,c3;
            double d,x, y,z;
            x1 = int.Parse(textBox1.Text);
            y1 = int.Parse(textBox2.Text);
            x2 = int.Parse(textBox3.Text);
            y2 = int.Parse(textBox4.Text);
            z1 = int.Parse(textBox5.Text);
            z2 = int.Parse(textBox6.Text);
            c1 = int.Parse(textBox7.Text);
            c2 = int.Parse(textBox8.Text);

            x3 = int.Parse(textBox9.Text);
            y3 = int.Parse(textBox10.Text);
            z3 = int.Parse(textBox11.Text);
            c3 = int.Parse(textBox12.Text);

            d = x1*y2*z3+x2*y3*z1+x3*y1*z2-x3*y2*z1-y3*z2*x1-z3*y1*x2;
            x = (c1*y2*z3+y1*z2*c3+z1*c2*y3-z1*y2*c3-y1*c2*z3-c1*z2*y3) / d;
            y = (x1*c2*z3+c1*z2*x3+z1*x2*c3-z1*c2*x3-c1*x2*z3-x1*z2*c3) / d;
            z = (x1*y2*c3+y1*c2*x3+c1*x2*y3-c1*y2*x3-y1*x2*c3-x1*c2*y3) / d;

            label4.Text = "x="+x.ToString();
            label5.Text = "y="+y.ToString();
            label7.Text = "z="+z.ToString();
        }
    }
}
