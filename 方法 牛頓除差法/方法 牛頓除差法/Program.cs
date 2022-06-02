using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法_牛頓除差法
{
    class Program
    {
        static double[] a = new double[] { 1, 1.5, 2, 3 };
        static double[] b = new double[] { 96, 90, 83, 67 };
        static void swap(ref double a, ref double b)
        {
            double t = a;
            a = b;
            b = t;
        }

        static void Qsort(int m, int n)
        {
            double p;
            int i, j;
            if (m < n)
            {
                p = Math.Abs(a[m]);
                i = m;
                j = n + 1;

                do
                {
                    do
                    {
                        i++;
                    }
                    while (Math.Abs(a[i]) < p);
                    do
                    {
                        j--;
                    }
                    while (Math.Abs(a[j]) > p);
                    if (i < j)
                    {
                        swap(ref a[i], ref a[j]);
                        swap(ref b[i], ref b[j]);
                    }
                }
                while (i < j);

                swap(ref a[j], ref a[m]);
                swap(ref b[i], ref b[j]);

                Qsort(m, j - 1);
                Qsort(j + 1, n);
            }
        }
        static double sum=b[0];
        static double f(params double[] a)
        {
            double[] c = new double[] { };
            double m = 1;
            return sum + m * f(c);
        }

        static void Main(string[] args)
        {
            Qsort(0, a.Length - 1); for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(f(2.5).ToString());
            Console.ReadLine();
        }
    }
}
