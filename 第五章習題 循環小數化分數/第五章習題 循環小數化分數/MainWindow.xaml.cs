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

namespace 第五章習題_循環小數化分數
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        int count(string a)
        {
            a = "1" + a;
            int b= int.Parse(a);
            return (int)Math.Log10(b);
        }

        int cf(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (a >= 0 || a < 0)
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int a, b=0, c,x1=0,x2=1,final1,final2;
            a = int.Parse(textBox1.Text);
            c = int.Parse(textBox3.Text);

            if (textBox2.Text != "")
            {
                b= int.Parse(textBox2.Text);
                x1 = count(textBox2.Text);
            }
            else
            {
                x1 = 0;
            }
            x2 = count(textBox3.Text);
            a = a * (int)(Math.Pow(10, x1))+b;
            b = a * (int)(Math.Pow(10, x2)) + c;
            final2 = (int)(Math.Pow(10, x1 + x2)) - (int)(Math.Pow(10, x1));
            final1 = b - a;
            label1.Content = (final1 / cf(final1, final2)).ToString();
            label2.Content = (final2 / cf(final1, final2)).ToString();
        }
    }
}
