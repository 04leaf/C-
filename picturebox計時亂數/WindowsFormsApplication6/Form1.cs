using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        int original,t,r1;
        Random r = new Random();

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("E:/desktop/東方圖片/_ashyzzz_-1424884103854366720-2.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            timer1.Interval = 1;
            timer1.Enabled = true;
            original = pictureBox1.Left;

            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Width = pictureBox1.Width /10+pictureBox1.Width;
            pictureBox1.Height= pictureBox1.Height / 10 + pictureBox1.Height;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Width = pictureBox1.Width- pictureBox1.Width / 10;
            pictureBox1.Height = pictureBox1.Height- pictureBox1.Height / 10 ;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Top = pictureBox1.Top - 5;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Top = pictureBox1.Top + 5;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Left = pictureBox1.Left - 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox1.Left = pictureBox1.Left + 5;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*
            pictureBox1.Width = pictureBox1.Width / 100 + pictureBox1.Width;
            pictureBox1.Height = pictureBox1.Height / 100 + pictureBox1.Height;
            */
            pictureBox1.Left = pictureBox1.Left + 2;
            if(pictureBox1.Left>=500)
            {
                pictureBox1.Left = original;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (timer2.Enabled == false)
            {
                t = 0;
                timer2.Interval = 1;
                timer2.Enabled = true;
            }
            else if (timer2.Enabled == true)
            {
                timer2.Enabled = false;
                label1.Text ="time:" +t.ToString()+"ms";
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            t = t + 1;
            label1.Text = "time:" + t.ToString() + "ms";
            r1 = r.Next(1000);
            label2.Text = r1.ToString();

        }
    }
}
