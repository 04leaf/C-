using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法_快速排序法
{
    class Program
    {
        static int[] a = new int[] { 26, 5, 37, 1, 61, 11, 59, 15, 48, 19 };
        static void swap(ref int a,ref int b)
        {
            int t = a;
            a = b;
            b = t;
        }

        static void Qsort(int m, int n)
        {
            int p, i, j;
            if (m < n)
            {
                p = a[m];
                i = m;
                j = n + 1;

                do
                {
                    Console.WriteLine("m=" + m.ToString() + " n" + n.ToString());
                    do
                    {
                        i++;
                    }
                    while (a[i] < p);
                    do
                    {
                        j--;
                    }
                    while (a[j] > p);
                    if (i < j)
                    {
                        swap(ref a[i], ref a[j]);
                    }
                }
                while (i < j);

                swap(ref a[j],ref a[m]);

                Qsort(m, j - 1);
                Qsort(j+1, n);
            }
        }

        static void Main(string[] args)
        {
            Qsort(0, a.Length - 1);
            for (int i=0;i<a.Length;i++)
            {
                Console.Write(a[i]+" ");
            }
            Console.ReadLine();
        }
    }
}
