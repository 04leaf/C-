using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        double fun(double a)
        {
            if (a <= 1)
            {
                return 1;
            }
            else
            {
                double c = a * fun(a - 1);
                return c;
            }
        }

        static void Main(string[] args)
        {
            //sin xdx=2
            /*
            double sum = 0;
            double x, y, dx = 0.01f;
            for (x = 0; x <= Math.PI; x = x + dx)
            {
                y = Math.Sin(x);
                sum = sum + y * dx;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
            */

            // cos x
            /*
            double sum = 0;
            Console.WriteLine("輸入角度求cos x值");
            double x= double.Parse(Console.ReadLine()), y,r;
            Console.WriteLine("輸入dx精密度");
            double dx = double.Parse(Console.ReadLine());
            r = Math.PI * x / 180;
            Console.WriteLine("輸入n精密度");
            int n ,ntop = int.Parse(Console.ReadLine());
            for (x = 0; x <= r; x = x + dx)
            {
                for(n=0;n<=ntop;n++)
                {
                    y = Math.Pow(-1,n)/(new Program().fun(2*n))*Math.Pow(x,2*n);
                    sum = sum + y * dx;
                }
            }
            Console.WriteLine(sum);
            Console.ReadLine();
            */

            //n!/n^n
            /*
            int n = 1;
            Console.WriteLine("輸入精密度證n!/n^n=0");
            double d = double.Parse(Console.ReadLine());

            while((double)new Program().fun(n)/Math.Pow(n,n)>d)
            {
                Console.WriteLine((double)new Program().fun(n) / Math.Pow(n, n));
                n = n + 1;
            }
            Console.ReadLine();
            */

            //累加n^2-n-1/n!=1

            double n = 1, sum =0 ;
            Console.WriteLine("輸入精密度累加n^2-n-1/n!=1");
            double d = double.Parse(Console.ReadLine());
            do
            {
                if(new Program().fun(n)>0)
                {
                    sum = sum + (n * n - n - 1) / (new Program().fun(n));
                    Console.WriteLine(sum);
                    n = n + 1;
                }
            }
            while (Math.Abs(sum - 1) > d);
            Console.ReadLine();
        }
    }
}
