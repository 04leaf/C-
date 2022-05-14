using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k, sum1, sum2, l;
            for (i = 1; i <= 9; i++)
            {
                for (j = 0; j <= 9; j++)
                {
                    for (k = 0; k <= 9; k++)
                    {
                        for (l = 0; l <= 9; l ++)
                        {
                            sum1 = i * 1000 + j * 100 + k*10+l;
                            sum2 = i * i * i *i+ j * j * j *j+ k * k * k*k+l*l*l*l;
                            if (sum1 == sum2)
                            {
                                Console.WriteLine(sum1);
                            }
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
