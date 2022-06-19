using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace horng
{
    public abstract class Pass
    {
        public int score;
        public string result;
        abstract public void Check();
    }
    public class fraction
    {
        int num, den;
        public fraction(int num, int den)
        {
            this.num = num;
            this.den = den;
        }

        public static fraction operator +(fraction a, fraction b)
        {
            return new fraction(a.num * b.den + a.den * b.num, a.den * b.den);
        }
        public static fraction operator -(fraction a, fraction b)
        {
            return new fraction(a.num * b.den - a.den * b.num, a.den * b.den);
        }
        public static fraction operator *(fraction a, fraction b)
        {
            return new fraction(a.num * b.num, a.den * b.den);
        }
        public static fraction operator /(fraction a, fraction b)
        {
            return new fraction(a.num * b.den, a.den * b.num);
        }

        public static implicit operator double(fraction a)
        {
            return (double)a.num / a.den;
        }

        public new string ToString()
        {
            string s;
            s = num + "/" + den;
            return s;
        }
    }
}
