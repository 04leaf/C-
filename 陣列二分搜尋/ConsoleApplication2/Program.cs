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
            int[] arr = new int[] { 2, 4, 8, 16, 24, 64, 128, 256, 333, 335, 400 };
            int s = int.Parse(Console.ReadLine());
            int l=0, u=arr.Count();
            string b="找不到";

            while(l<u)
            {
                Console.WriteLine(l+"，"+u);
                if (arr[(l+u)/2]>s)
                {
                    u = (l + u) / 2;
                }
                else if (arr[(l + u) / 2] < s)
                {
                    l= (l + u) / 2;
                }
                else if(arr[(l + u) / 2] == s)
                {
                    l = (l + u) / 2;
                    u = l ;
                    b = "找到了，索引在"+u;
                }
                if(u - l == 1&&s >arr[l]&&s<arr[u])
                {
                    break;
                }
            }
            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}
