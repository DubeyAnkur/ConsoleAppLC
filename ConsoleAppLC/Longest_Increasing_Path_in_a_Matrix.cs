using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Longest_Increasing_Path_in_a_Matrix
    {
        public int LongestIncreasingPath(int[][] matrix)
        {
            int N = matrix.Length;
            int M = matrix[0].Length;

            int[,] DP = new int[N, M];

            for (int i = 0; i < N; i++)
                for (int j = 0; j < M; j++)
                {
                    DP[i, j] = -1;
                }

            for (int i = 0; i < N; i++)
                for (int j = 0; j < M; j++)
                {
                    if (DP[i, j] == -1)
                        Traverse(matrix, DP, i, j, N, M);
                }

            //find max
            int maxLength = 0;
            for (int i = 0; i < N; i++)
                for (int j = 0; j < M; j++)
                {
                    maxLength = Math.Max(maxLength, DP[i, j]);
                }

            return maxLength;
        }

        private int Traverse(int[][] matrix, int[,] DP, int i, int j, int N, int M)
        {

            if (DP[i, j] >= 0)
                return DP[i, j];

            int maxPath = 0;
            if (i < N - 1 && matrix[i][j] < matrix[i + 1][j])
                maxPath = Math.Max(maxPath, Traverse(matrix, DP, i + 1, j, N, M) + 1);
            if (i > 0 && matrix[i][j] < matrix[i - 1][j])
                maxPath = Math.Max(maxPath, Traverse(matrix, DP, i - 1, j, N, M) + 1);
            if (j < M - 1 && matrix[i][j] < matrix[i][j + 1])
                maxPath = Math.Max(maxPath, Traverse(matrix, DP, i, j + 1, N, M) + 1);
            if (j > 0 && matrix[i][j] < matrix[i][j - 1])
                maxPath = Math.Max(maxPath, Traverse(matrix, DP, i, j - 1, N, M) + 1);

            DP[i, j] = maxPath;
            return maxPath;
        }
    }
}
