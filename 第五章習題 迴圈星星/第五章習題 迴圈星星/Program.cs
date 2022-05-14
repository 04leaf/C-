using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第五章習題_迴圈星星
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入數字1~6選擇題數，輸入0結束");
            int choose;
            bool end = true;
            while(end)
            {
                choose = int.Parse(Console.ReadLine());
                Console.WriteLine("\n 輸出");
                int i, j;
                switch (choose)
                {
                    case 0:
                        end = false;
                        break;
                    case 1:
                        for (i = 1; i <= 5; i++)
                        {
                            for (j = 1; j <= i; j++)
                            {
                                Console.Write(j + " ");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 2:
                        for (i = 1; i <= 5; i++)
                        {
                            for (j = 1; j <=i; j++)
                            {
                                Console.Write(" ");
                            }
                            for (j = 1; j <= 6-i; j++)
                            {
                                Console.Write(j + " ");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 3:
                        for (i = 5; i >= 1; i--)
                        {
                            for (j = 1; j <= i; j++)
                            {
                                Console.Write(" ");
                            }
                            for (j = 1; j <= 6 - i; j++)
                            {
                                Console.Write(i + " ");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 4:
                        int F = (int)'F';
                        for (i = 5; i >= 1; i--)
                        {
                            for (j = 1; j <= i; j++)
                            {
                                Console.Write("  ");
                            }
                            for (j = 1; j <= (6 - i)*2-1; j++)
                            {
                                Console.Write((char)(F-(6-i)) + " ");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 5:
                        for (i = 5; i >= 1; i--)
                        {
                            for (j = 1; j <= i; j++)
                            {
                                Console.Write("  ");
                            }
                            for (j = 1; j <= (5 - i) * 2 - 1; j++)
                            {
                                Console.Write("* ");
                            }
                            Console.WriteLine();
                        }
                        for (i = 3; i >= 1; i--)
                        {
                            for (j = 1; j <= 5-i; j++)
                            {
                                Console.Write("  ");
                            }
                            for (j = 1; j <= 2*i-1; j++)
                            {
                                Console.Write("* ");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 6:
                        for (i = 5; i >= 1; i--)
                        {
                            for (j = 1; j <= i; j++)
                            {
                                Console.Write("  ");
                            }
                            for (j = 1; j <= (5 - i) * 2 - 1; j++)
                            {
                                if(j>=3 && j<= (5 - i) * 2 - 3)
                                {
                                    Console.Write("  ");
                                }
                                else
                                {
                                    Console.Write("* ");
                                }
                            }
                            Console.WriteLine();
                        }
                        for (i = 3; i >= 1; i--)
                        {
                            for (j = 1; j <= 5 - i; j++)
                            {
                                Console.Write("  ");
                            }
                            for (j = 1; j <= 2 * i - 1; j++)
                            {
                                if(j>=3 && j<=2*i-3)
                                {
                                    Console.Write("  ");
                                }
                                else
                                {
                                    Console.Write("* ");
                                }
                            }
                            Console.WriteLine();
                        }
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
