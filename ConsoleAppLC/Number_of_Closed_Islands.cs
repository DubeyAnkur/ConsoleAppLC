using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Number_of_Closed_Islands
    {
        public int ClosedIsland(int[][] grid)
        {
            int N = grid.Length;
            int M = grid[0].Length;

            int count = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (grid[i][j] == 0 && Traverse(grid, i, j, N, M))
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        private bool Traverse(int[][] grid, int i, int j, int N, int M)
        {
            if (i < 0 || j < 0 || i >= N || j >= M)
                return false;

            if (grid[i][j] == 1) return true;

            grid[i][j] = 1;

            bool r1 = Traverse(grid, i + 1, j, N, M);
            bool r2 = Traverse(grid, i - 1, j, N, M);
            bool r3 = Traverse(grid, i, j + 1, N, M);
            bool r4 = Traverse(grid, i, j - 1, N, M);

            return r1 && r2 && r3 && r4;
        }
    }
}
