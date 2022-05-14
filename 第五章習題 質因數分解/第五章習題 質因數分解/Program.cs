using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第五章習題_質因數分解
{
    class Program
    {
        static void Main(string[] args)
        {
            long a = long.Parse(Console.ReadLine());
            long t = a;
            int i, j;
            bool p1 = true;
            bool end = true;

            for (j = 2; j < a; j++)
            {
                if (a % j == 0)
                {
                    p1 = false;
                }
            }
            if(p1)
            {
                end = false;
            }
            else
            {
                Console.Write(a + "=");
            }
            while(end)
            {
                for (i = 2; i <= a; i++)
                {
                    if (a % 2 == 0)
                    {
                        a = a / 2;
                        Console.Write(2 + "*");
                    }
                    else
                    {
                        bool p2 = true;
                        for (j = 2; j < i; j++)
                        {
                            if (i % j == 0)
                            {
                                p2 = false;
                            }
                        }
                        if (p2 && a % i == 0)
                        {
                            if (a == i)
                            {
                                Console.Write(i);
                                a = a / i;
                            }
                            else
                            {
                                a = a / i;
                                Console.Write(i + "*");
                                i = 2;
                                p1 = false;
                            }
                        }
                    }
                    
                }
                if(a==1)
                {
                    end = false;
                }
            }
            if(p1)
            {
                Console.WriteLine("是質數");
            }
            Console.WriteLine("\n結束");
            Console.ReadLine();


        }
    }
}
