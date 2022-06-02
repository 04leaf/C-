using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第七章習題_階乘數列和
{
    class Program
    {
        static int pow(int n)
        {
            if (n == 1)
            {
                return n;
            }
            else
            {
                return n * pow(n - 1);
            }
        }

        static double pow2(double n)
        {
            if (n == 1)
            {
                return n;
            }
            else
            {
                return 1/n + pow2(n - 1);
            }
        }

        static void Main(string[] args)
        {
            int sum = 0, n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                sum = sum + pow(i);
            }
            double sum2=0;
            Console.WriteLine("階乘數列和為"+sum.ToString());
            for (int i = 1; i <= n; i++)
            {
                sum2 = sum2 + pow2(i);
            }
            Console.WriteLine("倒數累加數列和為" + sum2.ToString());
            Console.ReadLine();
        }
    }
}
