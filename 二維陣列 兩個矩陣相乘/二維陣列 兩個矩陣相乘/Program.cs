using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 二維陣列_兩個行列式
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[,]
            {
                {-1,0,3},
                {2,1,-2}
            };
            int[,] b = new int[,]
            {
                {1,0},
                {2,-3},
                {-1,4}
            };
            int[,] c = new int[,]
            {
                {0,0},
                {0,0}
            };

            int i, j;
            for (i = 0; i <= 3; i++)
            {
                for (j = 0; j <= 2; j++)
                {
                    c[i / 2, i % 2] = c[i / 2, i % 2] + a[i / 2, j] * b[j, i % 2];
                }
                if (i!=0 &&i % 2 == 0)
                {
                    Console.WriteLine();
                }
                Console.Write(c[i / 2, i % 2] + " ");
            }
            Console.ReadLine();
        }
    }
}
