using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第五章習題_單位元面積
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入精準度求單位圓面積");
            double dx = double.Parse(Console.ReadLine());
            double x, y, sum = 0;
            for (x = 0; x <= 1; x = x + dx)
            {
                y = Math.Sqrt(1 - x * x);
                sum = sum + y * dx;
            }
            Console.WriteLine(sum * 4);
            Console.ReadLine();
        }
    }
}
