using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace ConsoleAppLC
{
    public class Integer_to_Roman
    {
        //The way I do manually.
        public string IntToRoman(int num)
        {
            int pVal = 1;
            string ret = "";
            while (num > 0)
            {
                int val = num % 10;
                ret = GetRStr(val, pVal) + ret;

                num = num / 10;
                pVal = pVal * 10;
            }
            return ret;
        }

        private string GetRStr(int val, int pVal)
        {
            string ret = "";
            string val1 = "";
            string val5 = "";
            string val10 = "";

            if (pVal == 1)
            {
                val1 = "I";
                val5 = "V";
                val10 = "X";
            }
            if (pVal == 10)
            {
                val1 = "X";
                val5 = "L";
                val10 = "C";
            }
            if (pVal == 100)
            {
                val1 = "C";
                val5 = "D";
                val10 = "M";
            }
            if (pVal == 1000)
            {
                val1 = "M";
            }

            if (val <= 3)
            {
                while (val > 0)
                { ret = ret + val1; val--; }
            }
            else if (val == 4)
            {
                ret = val1 + val5;
            }
            else if (val <= 8)
            {
                ret = val5;
                while (val > 5)
                { ret = ret + val1; val--; }
            }
            else if (val == 9)
            {
                ret = val1 + val10;
            }

            return ret;
        }

        //Better way
        public String intToRoman(int num)
        {
            int[] v = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            String[] s = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < v.Length; i++)
            {
                while (num >= v[i])
                {
                    sb.Append(s[i]);
                    num -= v[i];
                }
            }
            return sb.ToString();
        }
    }
}
