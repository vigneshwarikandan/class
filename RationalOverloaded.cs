using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace day1
{
    public class RationalOverloaded
    {
        private int numerator, denominator;

        public int GetNumerator()
        {
            return numerator;
        }

        public int GetDenominator()
        {
            return denominator;
        }

        public static RationalOverloaded operator +(RationalOverloaded num1, RationalOverloaded num2)
        {
            int commonDenom = num1.denominator * num2.GetDenominator();
            int numer1 = num1.numerator * num2.GetDenominator();
            int numer2 = num2.GetNumerator() * num1.denominator;
            int sum = numer1 + numer2;
            RationalOverloaded result = new RationalOverloaded(sum, commonDenom);
            return result;
        }

        public static RationalOverloaded operator -(RationalOverloaded num1, RationalOverloaded num2)
        {
            int commonDenom = num1.denominator * num2.GetDenominator();
            int numer1 = num1.numerator * num2.GetDenominator();
            int numer2 = num2.GetNumerator() * num1.denominator;
            int difference = numer1 - numer2;
            RationalOverloaded result = new RationalOverloaded(difference, commonDenom);
            return result;
        }

        public static RationalOverloaded operator *(RationalOverloaded num1, RationalOverloaded num2)
        {
            int numer = num1.numerator * num2.GetNumerator();
            int denom = num1.denominator * num2.GetDenominator();
            RationalOverloaded result = new RationalOverloaded(numer, denom);
            return result;
        }

        public static RationalOverloaded operator /(RationalOverloaded num1, RationalOverloaded num2)
        {
            int numer = num2.GetDenominator();
            int denom = num2.GetNumerator();

            RationalOverloaded r = new RationalOverloaded(numer, denom);
            RationalOverloaded result = num1 * r;
            return result;
        }

        public string StrVal()
        {
            string result;

            if (numerator == 0)
                result = "0";
            else
            {
                if (denominator == 1)
                    result = numerator.ToString();
                else
                    result = numerator + "/" + denominator;
            }
            return result;
        }

        public RationalOverloaded(int numer, int denom)
        {
            if (denom == 0)    // set denominator to 1 if
                denom = 1;      // argument is zero
            if (denom < 0)
            {   // make numerator "store" the sign
                numer = numer * -1;
                denom = denom * -1;
            }
            numerator = numer;
            denominator = denom;
            Reduce();          // calling a private method
        }

        private void Reduce()
        {
            if (numerator != 0)
            {
                int common = HCF(Math.Abs(numerator), denominator);
                numerator = numerator / common;
                denominator = denominator / common;
            }
        }

        private int HCF(int num1, int num2)
        {
            while (num1 != num2)
            {
                if (num1 > num2)
                    num1 -= num2;
                else
                    num2 -= num1;
            }
            return num1;
        }
    }
}
