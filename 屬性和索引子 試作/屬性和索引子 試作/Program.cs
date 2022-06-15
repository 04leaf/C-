using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 屬性和索引子_試作
{
    class Program
    {
        //屬性
        class PropertyTest
        {
            int test;
            public int get
            {
                get { return test;}
            }
            public int set
            {
                get { return test; }
                set { test=value; }
            }
        }

        //索引子
        class season
        {
            string[] a = { "春", "夏", "秋", "冬" };
            public string this[int p]
            {
                get { return a[p]; }
                set { a[p] = value; }
            }
        }

        static void Main(string[] args)
        {
            PropertyTest a = new PropertyTest();
            Console.WriteLine(a.get.ToString());
            a.set=int.Parse(Console.ReadLine());
            Console.WriteLine(a.get.ToString());

            season b = new season();
            Console.WriteLine(b[1]);
            b[2] = Console.ReadLine();
            Console.WriteLine(b[2]);

            Console.ReadLine();
        }
    }
}
