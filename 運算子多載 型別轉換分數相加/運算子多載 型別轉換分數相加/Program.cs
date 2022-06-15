using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 運算子多載_型別轉換分數相加
{
    class Program
    {
        class fraction
        {
            int num, den;
            public fraction(int num, int den)
            {
                this.num = num;
                this.den = den;
            }

            public static fraction operator +(fraction a, fraction b)
            {
                return new fraction(a.num * b.den + a.den * b.num, a.den * b.den);
            }
            public static fraction operator -(fraction a, fraction b)
            {
                return new fraction(a.num * b.den - a.den * b.num, a.den * b.den);
            }
            public static fraction operator *(fraction a, fraction b)
            {
                return new fraction(a.num * b.num, a.den * b.den);
            }
            public static fraction operator /(fraction a, fraction b)
            {
                return new fraction(a.num * b.den, a.den * b.num);
            }

            public static implicit operator double(fraction a)
            {
                return (double)a.num / a.den;
            }

            public new string ToString()
            {
                string s;
                s = num + "/" + den;
                return s;
            }
        }
        static void Main(string[] args)
        {
            fraction a = new fraction(1, 2);
            fraction b = new fraction(1, 3);
            fraction c = a + b;
            Console.WriteLine(c);
            Console.WriteLine(c.ToString());

            c = a - b;
            Console.WriteLine(c);
            Console.WriteLine(c.ToString());

            c = a * b;
            Console.WriteLine(c);
            Console.WriteLine(c.ToString());

            c = a / b;
            Console.WriteLine(c);
            Console.WriteLine(c.ToString());

            Console.ReadLine();
        }
    }
}
