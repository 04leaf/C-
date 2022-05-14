using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泡沫排序法
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10] { 64, 71, 1, 51, 26, 78, 99, 14, 34, 66 };
            int i, j,k,t=0;
            for(i=8;i>=0;i--)
            {

                for (j = 0; j <= i; j++)
                {
                    if(arr[j]>arr[j+1])
                    {
                        t = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = t;
                    }
                }
                for (k = 0; k <= 9; k++)
                {
                    Console.Write(arr[k] + ",");
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
