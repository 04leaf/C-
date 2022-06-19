using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 示範抽象類別
{
    class Program
    {
        abstract class Pass
        {
            public int score;
            public string result;
            abstract public void Check();
        }
        class Collage:Pass
        {
            public override void Check()
            {
                result = "不及格";
                if(score>=60)
                {
                    result = "及格";
                }
            }
        }
        class Master : Pass
        {
            public override void Check()
            {
                result = "不及格";
                if (score >= 70)
                {
                    result = "及格";
                }
            }
        }
        static void Main(string[] args)
        {
            int a = 66;
            Collage pa1 = new Collage();
            pa1.score = a;
            pa1.Check();
            Console.WriteLine(pa1.result);
            Master pa2 = new Master();
            pa2.score = a;
            pa2.Check();
            Console.WriteLine(pa2.result);
            Console.ReadLine();
        }
    }
}
