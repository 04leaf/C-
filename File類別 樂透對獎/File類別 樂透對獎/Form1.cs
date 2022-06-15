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
namespace File類別_樂透對獎
{
    public partial class Form1 : Form
    {

        string[] a = new string[7];
        string[] b = new string[7];
        int i;
        TextBox[] t = new TextBox[7];

        public Form1()
        {
            InitializeComponent();
            for (i=0;i<7;i++)
            {
                t[i] = new TextBox();
                t[i].Width = 190;
                t[i].Height = 22;
                t[i].Top =12+i*28;
                t[i].Left = 44;
                Controls.Add(t[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("G://C#檔案//data2.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs, Encoding.UTF8);
            for(i=0;i<7;i++)
            {
                a[i] = sr.ReadLine();
                b[i] = t[i].Text;
            }
            label1.Text = "沒有中獎";
            bool win;

            for(i=0;i<7;i++)
            {
                win = true;
                if (a[i] != b[i])
                {
                    win = false;
                }

                if(win)
                {
                    label1.Text = "第" + (i+1).ToString() + "組號碼中了";
                    break;
                }
            }
            sr.Close();
            fs.Close();
        }
    }
}
