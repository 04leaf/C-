using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 找出指定字串出現的次數
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "There are four books in my bag.\nHow many books do you have?\nThere are four books in my room.\n";
            Console.WriteLine(text);
            Console.WriteLine("輸入關鍵字找出在文章中出現的次數:");
            string target = Console.ReadLine();

            bool found = false;
            int finds = 0;
            int i = 0, j;

            do
            {
                found = false;
                j = text.IndexOf(target, i);
                if (j > 0)
                {
                    found = true;
                    finds++;
                    i = j + 1;
                }
            }
            while (found);

            Console.WriteLine(finds.ToString() + "個");
            Console.ReadLine();

        }
    }
}
