using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第八章習題_四人發撲克牌
{
    class Program
    {
        static char[] start()
        {
            string b="aaaaaaaaaaaaabbbbbbbbbbbbbcccccccccccccddddddddddddd";
            char[] a = new char[52];
            a = b.ToCharArray();
            char t1;
            int t2;
            Random r = new Random();
            for(int i=0;i<a.Length;i++)
            {
                t1 = a[i];
                t2 = r.Next(0, 52);
                a[i] = a[t2];
                a[t2] = t1;
            }
            return a;
        }
        static void Main(string[] args)
        {
            string[] s = new string[52]
            {
                "SA","SK","SQ","SJ","S10","S9","S8","S7","S6","S5","S4","S3","S2",
                "HA","HK","HQ","HJ","H10","H9","H8","H7","H6","H5","H4","H3","H2",
                "DA","DK","DQ","DJ","D10","D9","D8","D7","D6","D5","D4","D3","D2",
                "CA","CK","CQ","CJ","C10","C9","C8","C7","C6","C5","C4","C3","C2"
            };
            bool con = true;
            string b1 = "王大：", b2 = "林二：", b3 = "張三：", b4 = "李四：";
            while (con)
            {
                con = false;
                char[] a = start();
                b1 = "王大：";
                b2 = "林二：";
                b3 = "張三：";
                b4 = "李四：";
                for (int i = 0; i < 52; i++)
                {
                    switch (a[i])
                    {
                        case 'a':
                            b1 = b1 + s[i] + " ";
                            break;
                        case 'b':
                            b2 = b2 + s[i] + " ";
                            break;
                        case 'c':
                            b3 = b3 + s[i] + " ";
                            break;
                        case 'd':
                            b4 = b4 + s[i] + " ";
                            break;
                    }
                }
                Console.WriteLine(b1 + "\n" + b2 + "\n" + b3 + "\n" + b4);
                Console.WriteLine("要繼續下一輪則輸入1");
                int con1=int.Parse(Console.ReadLine());
                if (con1==1)
                {
                    con = true;
                }
            }


            Console.ReadLine();
        }
    }
}
