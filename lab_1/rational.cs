using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;


namespace lab_1
{
    public class rational
    {
        private int numerator;
        private int denominator;
        public int Numerator
        {
            get { return numerator; }
        }
        public int Denominator
        {
            get { return denominator; }
        }

        public rational(int m, int n)
        {
            if (n == 0)
                throw new ArgumentException("Делить на ноль запрещено!", nameof(n));
            else if (n < 0)
            {
                m *= -1;
            //    n *= -1;
            }

            numerator = m;
            denominator = n;

            reduce();
        }

        private void reduce()
        {
            int gcd = rational.gcd(numerator, denominator);

            numerator /= gcd;
            denominator /= gcd;
        }

        private static int gcd(int m, int n)
        {
            if (n == 0)
                return m;
            else
                return gcd(n, m % n);
        }

        public override string ToString()
        {
            if (numerator % denominator == 0)
                return $"{numerator}";
            else
                return $"{numerator}/{denominator}";
        }

        public static rational operator +(rational r1, rational r2)
        {
            return new rational((r1.Numerator * r2.Denominator) + (r2.Numerator * r1.Denominator), r1.Denominator * r2.Denominator);
        }

        public static rational operator ++(rational r1)
        {
            return r1 + new rational(1, 1); ;
        }

        public static rational operator -(rational r1, rational r2)
        {
            return new rational(r1.Numerator * r2.Denominator - (r2.Numerator * r1.Denominator), r1.Denominator * r2.Denominator);
        }

        public static rational operator -(rational r)
        {
            return new rational(-(r.Numerator), r.Denominator);
        }

        public static rational operator --(rational r1)
        {
            return r1 - new rational(1, 1);
        }

        public static rational operator *(rational r1, rational r2)
        {
            return new rational(r1.Numerator * r2.Numerator, r1.Denominator * r2.Denominator);
        }

        public static rational operator /(rational r1, rational r2)
        {
            return new rational(r1.Numerator * r2.Denominator, r1.Denominator * r2.Numerator);
        }

        // copy

        public static bool operator ==(rational r1, rational r2)
        {
            if (r1.Numerator == r2.Numerator && r1.Denominator == r2.Denominator)
                return true;
            else
                return false;
        }

        public static bool operator !=(rational r1, rational r2)
        {
            if (r1.Numerator != r2.Numerator || r1.Denominator != r2.Denominator)
                return true;
            else
                return false;
        }

        public static bool operator <(rational r1, rational r2)
        {
            if (r1.Denominator == r2.Denominator)
            {
                if (r1.Numerator < r2.Numerator)
                    return true;
                else
                    return false;
            }
            else
            {
                if (r1.Numerator * r2.Denominator < r1.Numerator * r2.Denominator)
                    return true;
                else
                    return false;
            }
        }
        public static bool operator >(rational r1, rational r2)
        {
            if (r1.Denominator == r2.Denominator)
            {
                if (r1.Numerator > r2.Numerator)
                    return true;
                else
                    return false;
            }
            else
            {
                if (r1.Numerator * r2.Denominator > r2.Numerator * r1.Denominator)
                    return true;
                else
                    return false;
            }
        }

        public static bool operator <=(rational r1, rational r2)
        {
            if (r1.Denominator == r2.Denominator)
            {
                if (r1.Numerator <= r2.Numerator)
                    return true;
                else
                    return false;
            }
            else
            {
                if (r1.Numerator * r2.Denominator <= r2.Numerator * r1.Denominator)
                    return true;
                else
                    return false;
            }
        }

        public static bool operator >=(rational r1, rational r2)
        {
            if (r1.Denominator == r2.Denominator)
            {
                if (r1.Numerator >= r2.Numerator)
                    return true;
                else
                    return false;
            }
            else
            {
                if (r1.Numerator * r2.Denominator >= r2.Numerator * r1.Denominator)
                    return true;
                else
                    return false;
            }
        }
    }
}

