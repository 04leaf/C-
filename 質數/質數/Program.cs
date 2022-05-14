using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 質數
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j,a;
            a = int.Parse(Console.ReadLine());
            Console.Write("以下的質數們\n");
            for (i=2;i<=a;i++)
            {
                bool b = true;
                for(j=2;j<=i/2;j++)
                {
                    if(i%j==0)
                    {
                        b = false;
                    }
                }
                if(b)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
