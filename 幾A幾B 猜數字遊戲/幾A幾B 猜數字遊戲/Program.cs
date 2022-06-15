using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 幾A幾B_猜數字遊戲
{
    class Program
    {
        static bool include(string a,char b)
        {
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]==b)
                {
                    return true;
                }
            }
            return false;
        }
        static string number()
        {
            char[] a = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            Random r = new Random();
            char t;
            int j;
            for (int i = 0; i <= 9;i++)
            {
                j = r.Next(10);
                t = a[i];
                a[i] = a[j];
                a[j] = t;
            }
            string b = "";
            for(int i=0;i<=3;i++)
            {
                b = b + a[i];
            }
            return b;
        }
        static void Main(string[] args)
        {
            string start=number();
            Console.WriteLine("輸入不重複四位數如0123猜電腦的數字，電腦會回應幾A幾B，A代表幾個數字猜對且位置正確，B代表數字正確而位置不正確");
            string play ="";
            int a, b;
            do
            {
                a = 0;
                b = 0;
                play = Console.ReadLine();
                for(int i=0;i<=3;i++)
                {
                    if (include(start, play[i]))
                    {
                        b++;
                        if(start.IndexOf(play[i])==play.IndexOf(play[i]))
                        {
                            b--;
                            a++;
                        }
                    }
                }
                Console.WriteLine(a.ToString()+"A"+b.ToString()+"B");
            }
            while (start != play);
            Console.WriteLine("猜中了");
            Console.ReadLine();
        }
    }
}
