using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 運算子多載___輸出下一字元
{
    class Program
    {
        class next
        {
            char a;
            public next(char a)
            {
                this.a = a;
            }

            public static next operator ++(next a)
            {
                return new next ((char)((int)a.a+1));
            }

            public static implicit operator char(next a)
            {
                return a.a;
            }
        }
        static void Main(string[] args)
        {
            char x = 'y';
            next a = new next(x);
            a++;
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}
