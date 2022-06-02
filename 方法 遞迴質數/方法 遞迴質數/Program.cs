using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法_遞迴質數
{
    class Program
    {
        static bool check(int p,int d)
        {
            if(d==1)
            {
                return true;
            }
            else
            {
                if(p%d==0)
                {
                    return false;
                }
                else
                {
                    return check(p, d - 1);
                }
            }
        }
        static void Main(string[] args)
        {
            int p = int.Parse(Console.ReadLine());
            if(check(p,p-1))
            {
                Console.WriteLine("是質數");
            }
            else
            {
                Console.WriteLine("不是質數");
            }
            Console.ReadLine();
        }
    }
}
