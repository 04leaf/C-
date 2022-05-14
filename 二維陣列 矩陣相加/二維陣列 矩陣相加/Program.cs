using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 二維陣列_矩陣相加
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr1 = new int[,]
            {
                {2,-1},
                {5,4},
                {0,3}
            };
            int[,] arr2 = new int[,]
            {
                {4,-1},
                {1,4},
                {6,-2}
            };
            int i, j;
            for(i=0;i<=2;i++)
            {
                for(j=0;j<=1;j++)
                {
                    Console.Write(arr1[i, j] + arr2[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
