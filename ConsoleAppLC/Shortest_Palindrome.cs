using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Shortest_Palindrome
    {
        public string ShortestPalindrome(string s)
        {
            int N = s.Length;
            if (N == 0)
                return "";
            int[] DP = new int[N];
            int l = 0, r = 0, pl = 1;

            int mlo = 0;
            //Odd length palindrome
            for (int i = 0; i <= N / 2; i++)
            {
                pl = 1;
                if (r > i)
                    pl = Math.Min(r - i + 1, DP[l + r - i]);

                while (i - pl >= 0 && i + pl < N && s[i - pl] == s[i + pl])
                    pl++;

                DP[i] = pl;

                if (r < i + pl - 1)
                {
                    l = i - pl + 1;
                    r = i + pl - 1;
                }
                if (l == 0)
                    mlo = Math.Max(mlo, pl);
            }
            //Odd length palindrome

            DP = new int[N];
            int ple = 0, mle = 0;
            l = 0; r = 0;
            for (int i = 1; i <= N / 2; i++)
            {
                ple = 0;
                if (r > i)
                    ple = Math.Min(r - i + 1, DP[l + r - i + 1]);
                while (i - ple - 1 >= 0 && i + ple < N && s[i - ple - 1] == s[i + ple])
                    ple++;

                DP[i] = ple;

                if (r < i + ple)
                {
                    l = i - ple;
                    r = i + ple - 1;

                    if (l == 0)
                        mle = Math.Max(mle, ple);
                }
            }

            int start = Math.Max(mlo * 2 - 1, mle * 2);
            string pre = "";
            for (int i = start; i < s.Length; i++)
            {
                pre = s[i] + pre;
            }

            return pre + s;
        }
    }
}
