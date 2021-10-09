using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class _01_Matrix
    {
        public int[][] UpdateMatrix(int[][] mat)
        {
            int N = mat.Length;
            int M = mat[0].Length;
            int[] dir = new int[] { 0, 1, 0, -1, 0 };

            int startI = 0;
            int startJ = 0;
            bool[,] used = new bool[N, M];
            int[][] DP = new int[N][];

            for (int i = 0; i < N; i++)
            {
                DP[i] = new int[M];
                for (int j = 0; j < M; j++)
                {
                    if (mat[i][j] == 0)
                    {
                        startI = i;
                        startJ = j;
                        DP[i][j] = 0;
                    }
                    else
                        DP[i][j] = int.MaxValue;
                }
            }
            SortedSet<int[]> ss = new SortedSet<int[]>(new ArrayExtension());
            used[startI, startJ] = true;
            ss.Add(GetNew(0, startI, startJ));

            while (ss.Count > 0)
            {
                int[] cur = ss.Min;
                ss.Remove(cur);

                int p = cur[0], i = cur[1], j = cur[2];

                for (int k = 0; k < 4; k++)
                {
                    int newI = i + dir[k], newJ = j + dir[k + 1];

                    if (newI < 0 || newJ < 0 || newI >= N || newJ >= M || used[newI, newJ]) continue;

                    if (mat[newI][newJ] == 0 && !used[newI, newJ])
                    {
                        used[newI, newJ] = true;
                        ss.Add(GetNew(0, newI, newJ));
                    }
                    else
                    {
                        int newP = Math.Min(DP[newI][newJ], p + 1);
                        if (newP < DP[newI][newJ])
                        {
                            DP[newI][newJ] = newP;
                            ss.Add(GetNew(newP, newI, newJ));
                        }
                    }

                }

            }

            return DP;
        }

        private int[] GetNew(int p, int i, int j)
        {
            int[] ret = new int[4];
            var r = new Random();

            ret[0] = p;
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
