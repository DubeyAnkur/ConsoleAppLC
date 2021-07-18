using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Rotate_Image
    {
        public void Rotate(int[][] matrix)
        {
            int N = matrix.Length - 1;

            for (int i = 0; i <= N/2; i++)
            {
                for (int j = i; j < N-i; j++)
                {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[N - j][i];
                    matrix[N - j][i] = matrix[N - i][N - j];
                    matrix[N - i][N -j] = matrix[j][N - i];
                    matrix[j][N - i] = temp;
                }
            }
        }


    }
}
