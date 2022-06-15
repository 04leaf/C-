using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 運算子多載_二元分數加減
{
    class Program
    {
        class fraction
        {
            public float num, den;
            public float k;

            public static fraction operator +(fraction a,fraction b)
            {
                fraction fra1 = new fraction();
                fra1.k = (a.num * b.den + b.num * a.den) / (a.den * b.den);
                return fra1;
            }
        }
        static void Main(string[] args)
        {
            fraction a = new fraction();
            fraction b = new fraction();
            fraction c = new fraction();
            a.num = 1;a.den = 2;
            b.num = 1;b.den = 3;
            c = a + b;
            Console.WriteLine(c.k);

            Console.ReadLine();
        }
    }
}
