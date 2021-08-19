using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Palindrome_Partitioning_II
    {
        public int MinCut(string s)
        {
            int N = s.Length;
            if (N <= 1)
                return 0;

            int[] DP = new int[N + 1];// Its index will be +1 of s index.
            for (int i = 1; i <= N; i++)
                DP[i] = 300000;
            DP[0] = -1;
            int le, lo, re, ro;
            le = re = lo = ro = -1;

            int[] odd = new int[s.Length];
            int[] even = new int[s.Length];

            for (int i = 0; i < s.Length; i++)
            {
                //Odd
                int pl = 1;
                if (i < ro)
                    pl = Math.Min(ro - i + 1, odd[lo + ro - i]);

                while (i - pl >= 0 && i + pl < N && s[i - pl] == s[i + pl])
                {
                    DP[i + 1 + pl] = Math.Min(DP[i + 1 + pl], DP[i - pl] + 1);
                    pl++;
                }
                DP[i + pl] = Math.Min(DP[i + pl], DP[i - pl + 1] + 1); // If Above loop is not entered.
                DP[i+1] = Math.Min(DP[i+1], DP[i] + 1); // Updating Self

                odd[i] = pl;
                if (i + pl - 1 > ro)
                {
                    lo = i - pl + 1;
                    ro = i + pl - 1;
                }

                //Even
                int cur = 0; //same as pl
                if (i < re)
                    cur = Math.Min(re - i + 1, even[le + re - i + 1]);

                while (i + cur < N && i - 1 - cur >= 0 && s[i - 1 - cur] == s[i + cur])
                {
                    DP[i + 1 + cur] = Math.Min(DP[i + 1 + cur], DP[i - cur - 1] + 1);
                    cur++;
                }
                if(i - cur - 1 >= 0 && i + cur <= N) 
                    DP[i + cur] = Math.Min(DP[i + cur], DP[i - cur] + 1); // If Above loop is not entered.

                even[i] = cur;
                if (i + cur - 1 > re)
                {
                    le = i - cur;
                    re = i + cur - 1;
                }
            }

            return DP[N];
        }

    }
}
