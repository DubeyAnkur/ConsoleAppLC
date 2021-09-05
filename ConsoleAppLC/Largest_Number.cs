using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Largest_Number
    {
        public string LargestNumber(int[] nums)
        {
            string[] strNums = new string[nums.Length];
            List<string> str = new List<string>();

            string ret = "";

            for (int i = 0; i < nums.Length; i++)
                str.Add(nums[i].ToString());

            str.Sort(CompareStrings);

            for (int i = 0; i < str.Count; i++)
            {
                ret = str[i] + ret;
            }

            int j = 0;
            while (j < ret.Length && ret[j] == '0')
                j++;
            if(j >0)
                ret = ret.Substring(j-1);

            return ret;
        }

        public static int CompareStrings(string s1, string s2)
        {
            return (s1+s2).CompareTo(s2+s1);
        }
    }
}
