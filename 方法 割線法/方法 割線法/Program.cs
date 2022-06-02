using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法_割線法
{
    class Program
    {
        static double f(double x)
        {
            double y = x * x * x - 10.1 * x * x + 7.48 * x + 52.02;
            return y;
        }
        static double a;
        static Random r = new Random();

        static double sec(double x0,double x1)
        {
            double x2,slope;
            slope =(f(x1)-f(x0))/ (x1 - x0);
            x2 = x0 - f(x0) / slope;
            if(Math.Abs(x0-x1)<a)
            {
                return x0;
            }
            else
            {
                return sec(x1, x2);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("輸入精準度以割線法求x^3-10.1x^2+7.48x+52.02=0的解");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine(sec(r.NextDouble(), 5-r.NextDouble()));
            Console.WriteLine(sec(6-r.NextDouble(), 10-r.NextDouble()));
            Console.WriteLine(sec(-5-r.NextDouble(), 0-r.NextDouble()));
            Console.ReadLine();
        }
    }
}
