using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using horng;

namespace 自訂類別庫使用
{
    class Program
    {
        static void Main(string[] args)
        {
            fraction a = new fraction(1, 2);
            fraction b = new fraction(1, 3);
            fraction c;
            c = a + b;
            Console.WriteLine(c);
            Console.WriteLine(c.ToString());

            Console.ReadLine();
        }
    }
}
