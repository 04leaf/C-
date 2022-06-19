using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 繼承介面
{
    class Program
    {
        interface IPass
        {
            void Check();
            int Score { get; set; }
            string Result { get; }
        }
        class Pass : IPass
        {
            int score;
            protected string result = "不及格";
            public int Score
            {
                get { return score; }
                set
                {
                    if(value>=0 && value<=100)
                    {
                        score = value;
                    }
                    else
                    {
                        Console.WriteLine("輸入錯誤");
                    }
                }
            }

            public string Result
            {
                get { return result; }
            }
            public virtual void Check()
            {
                result = "不及格";
                if (score >= 60)
                    result = "及格";
            }
        }

        class Pass2 : Pass
        {
            public override void Check()
            {
                result = "不及格";
                if(Score>=70)
                {
                    result = "及格";
                }
            }
        }

        static void Main(string[] args)
        {
            Pass a = new Pass();
            a.Score = 80;
            a.Check();
            Console.WriteLine(a.Result);

            Pass2 b = new Pass2();
            b.Score = 60;
            b.Check();
            Console.WriteLine(b.Result);
            b.Score = 80;
            b.Check();
            Console.WriteLine(b.Result);

            Console.ReadLine();
        }
    }
}
