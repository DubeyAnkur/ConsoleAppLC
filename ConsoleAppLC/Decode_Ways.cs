using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Decode_Ways
    {

        public int NumDecodings(string s)
        {
            int[] count = new int[s.Length];
            if (s == "" || s.Substring(0,1) == "0")
                return 0;
            count[0] = 1;

            for (int i = 1; i < s.Length; i++)
            {
                int one = Convert.ToInt32(s.Substring(i, 1));
                int two = Convert.ToInt32(s.Substring(i-1, 2));

                if (one > 0 && one <= 9)
                    count[i] = count[i - 1];
                if (two > 9 && two <= 26)
                {
                    if (i > 1)
                        count[i] = count[i] + count[i - 2];
                    else
                        count[i] = s.Substring(i, 1) == "0" ? 1 : 2;
                }
            }
            return count[s.Length-1];
        }

        public int NumDecodings1(string s)
        {
            int[] count = new int[1];
            if (s == "" || s == "0")
                return 0;

            FormTree(s, count, 0);

            return count[0];
        }

        private void FormTree(string s, int[] count, int start)
        {
            if (start >= s.Length - 1)
            {
                count[0]++;
                return;
            }
            if (s[start] == '0') return;

            if (start < s.Length - 1 && s[start+1] != '0')
                FormTree(s, count, start + 1);
            if (start <= s.Length - 2 && Convert.ToInt16(s.Substring(start, 2)) <= 26)
                FormTree(s, count, start + 2);

        }
    }
}
