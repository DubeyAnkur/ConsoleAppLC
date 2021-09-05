using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Fraction_to_Recurring_Decimal
    {
        public string FractionToDecimal(int numerator, int denominator)
        {
            var ret = "";

            decimal Q1 = (decimal)numerator / denominator;
            if (Q1 < 0)
                Q1 = Math.Ceiling(Q1);
            else
                Q1 = Math.Floor(Q1);
            decimal r1 = (decimal)numerator % denominator;

            if ((numerator < 0 ^ denominator < 0) && Q1 == 0 && r1 !=0)
                ret = ret + "-";
            ret = ret + Q1.ToString();

            if (r1 == 0)
                return ret;

            var rem = "";
            decimal r = (numerator < 0 ^ denominator < 0) ? r1 * -1: r1;
            decimal q = 0;
            Hashtable ht = new Hashtable();
            
            int count = 0;
            do
            {
                ht.Add(r, count);
                count++;
                r = r * 10;
                q = Math.Floor(r / denominator);
                r = r % denominator;
                rem = rem + q;
            } while (r != 0 && !ht.Contains(r));

            if (r == 0)
                ret = ret + "." + rem;
            else
            {
                int i = (int)ht[r];
                ret = ret + "." + rem.Substring(0, i) + "(" + rem.Substring(i, rem.Length - i) + ")";
            }
            return ret;
        }
    }
}
