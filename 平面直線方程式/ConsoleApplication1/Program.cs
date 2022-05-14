using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double a, b,c,d,e,f;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
            e = (d-b)/(c-a)*(-1);
            f = e * a - b;
            Console.WriteLine("{0:F1}x+y+{1:F1}=0", e,f);
            
            /*
            double a, b, c, d, e;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
            e = int.Parse(Console.ReadLine());
            Console.WriteLine("{0:F1},{1:F1},{2:F1},{3:F1},{4:F1}", a,b,c,d,e);
            Console.WriteLine(a+b+c+d+e);
            Console.WriteLine((a + b + c + d + e)/5);
            */
        }
    }
}
