using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 二維陣列_三個業務員
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[,]
            {
                {0,0,0,0,0,0,0},
                {1,0,2,4,6,0,0},
                {2,8,0,2,1,0,0},
                {3,7,0,0,9,0,0},
                {0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0},
            };
            int i, j;
            
            //個人業績
            for(i=1;i<=3;i++)
            {
                int sum = 0,count=0;
                for(j=1;j<=4;j++)
                {
                    sum = sum + a[i, j];
                    if(a[i,j]==0)
                    {
                        count++;
                    }
                }
                a[i, 5] = sum;
                a[i, 6] = count;
            }

            //每季業績
            for(j=1;j<=4;j++)
            {
                int sum = 0,count = 0;
                for(i=1;i<=3;i++)
                {
                    sum = sum +a[i, j];
                    if(a[i,j]==0)
                    {
                        count++;
                    }
                }
                a[4, j] = sum;
                a[5, j] = count;
            }

            //顯示
            for(i=1;i<=5;i++)
            {
                for(j=0;j<=6;j++)
                {
                    if(a[i,j]<10)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(a[i,j]+" ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
