using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace 第五章習題_分數四則運算
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        //最大公因數
        int cf(int a,int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (a>=0 || a<0)
            {
                if (b > a)
                {
                    int t = a;
                    a = b;
                    b = t;
                }
                if (b == 0)
                {
                    return a;
                }
                a = a % b;
            }
            return 1;
        }
        //最小公倍數
        int cm(int a,int b)
        {
            return a*b/cf(a, b);
        }

        public MainWindow()
        {
            InitializeComponent();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int a1, a2, b1, b2,x1=1,x2=2;
            Button btn = sender as Button;
            a1 = int.Parse(textBox1.Text);
            a2 = int.Parse(textBox2.Text);
            b1 = int.Parse(textBox3.Text);
            b2 = int.Parse(textBox4.Text);
            switch(btn.Name)
            {
                case "button1":
                    x2 = cm(a2, b2);
                    x1 = x2 / a2 * a1 + x2 / b2 * b1;
                    break;
                case "button2":
                    x2 = cm(a2, b2);
                    x1 = x2 / a2 * a1 - x2 / b2 * b1;
                    break;
                case "button3":
                    x2 = a2 * b2;
                    x1 = a1 * b1;
                    break;
                case "button4":
                    x2 = a2*b1;
                    x1 = a1*b2;
                    break;
            }
            if(x1==x2)
            {
                label1.Content = 1.ToString();
            }
            else if(x1*(-1)==x2)
            {
                label1.Content = (-1).ToString();
            }
            else
            {
                label1.Content = (x1 / cf(x1, x2)).ToString();
                label2.Content = (x2 / cf(x1, x2)).ToString();
            }
        }
    }
}
