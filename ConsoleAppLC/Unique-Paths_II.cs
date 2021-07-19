using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Unique_Paths_II
    {
        public int UniquePathsWithObstacles(int[][] obstacleGrid)
        {
            int N = obstacleGrid.Length;
            int M = obstacleGrid[0].Length;
            int[,] DP = new int[N, M];
            

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (obstacleGrid[i][j] == 0)
                    {
                        if (i == 0 && j == 0)
                            DP[0, 0] = 1;
                        else
                        {
                            int top = i == 0 ? 0 : DP[i - 1, j];
                            int left = j == 0 ? 0 : DP[i, j - 1];

                            DP[i, j] = top + left;
                        }
                    }
                }
            }

            return DP[N - 1, M - 1];
        }
    }
}
