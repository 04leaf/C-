using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 運算子多載_型別轉換
{
    class stringadd
    {
        string d;

        //從參數直接給欄位成員附值
        public stringadd(string d)
        {
            this.d = d;
        }

        //透過++讓物件的字串複製
        public static stringadd operator ++(stringadd a)
        {
            return new stringadd(a.d + a.d);
        }
        
        //讓物件被當作字串使用
        public static implicit operator string(stringadd a)
        {
            return (string)a.d;
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            stringadd s = new stringadd("a");
            s++;
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
