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
            int i, j,k,sum=0;
            for(i=1;i<=3; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    for (k = 1; k <= 4-j; j++)
                    {
                        sum = sum + i + j + 2 * k;
                    }
                }
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
