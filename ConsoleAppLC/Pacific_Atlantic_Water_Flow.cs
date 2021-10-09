using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Pacific_Atlantic_Water_Flow
    {
        public IList<IList<int>> PacificAtlantic(int[][] heights)
        {
            int N = heights.Length;
            int M = heights[0].Length;

            bool[,] P = new bool[N, M];
            bool[,] A = new bool[N, M];
            bool[,] used = new bool[N, M];

            for (int i = 0; i < N; i++)
                for (int j = 0; j < M; j++)
                {
                    if (i == 0 || j == 0)
                        P[i, j] = true;
                    if(P[i,j] && !used[i,j])
                        Traverse(heights, i, j, P, used, heights[i][j]);
                }

            used = new bool[N,M];
            for (int i = 0; i < N; i++)
                for (int j = 0; j < M; j++)
                {
                    if (i == N-1 || j == M-1)
                        A[i, j] = true;
                    if (A[i, j] && !used[i, j])
                        Traverse(heights, i, j, A, used, heights[i][j]);
                }

            var ret = new List<IList<int>>();
            for (int i = 0; i < N; i++)
                for (int j = 0; j < M; j++)
                    if (P[i, j] && A[i, j])
                        ret.Add(new List<int>() { i, j });

            return ret;
        }

        private void Traverse(int[][] heights, int i, int j, bool[,] P, bool[,] used, int h)
        {
            if (i < 0 || j < 0 || i >= heights.Length || j >= heights[0].Length || used[i, j]) return;
                
            if (h > heights[i][j]) return;

            used[i, j] = true;
            P[i, j] = true;
            Traverse(heights, i + 1, j, P, used, heights[i][j]);
            Traverse(heights, i - 1, j, P, used, heights[i][j]);
            Traverse(heights, i, j + 1, P, used, heights[i][j]);
            Traverse(heights, i, j - 1, P, used, heights[i][j]);

        }
    }
}
