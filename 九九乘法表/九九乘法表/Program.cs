using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 九九乘法表
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,j,k;
            for(i=1;i<=3;i++)
            {
                for(j=1;j<=9;j++)
                {
                    for (k = 1; k <= 3; k++)
                    {
                        if((3 * (i - 1) + k) * j<10)
                        {
                            Console.Write((3 * (i - 1) + k) + "*" + j + "= " + ((3 * (i - 1) + k) * j) + "  ");
                        }
                        else
                        {
                            Console.Write((3 * (i - 1) + k) + "*" + j + "=" + ((3 * (i - 1) + k) * j) + "  ");
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
