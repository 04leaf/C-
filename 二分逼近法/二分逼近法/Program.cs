using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 二分逼近法
{
    class Program
    {
        //立方根
        /* 
        static void Main(string[] args)
        {
            double a,b,x1, x2;
            Console.WriteLine("輸入一正數求立方根");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("輸入精確度");
            b = double.Parse(Console.ReadLine());
            x1 = a;
            x2 = 0;
            do
            {
                if(((x1+x2)/2)*((x1+x2)/2) * ((x1 + x2) / 2) > a)
                {
                    x1 = (x1 + x2) / 2;
                }
                else if (((x1 + x2) / 2) * ((x1 + x2) / 2) * ((x1 + x2) / 2) <= a)
                {
                    x2 = (x1 + x2) / 2;
                }
            }
            while (Math.Abs(x1 - x2) > b);
            Console.WriteLine(x2);
            Console.ReadLine();
        }
        */

        //兩數相除
        static void Main(string[] args)
        {
            double a1,a2, b, x1, x2;
            Console.WriteLine("輸入被除數");
            a1 = double.Parse(Console.ReadLine());
            Console.WriteLine("輸入除數");
            a2 = double.Parse(Console.ReadLine());
            Console.WriteLine("輸入精確度");
            b = double.Parse(Console.ReadLine());
            x1 = a1;
            x2 = 0;
            do
            {
                if (a2* ((x1 + x2) / 2) > a1)
                {
                    x1 = (x1 + x2) / 2;
                }
                else if (a2 * ((x1 + x2) / 2) <= a1)
                {
                    x2 = (x1 + x2) / 2;
                }
            }
            while (Math.Abs(x1 - x2) > b);
            Console.WriteLine(x2);
            Console.ReadLine();
        }

    }
}
