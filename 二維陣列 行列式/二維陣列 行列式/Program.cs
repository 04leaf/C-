using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 二維陣列_行列式
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[,]
            {
                {2,4,-2},
                {0,3,1},
                {0,2,8}
            };
            int i, j,sum=0;
            for(i=0;i<=2;i++)
            {
                for (j=0;j<=2;j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
                sum = sum + arr[i, 0] * arr[(i + 1) % 3, (i + 1) % 3] * arr[(i + 2) % 3, (i + 2) % 3] - arr[i, 0] * arr[(i + 2) % 3, (i + 1) % 3] * arr[(i + 1) % 3, (i + 2) % 3];
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
