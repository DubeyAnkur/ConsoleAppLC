using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Spiral_Matrix
    {
        public IList<int> SpiralOrder(int[,] matrix)
        {
            int N = matrix.GetLength(0);
            int M = matrix.GetLength(1);

            var lst = new List<int>();
            var dirI = new int[] { 0, 1, 0, -1 };
            var dirJ = new int[] { 1, 0, -1, 0 };
            int direction = 0;
            bool[,] used = new bool[N, M];
            int i = 0, j = 0;

            while (lst.Count < N * M && i < N && j < M && !used[i, j])
            {
                lst.Add(matrix[i, j]);
                used[i, j] = true;

                if(i+ dirI[direction] == N || j + dirJ[direction] == M || j + dirJ[direction] < 0 || used[i + dirI[direction], j + dirJ[direction]])
                    direction = (++direction) % 4;

                i = i + dirI[direction];
                j = j + dirJ[direction];
            }

            return lst;
        }
    }
}
