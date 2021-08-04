using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Interleaving_String
    {
        public bool IsInterleave(string s1, string s2, string s3)
        {
            if (s1.Length + s2.Length != s3.Length)
                return false;

            int N = s1.Length, M = s2.Length;
            bool[,] mem = new bool[N + 1, M + 1];

            mem[0, 0] = true;
            for (int i = 0; i <= N; i++)
            {
                for (int j = 0; j <= M; j++)
                {
                    if (i == 0 && j == 0)
                        continue;
                    if (i == 0)
                    {
                        if (s3[i + j - 1] == s2[j - 1])
                            mem[i, j] = mem[i, j - 1];
                    }
                    else if (j == 0)
                    {
                        if (s3[i + j - 1] == s1[i - 1])
                            mem[i, j] = mem[i - 1, j];
                    }
                    else if (s3[i + j - 1] == s1[i - 1] && s3[i + j - 1] == s2[j - 1])
                        mem[i, j] = mem[i, j - 1] || mem[i - 1, j];
                    else if (s3[i + j - 1] == s1[i - 1])
                        mem[i, j] = mem[i - 1, j];
                    else if (s3[i + j - 1] == s2[j - 1])
                        mem[i, j] = mem[i, j - 1];
                }
            }

            return mem[N, M];
        }
    }
}
