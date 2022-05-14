using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第五章習題_累加
{
    class Program
    {
        static void Main(string[] args)
        {
            int choose;
            bool end = true;
            while (end)
            {
                Console.WriteLine("輸入題號1~3選擇，輸入0結束");

                double sum = 0;
                int i;
                choose = int.Parse(Console.ReadLine());
                switch(choose)
                {
                    case 0:
                        end = false;
                        break;
                    case 1:
                        for(i=7;i<=82;i=i+3)
                        {
                            sum = sum + i * i;
                        }
                        break;
                    case 2:
                        Console.WriteLine("輸入N值");
                        int n = int.Parse(Console.ReadLine());
                        for (i = 1; i <= n; i++)
                        {
                            sum = sum +(-1)*Math.Pow(-1,i) /i/i ;
                        }
                        break;
                    case 3:
                        int a=1;
                        Console.WriteLine("輸入N值");
                        n = int.Parse(Console.ReadLine());
                        for(i=1;i<=n;i++)
                        {
                            sum =sum+ 7 * a;
                            a = a * 10 + 1;
                        }
                        break;
                }
                Console.WriteLine(sum);
            }
            Console.ReadLine();
        }
    }
}
