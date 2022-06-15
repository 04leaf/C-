using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace File類別_電話號碼讀寫
{
    public partial class Form1 : Form
    {
        FileStream fs;
        StreamReader sr;
        StreamWriter sw;

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fs = new FileStream("G://C#檔案//data3.txt", FileMode.Open);
            sr = new StreamReader(fs, Encoding.UTF8);

            sr.BaseStream.Position = (long.Parse(label1.Text)-1)*21;

            string[] temp = new string[] { };
            temp=sr.ReadLine().Split(',');
            textBox1.Text = temp[0];
            textBox2.Text = temp[1];
            sr.Close();
            fs.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(label1.Text!="1")
            {
                label1.Text = (int.Parse(label1.Text) - 1).ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fs = new FileStream("G://C#檔案//data3.txt", FileMode.Open);
            sr = new StreamReader(fs, Encoding.UTF8);
            sr.BaseStream.Position = long.Parse(label1.Text)*26;
            if (sr.ReadLine()!=null)
            {
                label1.Text = (int.Parse(label1.Text) + 1).ToString();
            }
            sr.Close();
            fs.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fs = new FileStream("G://C#檔案//data3.txt", FileMode.Open);
            sw = new StreamWriter(fs, Encoding.UTF8);
            sr = new StreamReader(fs, Encoding.UTF8);

            while (sr.ReadLine() != null)
            {
                label1.Text = (int.Parse(label1.Text)+1).ToString();
            }
            label1.Text = (int.Parse(label1.Text) - 1).ToString();
            sw.BaseStream.Position = (long.Parse(label1.Text)) * 21+3;
            sw.WriteLine(textBox1.Text + "," + textBox2.Text);
            sw.Close();
            sr.Close();
            fs.Close();

        }
    }
}
