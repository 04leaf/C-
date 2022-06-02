using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法_組合運算
{
    class Program
    {
        public static int grade(int a)
        {
            int sum=1;
            for(int i=1;i<=a;i++)
            {
                sum = sum * i;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            int m, n;
            Console.WriteLine("輸入m和n求C m取n");
            m = int.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());
            int ans = grade(m) / (grade(n) * grade(m - n));
            Console.WriteLine(ans.ToString());
            Console.ReadLine();
        }
    }
}
