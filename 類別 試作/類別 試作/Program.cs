using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 類別_試作
{
    class Pass
    {
        public int score;
        public string result = "不及格";
        public void check()
        {
            result = "不及格";
            if(score>=60)
            {
                result = "及格";
            }
            Console.WriteLine(result);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pass pa1 = new Pass();
            Pass pa2 = new Pass();

            pa1.score = 70;
            pa2.score = 50;

            pa1.check();
            pa2.check();

            Console.ReadLine();
        }
    }
}
