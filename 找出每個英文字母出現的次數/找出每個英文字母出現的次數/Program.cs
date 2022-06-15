using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 找出每個英文字母出現的次數
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "There are four books in my bag.\nHow many books do you have?\nThere are four books in my room.\n";
            Console.WriteLine(text);
            string sout = "";
                        
            for(int k=65; k<=90;k++)
            {
                bool found = false;
                int finds = 0;
                int i = 0,j1,j2;
                do
                {
                    found = false;
                    j1 = text.IndexOf((char)k, i);
                    j2 = text.IndexOf((char)(k+32), i);
                    if (j1 > 0)
                    {
                        found = true;
                        finds++;
                        i = j1 + 1;
                    }
                    else if (j2 > 0)
                    {
                        found = true;
                        finds++;
                        i = j2 + 1;
                    }
                }
                while (found);
                if(finds>0)
                {
                    sout = sout + (char)k + "*" + finds.ToString() + "，";
                }
            }

            Console.WriteLine(sout);
            Console.ReadLine();
        }
    }
}
