using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 二維陣列_班級成績
{
    class Program
    {
        void sw(ref int a,ref int b)
        {
            int t;
            t = a;
            a = b;
            b = t;
        }

        static void Main(string[] args)
        {
            int i, j, k;
            int[,] a = new int[,]
            {
                {0,0,0,0,0,0,0},
                {1,50,60,70,0,0,0},
                {2,30,40,50,0,0,0},
                {3,70,80,90,0,0,0},
                {4,66,77,88,0,0,0},
                {5,22,33,44,0,0,0},
                {0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0}
            };
            //個人平均
            for(i=1;i<=5;i++)
            {
                for(j=1;j<=3;j++)
                {
                    a[i, 4] =a[i, 4] + a[i, j];
                }
                a[i, 4] = a[i, 4] / 3;
            }

            //名次
            for(i=1;i<=5;i++)
            {
                a[i, 5] = 1;
            }
            for(i=1;i<=5;i++)
            {
                for(j=1;j<=5;j++)
                {
                    if(a[i,4]<a[j,4])
                    {
                        a[i, 5] = a[i, 5] + 1;
                    }
                }
            }

            //不及格
            for(i=1;i<=5;i++)
            {
                int count = 0;
                for(j=1;j<=3;j++)
                {
                    if(a[i,j]<60)
                    {
                        count++;
                    }
                }
                a[i, 6] = count;
            }

            //各科班平均
            for(i=1;i<=4;i++)
            {
                for(j=1;j<=5;j++)
                {
                    a[6, i] = a[6, i] + a[j, i];
                }
                a[6, i] = a[6, i]/5;
            }

            //各科不及格
            for (i = 1; i <= 4; i++)
            {
                int count = 0;
                for (j = 1; j <= 5; j++)
                {
                    if (a[j, i] < 60)
                    {
                        count++;
                    }
                }
                a[7, i] = count;
            }

            //顯示
            /*
            for (i = 1; i <= 7; i++)
            {
                for (j = 0; j <= 6; j++)
                {
                    if(a[i,j]<=9)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(a[i, j] + "  ");
                }
                Console.WriteLine();
            }
            */

            //按名次顯示
            for (i = 1; i <= 5; i++)
            {
                for(k=1;k<=5;k++)
                {
                    if(a[k,5]==i)
                    {
                        for (j = 0; j <= 6; j++)
                        {
                            if (a[k, j] <= 9)
                            {
                                Console.Write(" ");
                            }
                            Console.Write(a[k, j] + "  ");
                        }
                    }
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
