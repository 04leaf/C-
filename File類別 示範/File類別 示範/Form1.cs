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

namespace File類別_示範
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo("G:\\C#檔案\\test.txt");
            FileStream fs = fi.Create();
            label1.Text = "檔案路徑："+ fi.DirectoryName;
            label2.Text = "檔案名稱：" + fi.Name;
            label3.Text = "副檔名 ：" + fi.Extension;
            label4.Text = "完整檔名：" + fi.FullName;
            label5.Text = "檔案長度：" + fi.Length;
            label6.Text = "檔案屬性：" + fi.Attributes;
            fs.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo("G:\\C#檔案\\test.txt");
            if(!fi.Exists)
            {
                MessageBox.Show(this, fi.FullName + "不存在");
                return;
            }
            FileStream fs = fi.Open(FileMode.Open);
            label1.Text = "檔案路徑：" + fi.DirectoryName;
            label2.Text = "檔案名稱：" + fi.Name;
            label3.Text = "副檔名 ：" + fi.Extension;
            label4.Text = "完整檔名：" + fi.FullName;
            label5.Text = "檔案長度：" + fi.Length;
            label6.Text = "檔案屬性：" + fi.Attributes;
            fs.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo("G:\\C#檔案\\test.txt");
            FileInfo fc = new FileInfo("G:\\C#檔案\\copy.txt");
            fi.CopyTo(fc.FullName, true);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo("G:\\C#檔案\\test.txt");
            if (!fi.Exists)
            {
                MessageBox.Show(this, fi.FullName + "不存在");
                return;
            }
            else
            {
                fi.Delete();
                MessageBox.Show(this, fi.FullName + "刪除成功");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo("G:\\C#檔案\\test.txt");
            if (!fi.Exists)
            {
                MessageBox.Show(this, fi.FullName + "不存在");
                return;
            }
            //FileStream fs = new FileStream(fi.FullName, FileMode.Open);
            StreamReader sr = new StreamReader("G:\\C#檔案\\test.txt", Encoding.UTF8);
            textBox1.Text = "";
            char[] read = new char[sr.BaseStream.Length];
            sr.Read(read, 0, read.Length);

            for(int i=0;i<read.Length;i++)
            {
                textBox1.Text = textBox1.Text + read[i];
            }
            //fs.Close();
            sr.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo("G:\\C#檔案\\test.txt");
            if (!fi.Exists)
            {
                MessageBox.Show(this, fi.FullName + "不存在");
                return;
            }
            FileStream fs = new FileStream(fi.FullName, FileMode.Open);
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
            sw.Write(textBox2.Text);
            sw.Close();
            fs.Close();
        }
    }
}
