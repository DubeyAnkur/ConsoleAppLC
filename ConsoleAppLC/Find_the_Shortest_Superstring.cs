using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Find_the_Shortest_Superstring
    {
        int maxLength = int.MaxValue;
        List<int> bestPath;
        public string ShortestSuperstring1(string[] words)
        {
            int N = words.Length;
            int[,] DP = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (i != j)
                        DP[i, j] = Diff(words[i], words[j]);
                }
            }
            Traverse(words, DP, new List<int>(), 0);

            string ret = words[bestPath[0]];
            for (int i = 1; i < bestPath.Count; i++)
            {
                ret = ret + Merge(bestPath[i - 1], bestPath[i], words, DP);
            }
            return ret;
        }
        private string Merge(int a, int b, string[] words, int[,] DP)
        {
            string w = words[b];
            return w.Substring(w.Length - DP[a, b], DP[a, b]);
        }

        private void Traverse(string[] words, int[,] DP, List<int> path, int length)
        {
            if (path.Count == words.Length)
            {
                if (length < maxLength)
                {
                    maxLength = length;
                    bestPath = new List<int>(path);
                }
                return;
            }

            for (int i = 0; i < words.Length; i++)
            {
                if (!path.Contains(i))
                {
                    int total = length;
                    if (path.Count > 0)
                    {
                        int last = path[path.Count - 1];
                        total = length + DP[last, i];
                    }
                    else
                        total = words[i].Length;

                    path.Add(i);

                    Traverse(words, DP, path, total);
                    path.RemoveAt(path.Count - 1);
                }
            }
        }

        private int Diff(string a, string b)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == b[0])
                {
                    int j = 0;
                    while (j < b.Length && j + i < a.Length && a[i + j] == b[j])
                        j++;

                    if (j >= a.Length - i)
                    {
                        //return j - 1;
                        return b.Length - j;
                    }
                }
            }
            return b.Length;
        }

        private string MergeEnd(int a, int b, string[] words, int[,] DP)
        {
            string w = words[a];
            return w.Substring(0, w.Length - words[b].Length + DP[a, b]);
        }



        public string ShortestSuperstring(string[] words)
        {
            int N = words.Length;
            int[,] DP = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (i != j)
                        DP[i, j] = Diff(words[i], words[j]);
                }
            }

            int minPos = int.MaxValue;
            int minJ = 0;
            int M = 1 << N;
            int[,] big = new int[N, M];
            int[,] path = new int[N, M];

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                    big[j, i] = int.MaxValue;

                for (int j = 0; j < N; j++)
                {
                    int c = 1 << j;
                    if ((i & c) > 0)
                    {
                        int prev = i - c;
                        if (prev == 0)
                            big[j, i] = words[j].Length;
                        else
                        {
                            for (int k = 0; k < N; k++)
                            {
                                if (big[k, prev] < int.MaxValue && big[k, prev] + DP[k, j]< big[j, i])
                                {
                                    big[j, i] = big[k, prev] + DP[k, j];
                                    path[j, i] = k;
                                }
                            }
                        }
                    }
                }


                if (i == M - 1)
                {
                    for (int k = 0; k < N; k++)
                    {
                        if (minPos > big[k, i])
                        {
                            minPos = big[k, i];
                            minJ = k; 
                        }
                    }
                }
            }

            int ri = M - 1;
            string ret = words[minJ];
            int rk = 0;

            while (ri - (1 << minJ) > 0)
            {
                rk = path[minJ, ri];
                ret = MergeEnd(rk, minJ, words, DP) + ret;
                ri = ri - (1 << minJ);
                minJ = rk;
            }
            return ret;
        }




    }
}
