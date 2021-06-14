using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Wildcard_Matching
    {
        public bool IsMatch(string s, string p)
        {
            bool[,] DP = new bool[s.Length+1, p.Length+1];
            DP[0, 0] = true;

            int i = 1;
            while (i <= p.Length && p[i-1] == '*')
            { DP[0, i] = true; i++; }

            for (i = 1; i <= s.Length; i++)
            {
                for (int j = 1; j <= p.Length; j++)
                {
                    if (s[i-1] == p[j-1] || p[j-1] == '?')
                        DP[i, j] = DP[i - 1, j - 1];
                    else if (p[j-1] == '*')
                        DP[i, j] = DP[i - 1, j] || DP[i, j - 1];
                }
            }

            return DP[s.Length, p.Length];
        }
        public bool IsMatch2(string s, string p)
        {
            int sInd = 0;
            int pInd = 0;
            int starInd = -1;
            int match = 0;

            while (sInd < s.Length )
            {
                if (pInd < p.Length && (s[sInd] == p[pInd] || p[pInd] == '?'))
                {
                    sInd++;
                    pInd++;
                }
                else if (pInd < p.Length && p[pInd] == '*')
                {
                    starInd = pInd;
                    pInd++;
                    match = sInd;
                }
                else if(starInd >= 0)
                {
                    pInd = starInd + 1;
                    match++;
                    sInd = match;
                }
                else
                {
                    return false;
                }
            }

            while (pInd < p.Length && p[pInd] == '*')
            {
                pInd++;
            }

            return pInd == p.Length;
            
        }

    }
}
