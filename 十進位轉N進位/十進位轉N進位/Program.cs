using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 十進位轉N進位
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("要轉換的數");
            long ten = long.Parse(Console.ReadLine());
            Console.Write("要轉換成的進位");
            int n = int.Parse(Console.ReadLine());
            string str="";
            while (ten>=n)
            {
                str =ten % n+str;
                ten = ten / n;
            }
            str = "結果為"+ten % n + str;
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
