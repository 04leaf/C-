using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第八章習題_乘法直式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入被乘數a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("輸入乘數b");
            double b = double.Parse(Console.ReadLine());
            int mc = 0;
            double a1=a, b1=b;
            int i;

            if (a.ToString().Contains('.'))
            {
                mc = a.ToString().Length - a.ToString().IndexOf('.')-1;
                a1 = double.Parse(a.ToString().Remove(a.ToString().IndexOf('.'),1));
            }
            if (b.ToString().Contains('.'))
            {
                mc = mc+b.ToString().Length - b.ToString().IndexOf('.')-1;
                b1= double.Parse(b.ToString().Remove(b.ToString().IndexOf('.'),1));
            }

            int bmc = b1.ToString().Length;
            double[] c = new double[bmc];
            string[] c1 = new string[bmc];
            double d = 0;
            int amc = (int)Math.Log10(b1 / b)-1;
            for(i=0;i<bmc;i++)
            {
                string b2 = "";
                b2 = "" + b1.ToString()[bmc - i - 1];
                c[i] = a1 * double.Parse(b2);
                d = d + c[i] * Math.Pow(10, i);
                c[i]=c[i]/ Math.Pow(10, bmc-i)/Math.Pow(10,amc);
                c1[i] = c[i].ToString();
                for(int j=0;j<i;j++)
                {
                    c1[i] = c1[i]+' ';
                }
            }
            Console.WriteLine();

            d = d / Math.Pow(10, mc);

            Console.WriteLine(a.ToString().PadLeft(d.ToString().Length));
            Console.WriteLine("*"+b.ToString().PadLeft(d.ToString().Length-1));
            Console.WriteLine("--------------------------");
            for(i=0;i<c1.Length;i++)
            {
                Console.WriteLine(c1[i].PadLeft(d.ToString().Length));
            }
            Console.WriteLine("--------------------------");
            Console.WriteLine(d.ToString());
            Console.ReadLine();
        }
    }
}
