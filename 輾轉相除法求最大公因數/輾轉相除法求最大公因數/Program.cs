using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 輾轉相除法求最大公因數
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, r;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            if(b>a)
            {
                r = a;
                a = b;
                b = r;
            }
            while(a%b!=0)
            {
                r = a % b;
                a = b;
                b = r;
            }
            Console.WriteLine("最大公因數為"+b);
            Console.ReadLine();
        }
    }
}
