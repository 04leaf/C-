using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 運算子多載___複製字串
{
    class Program
    {
        class stringadd
        {
            public string a;
            public static stringadd operator ++(stringadd a)
            {
                stringadd b = new stringadd();
                b = a;
                b.a = b.a + b.a;
                return (b);
            }
        }
        static void Main(string[] args)
        {
            stringadd s = new stringadd();
            s.a = "aaaa";
            s++;
            Console.WriteLine(s.a);
            Console.ReadLine();
        }
    }
}
