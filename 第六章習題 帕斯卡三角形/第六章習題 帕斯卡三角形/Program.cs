using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第六章習題_帕斯卡三角形
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a;
            int[] b = new int[1] {1};
            int c = 6;
            for(int i=1;i<=c;i++)
            {
                for (int j = i; j < c; j++)
                {
                    Console.Write("  ");
                }
                a = b;
                for (int j = 0; j < a.Length; j++)
                {
                    Console.Write(a[j].ToString()+"  ");
                    if (a[j] < 10)
                    {
                        Console.Write(" ");
                    }
                }
                b = new int[i + 1];
                for(int j=0;j<b.Length;j++)
                {
                    if(j==0||(j==b.Length-1))
                    {
                        b[j] = 1;
                    }
                    else
                    {
                        b[j] = a[j - 1] + a[j];
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
