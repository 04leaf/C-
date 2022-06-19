using System;


namespace this___base___示範
{
    class Program
    {
        static void Main(string[] args)
        {
            Cylinder test = new Cylinder();
            Console.WriteLine("圓柱體半徑" + test.getradius());
            Console.WriteLine("圓柱體長度" + test.getlength());
            Console.WriteLine();
            Cylinder test1 = new Cylinder(1, 2);
            Console.WriteLine("圓柱體半徑" + test1.getradius());
            Console.WriteLine("圓柱體長度" + test1.getlength());

            Console.ReadLine();
        }

        class Circle
        {
            protected int radius;

            public Circle()
            {
                this.radius = 2;
            }
            public Circle(int r)
            {
                radius = r;
            }
            public int getradius()
            {
                return radius;
            }
            public double getarea()
            {
                return radius * radius * Math.PI;
            }
        }

        class Cylinder : Circle
        {
            int length;

            //沒有輸入就繼承this給預設值
            public Cylinder():this(2,3)
            {

            }

            //有輸入值則給基礎類別也給予值
            public Cylinder(int r,int l):base(r)
            {
                length = l;
            }
            //得到長度
            public int getlength()
            {
                return length;
            }
            //從基礎類別得到面積再求體積
            public double getvolume()
            {
                return base.getarea() * length;
            }
        }
    }
}
