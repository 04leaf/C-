using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while亂數練習
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Random ran = new Random();
            int sum = 0,current1=0, current2 = 0;
            bool end = true;
            do
            {
                current1 = ran.Next(2, 10);
                current2 = ran.Next(2, 10);
                sum = sum + current1 + current2;
                Console.WriteLine(current1 + "，" + current2 + "，" + sum);
                if ((current1+current2)>10)
                {
                    sum = sum + current1+current2;
                    Console.WriteLine(current1+"，"+current2 + "，" + sum);
                }
                else if ((current1 + current2) <= 10)
                {
                    end = false;
                }
            }
            while (end);
            Console.ReadLine();
            */

            Random ran = new Random();
            int current1 = 0, current2 = 0,current3=0;
            bool end = true;
            do
            {
                current1 = ran.Next(1, 7);
                current2 = ran.Next(1, 7);
                current3 = ran.Next(1, 7);
                if (end)
                {
                    Console.WriteLine(current1 + "，" + current2 + "，" + current3);
                }
                if (current1 == current2 || current2 == current3 || current1 == current3)
                {
                    end = false;
                    if(current1 == current2)
                    {
                        Console.WriteLine(current3);
                    }
                    else if (current2 == current3)
                    {
                        Console.WriteLine(current1);
                    }
                    else if (current1 == current3)
                    {
                        Console.WriteLine(current2);
                    }
                }
            }
            while (end);
            Console.ReadLine();
        }
    }
}
