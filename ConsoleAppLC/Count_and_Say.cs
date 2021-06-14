using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Count_and_Say
    {
        public string CountAndSay(int n)
        {
            string ret = "";
            for (int i = 0; i < n; i++)
            {
                ret = Say(ret);
            }
            return ret;
        }
        private string Say(string a)
        {
            if (a == "")
                return "1";
            if (a == "1")
                return "11";

            int i = 0;
            int count = 1;
            string ret = "";
            while (i < a.Length-1)
            {
                if (a[i] == a[i + 1])
                    count++;
                else
                {
                    ret = ret + count.ToString() + a[i].ToString();
                    count = 1;
                }

                i++;
            }

            if (a[i] != a[i - 1])
                count = 1;

            ret = ret + count.ToString() + a[i].ToString();

            return ret;
        }

    }
}
