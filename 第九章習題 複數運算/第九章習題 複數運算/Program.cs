using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第九章習題_複數運算
{
    class Program
    {
        class complex
        {
            double a, b;
            public complex(double a,double b)
            {
                this.a = a;
                this.b = b;
            }
            public static complex operator +(complex a,complex b)
            {
                return new complex(a.a + b.a, a.b + b.b);
            }
            public static complex operator -(complex a, complex b)
            {
                return new complex(a.a - b.a, a.b - b.b);
            }
            public static complex operator *(complex a, complex b)
            {
                return new complex(a.a * b.a-a.b*b.b, a.a*b.b + a.b*b.a);
            }
            public static complex operator /(complex a, complex b)
            {
                double c, d;
                c = (a.a * b.a + a.b * b.b) / (b.a * b.a + b.b * b.b);
                d = (a.b * b.a - a.a * b.b) / (b.a * b.a + b.b * b.b);
                return new complex(c,d);
            }
            public new string ToString()
            {
                string s;
                if(b<0)
                {
                    s = a.ToString() + b.ToString() + "i";
                }
                else if(b==0)
                {
                    s = a.ToString();
                }
                else
                {
                    s = a.ToString() + "+" + b.ToString() + "i";
                }
                return s;
            }
        }
        static void Main(string[] args)
        {
            complex i = new complex(2, 3);
            complex j = new complex(5, 6);
            complex k;

            k = i + j;
            Console.WriteLine(k.ToString());
            k = i - j;
            Console.WriteLine(k.ToString());
            k = i * j;
            Console.WriteLine(k.ToString());
            k = i / j;
            Console.WriteLine(k.ToString());

            Console.ReadLine();
        }
    }
}
