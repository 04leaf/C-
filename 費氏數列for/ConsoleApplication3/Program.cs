using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b, i,f1=1,f2=1;
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("1");
            Console.WriteLine("1");
            for (i=3;i<=b;i++)
            {
                a = f1 + f2;
                f1 = f2;
                f2 = a;
                Console.WriteLine(a);
            }
            Console.ReadLine();
        }
    }
}
