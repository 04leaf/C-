using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法_河內塔
{
    class Program
    {
        static void move(int n, char source, char goal, char aux)
        {
            if (n == 1)
            {
                Console.WriteLine("環" + n + "從" + source + "搬到" + goal);
            }
            else
            {
                move(n - 1, source, aux, goal);
                Console.WriteLine("環" + n + "從" + source + "搬到" + goal);
                move(n - 1, aux, goal, source);
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            move(n, 'A', 'B', 'C');
            Console.ReadLine();
        }
    }
}
