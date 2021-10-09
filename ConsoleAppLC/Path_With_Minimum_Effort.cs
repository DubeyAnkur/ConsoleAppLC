using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Path_With_Minimum_Effort
    {
        public int MinimumEffortPath(int[][] heights)
        {
            int N = heights.Length;
            int M = heights[0].Length;
            int[] dir = new int[] { 0, 1, 0, -1, 0 };

            int[,] DP = new int[N, M];

            for (int i = 0; i < N; i++)
                for (int j = 0; j < M; j++)
                    DP[i, j] = int.MaxValue;

            DP[0, 0] = 0;
            int[] start = GetNew(0, 0, 0);
            SortedSet<int[]> ss = new SortedSet<int[]>(new ArrayExtension());

            ss.Add(start);

            while (ss.Count > 0)
            {
                int[] cur = ss.Min;
                ss.Remove(cur);

                int d = cur[0], i = cur[1], j = cur[2];
                if (i == N - 1 && j == M - 1) return d;

                for (int k = 0; k < 4; k++)
                {
                    int newI = i + dir[k];
                    int newJ = j + dir[k + 1];

                    if (newI < 0 || newJ < 0 || newI >= N || newJ >= M) continue;

                    int newD = Math.Max(DP[i,j], Math.Abs(heights[i][j] - heights[newI][newJ]));

                    if (newD < DP[newI, newJ])
                    {
                        DP[newI, newJ] = newD;
                        ss.Add(GetNew(newD, newI, newJ));
                    }
                }
            }

            return DP[N - 1, M - 1];
        }

        private int[] GetNew(int d, int i, int j)
        {
            int[] ret = new int[4];
            var r = new Random();

            ret[0] = d;
            ret[1] = i;
            ret[2] = j;
            ret[3] = r.Next();

            return ret;
        }

        public class ArrayExtension : IComparer<int[]>
        {
            public int Compare(int[] a, int[] b)
            {
                if (a[0] == b[0])
                    return a[3] - b[3];
                else
                    return a[0] - b[0];
            }
        }
    }
}
