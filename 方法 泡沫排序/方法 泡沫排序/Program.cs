using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法_泡沫排序
{
    class Program
    {
        static int[] bubble(int[] a)
        {
            int i, j, t;
            for(i=0;i<a.Length-1;i++)
            {
                for (j = 0; j < a.Length-1-i; j++)
                {
                    if(a[j]>a[j+1])
                    {
                        t = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = t;
                    }
                }
            }
            return a;
        }
        static void Main(string[] args)
        {

            int[] a = new int[] {72,23,852,4723,13,8,6534};
            a = bubble(a);
            for(int i=0;i<a.Length;i++)
            {
                Console.Write(a[i].ToString() + " ");
            }
            Console.ReadLine();
        }
    }
}
