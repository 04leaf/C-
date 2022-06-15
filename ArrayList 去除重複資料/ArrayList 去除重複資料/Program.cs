using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayList_去除重複資料
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList a = new ArrayList(6) { 3, 8, 6, 3, 2, 6 };
            ArrayList b = new ArrayList() {};
            int i, j;
            for(i=0;i<a.Count;i++)
            {
                for (j=0;j<i;j++)
                {
                    if (a[i]==a[j])
                    {
                        a.RemoveAt(i);
                    }
                }
                if (!b.Contains(a[i]))
                {
                    b.Add(a[i]);
                }
            }
            for (i = 0; i < b.Count; i++)
            {
                Console.WriteLine(b[i]);
            }
            Console.ReadLine();
            
        }
    }
}
