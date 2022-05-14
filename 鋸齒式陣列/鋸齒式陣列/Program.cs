using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 鋸齒式陣列
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] a = new string[4][];
            a[0] = new string[] {"張三", "總經理", "業務", "專員", "主任", "經理", };
            a[1] = new string[] { "李四", "經理", "業務", "副理"};
            a[2] = new string[] { "王五", "主任", "業務"};
            a[3] = new string[] { "陳六", "工友"};

            int i, j;
            for(i=0;i<=3;i++)
            {
                for(j=0;j<=a[i].Length-1;j++)
                {
                    Console.Write(a[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
