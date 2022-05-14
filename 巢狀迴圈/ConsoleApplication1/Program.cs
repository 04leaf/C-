using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            //數字
            /*
            int a, b, i;
            a = int.Parse(Console.ReadLine());
            for (b = a; b >= 1; b--)
            {
                for (i = 1; i <= b; i++)
                {
                    Console.Write(i);
                }
                for (i = 1; i <= 5; i++)
                {
                    Console.Write(" ");
                }
                for (i = b; i <= a; i++)
                {
                    Console.Write(a-i+1);
                }
                Console.Write("\n");
            }
            */

            //累進
            /*
            int a, b, i,c=0;
            a = int.Parse(Console.ReadLine());
            for (b = 1; b <= a; b++)
            {
                for (i = 1; i <= b; i++)
                {
                    c = c + 1;
                    Console.Write(c+" ");
                }
                Console.Write("\n");
            }
            */

            //英文字母
            int a, b, i;
            a = int.Parse(Console.ReadLine());
            int F = (int)'A' + a;
            for (b = a; b >= 1; b--)
            {
                F = F - 1;
                for (i = b+1; i <= a; i++)
                {
                    Console.Write(" ");
                }
                for (i = 1; i <= b; i++)
                {
                    Console.Write((char)F);
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
