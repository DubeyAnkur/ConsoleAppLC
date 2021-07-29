using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Scramble_String
    {

        public bool IsScramble(String s1, String s2)
        {
            if (s1 == s2) return true;
            int len = s1.Length;

            bool[,,] F = new bool[len, len, len + 1];
            for (int k = 1; k <= len; ++k)
                for (int i = 0; i + k <= len; ++i)
                    for (int j = 0; j + k <= len; ++j)
                        if (k == 1)
                            F[i, j, k] = s1.Substring(i, 1) == s2.Substring(j, 1);
                        else for (int q = 1; q < k && !F[i, j, k]; ++q)
                            {
                                F[i, j, k] = (F[i, j, q] && F[i + q, j + q, k - q]) || (F[i, j + k - q, q] && F[i + q, j, k - q]);
                            }
            return F[0, 0, len];
        }

        public bool IsScramble1(string s1, string s2)
        {
            if (s1 == s2)
                return true;
            else
            {
                int[] primes = new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101 };
                return DFS(s1, s2, primes);
            }
        }

        bool DFS(string s1, string s2, int[] primes)
        {
            if (s1 == s2)
                return true;

            int[] letters = new int[26];
            long a = 1, b = 1;

            for (int i = 0; i < s1.Length; i++)
            {
                letters[s1[i] - (int)'a']++;
                letters[s2[i] - (int)'a']--;
            }

            for (int i = 0; i < 26; i++)
                if (letters[i] != 0) return false;

            if (s1.Length <= 3) return true;

            for (int i = 1; i < s1.Length; i++)
            {
                if (DFS(s1.Substring(0, i), s2.Substring(0, i), primes) && DFS(s1.Substring(i), s2.Substring(i), primes))
                    return true;
                if (DFS(s1.Substring(0, i), s2.Substring(s2.Length - i), primes) && DFS(s1.Substring(i), s2.Substring(0, s2.Length - i), primes))
                    return true;
            }
            return false;
        }

    }
}
