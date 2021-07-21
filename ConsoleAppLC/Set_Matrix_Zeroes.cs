using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Set_Matrix_Zeroes
    {
        public void SetZeroes(int[][] matrix)
        {
            int N = matrix.Length;
            int M = matrix[0].Length;
            bool isCol = false;

            for (int i = 0; i < N; i++)
            {
                if (matrix[i][0] == 0)
                    isCol = true;
                for (int j = 1; j < M; j++)
                    if (matrix[i][j] == 0)
                    {
                        matrix[i][0] = 0;
                        matrix[0][j] = 0;
                    }
            }
            for (int i = 1; i < N; i++)
                for (int j = 1; j < M; j++)
                    if (matrix[i][0] == 0 || matrix[0][j] == 0)
                    {
                        matrix[i][j] = 0;
                    }

            if (matrix[0][0] == 0)
            {
                for (int j = 0; j < M; j++)
                    matrix[0][j] = 0;
            }

            if (isCol)
            {
                for (int i = 0; i < N; i++)
                    matrix[i][0] = 0;
            }
        }

    }
}
