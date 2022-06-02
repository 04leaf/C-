using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 平面座標上正方形三點_求第四點位置
{
    class Program
    {
        static void read(ref string enter,ref double x,ref double y)
        {
            x = double.Parse(enter.Substring(enter.IndexOf('(') + 1, enter.IndexOf(',')-1));
            y = double.Parse(enter.Substring(enter.IndexOf(',') + 1, enter.IndexOf(')') - enter.IndexOf(',') - 1));
            enter = enter.Remove(enter.IndexOf('('), enter.IndexOf(')')+1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("輸入三點座標求第四點位置 如:(0.5,0)(1.5,0)(0.5,1)");
            //string enter = Console.ReadLine();
            string enter ="(0.5,0)(1.5,0)(0.5,1)";

            double x1=0, x2=0, x3=0, x4=0, y1=0, y2=0, y3=0, y4=0;
            double e1=0, e2=0, e3=0;
            read(ref enter, ref x1, ref y1);
            read(ref enter, ref x2, ref y2);
            read(ref enter, ref x3, ref y3);

            e1 = (x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2);
            e2 = (x2 - x3) * (x2 - x3) + (y2 - y3) * (y2 - y3);
            e3 = (x3 - x1) * (x3 - x1) + (y3 - y1) * (y3 - y1);

            if(e1==e2)
            {
                x4 = x3 - x2 + x1;
                y4 = y3 - y2 + y1;
            }
            else if(e2==e3)
            {
                x4 = x1 - x3 + x2;
                y4 = y1 - y3 + y2;
            }
            else if (e3 == e1)
            {
                x4 = x2 - x1 + x3;
                y4 = y2 - y1 + y3;
            }
            Console.WriteLine("("+x4.ToString()+","+y4.ToString()+")");
            Console.ReadLine();
        }
    }
}
