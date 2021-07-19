using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Spiral_Matrix_II
    {
        public int[][] GenerateMatrix(int n)
        {
            int[][] memory = new int[n][];
            int count = 1;
            int[] dirI = new int[] { 0,1,0,-1};
            int[] dirJ = new int[] { 1,0,-1,0};
            int i = 0, j = 0;
            int d = 0;
            int[][] ret = new int[n][];

            for (int x = 0; x < n; x++)
            {
                memory[x] = new int[n];
            }

            while (count <= n * n)
            {
                memory[i][j] = count;

                if (i + dirI[d] == n || j + dirJ[d] == n || j + dirJ[d] < 0 || memory[i + dirI[d]][j + dirJ[d]] != 0)
                        d = (++d) % 4;

                i = i + dirI[d];
                j = j + dirJ[d];
                count++;
            }

            return memory;

        }
    }
}
