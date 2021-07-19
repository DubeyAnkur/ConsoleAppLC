using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Minimum_Path_Sum
    {
        public int MinPathSum(int[][] grid)
        {
            int N = grid.Length;
            int M = grid[0].Length;
            int[,] DP = new int[N, M];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (i == 0 && j == 0)
                        DP[i, j] = grid[i][j];
                    else
                    {
                        int top = i == 0 ? 200 : DP[i - 1, j];
                        int left = j == 0 ? 200 : DP[i, j - 1];
                        DP[i, j] = grid[i][j] + Math.Min(top, left);
                    }
                }
            }

            return DP[N-1, M-1];
        }
    }
}
