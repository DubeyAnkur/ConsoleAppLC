using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Search_a_2D_Matrix
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            int N = matrix.Length;
            int M = matrix[0].Length;
            int i = 0;
            int j = N * M - 1;

            while (i <= j)
            {
                int temp = (i + j) / 2;
                if (matrix[temp/M][temp%M] == target)
                    return true;
                else if (target > matrix[temp / M][temp % M])
                    i = temp + 1;
                else
                    j = temp - 1;
            }

            return false;
        }
    }
}
