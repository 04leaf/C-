using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法_費氏數列
{
    class Program
    {
        static int fib(int n)
        {
            if(n>2)
            {
                return fib(n - 1) + fib(n - 2);
            }
            else
            {
                return 1;
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                Console.WriteLine(fib(i).ToString());
            }
            Console.ReadLine();
        }
    }
}
