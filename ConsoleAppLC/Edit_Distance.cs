using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Edit_Distance
    {
        //Same Logic reduced code
        public int MinDistance(string word1, string word2)
        {
            int N = word1.Length;
            int M = word2.Length;
            int[,] DP = new int[N + 1, M + 1];

            for (int i = 1; i <= N; i++)
            {
                DP[i, 0] = i;
            }
            for (int j = 1; j <= M; j++)
            {
                DP[0, j] = j;
            }

            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= M; j++)
                {
                    if (word1[i-1] == word2[j-1])
                        DP[i, j] = DP[i - 1, j - 1];
                    else
                        DP[i, j] = Math.Min(DP[i - 1, j - 1], Math.Min(DP[i, j - 1], DP[i - 1, j])) + 1;
                }
            }
            return DP[N, M];
        }

        public int MinDistance_1(string word1, string word2)
        {
            int N = word1.Length;
            int M = word2.Length;
            bool[] used = new bool[N];

            int[,] DP = new int[N, M];

            bool tempUsed = false;

            if (N == 0 || M == 0)
                return Math.Max(N, M);

            if (word1[0] == word2[0])
            {
                used[0] = true;
                tempUsed = true;
            }
            else
            { DP[0, 0] = 1; }

            for (int i = 1; i < N; i++)
            {
                if (!tempUsed && word2[0] == word1[i])
                {
                    DP[i, 0] = DP[i - 1, 0];
                    tempUsed = true;
                    used[i] = true;
                }
                else
                    DP[i, 0] = DP[i - 1, 0] + 1;
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 1; j < M; j++)
                {
                    if (word1[i] == word2[j])
                    {
                        if (used[i])
                        {
                            if (i == 0)
                                DP[i, j] = DP[i, j - 1] + 1;
                            else
                                DP[i, j] = DP[i - 1, j - 1];
                        }
                        else
                        {
                            if (i == 0)
                                DP[i, j] = DP[i, j - 1];
                            else
                                DP[i, j] = Math.Min(DP[i, j - 1], Math.Min(DP[i - 1, j - 1], DP[i - 1, j] + 1));
                            used[i] = true;
                        }
                    }
                    else
                    {
                        if (i == 0)
                            DP[i, j] = DP[i, j - 1] + 1;
                        else
                            DP[i, j] = Math.Min(DP[i, j - 1], Math.Min(DP[i - 1, j - 1], DP[i - 1, j])) + 1;
                    }
                }
            }

            return DP[N - 1, M - 1];
        }
    }
}
