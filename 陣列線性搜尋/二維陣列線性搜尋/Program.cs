using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 二維陣列線性搜尋
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入名字搜尋號碼，或輸入號碼搜尋名字");
            string[] arr1 = new string[] {  "hh", "kk", "cc", "dd", "bb", "ff", "gg", "yy", "aa", "mm" };
            string[] arr2 = new string[] { "1234", "2345", "3456", "4567", "5678", "6789", "7890", "8901", "9012", "5566" };
            string cin = Console.ReadLine();
            int i;
            for(i=0;i<=9;i++)
            {
                if(cin==arr1[i])
                {
                    Console.WriteLine(arr2[i]);
                }
                if (cin == arr2[i])
                {
                    Console.WriteLine(arr1[i]);
                }
            }
            Console.ReadLine();
        }
    }
}
