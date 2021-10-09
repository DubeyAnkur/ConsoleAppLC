using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Unique_Paths_III
    {
        int total = 0;
        public int UniquePathsIII(int[][] grid)
        {
            int emptySquare = 0;
            int startI = 0, startJ = 0;

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 0)
                        emptySquare++;
                    else if (grid[i][j] == 1)
                    {
                        startI = i;
                        startJ = j;
                    }
                }
            }
            bool[,] used = new bool[grid.Length, grid[0].Length];
            Traverse(grid, startI+1, startJ, emptySquare, 0, used);
            Traverse(grid, startI-1, startJ, emptySquare, 0, used);
            Traverse(grid, startI, startJ+1, emptySquare, 0, used);
            Traverse(grid, startI, startJ-1, emptySquare, 0, used);

            return total;
        }

        private void Traverse(int[][] grid, int i, int j, int em, int path, bool[,] used)
        {
            if (i < 0 || j < 0 || i >= grid.Length || j >= grid[0].Length) return;

            if (grid[i][j] == 2 && path == em)
            {
                total++;
                return;
            }

            if (used[i, j] || grid[i][j] != 0) return;

            used[i, j] = true;

            Traverse(grid, i + 1, j, em, path + 1, used);
            Traverse(grid, i - 1, j, em, path + 1, used);
            Traverse(grid, i, j + 1, em, path + 1, used);
            Traverse(grid, i, j - 1, em, path + 1, used);

            used[i, j] = false;
        }
    }
}
