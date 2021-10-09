using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Path_with_Maximum_Gold
    {
        int[,] Up;
        int[,] Down;
        int[,] Left;
        int[,] Right;
        bool[,] used;

        public int GetMaximumGold(int[][] grid)
        {
            int N = grid.Length;
            int M = grid[0].Length;

            Up = new int[N, M];
            Down = new int[N, M];
            Left = new int[N, M];
            Right = new int[N, M];

            used = new bool[N, M];
            int max = 0;
            for (int i = 0; i < N; i++)
                for (int j = 0; j < M; j++)
                {
                    if (grid[i][j] != 0)
                        max = Math.Max(max, Traverse(i, j, grid, 1));
                }
            return max;
        }

        private int Traverse(int i, int j, int[][] grid, int direction)
        {
            if (i < 0 || j < 0 || i >= grid.Length || j >= grid[0].Length) return 0;

            if (grid[i][j] == 0) return 0;

            if (used[i, j]) return GetMaxOfAll(i, j, direction);

            used[i, j] = true;

            int up = Traverse(i - 1, j, grid, 2);
            int down = Traverse(i + 1, j, grid, 1);
            int left = Traverse(i, j - 1, grid, 4);
            int right = Traverse(i, j + 1, grid, 3);

            Up[i, j] = up + grid[i][j];
            Down[i, j] = down + grid[i][j];
            Left[i, j] = left + grid[i][j];
            Right[i, j] = right + grid[i][j];

            return GetMaxOfAll(i, j, direction);
        }

        private int GetMaxOfAll(int i, int j, int direction)
        {
            int ret = 0;
            // 1 == up, 2 == down, 3 == left, 4 == right
            if (direction == 1)
            {
                ret = Math.Max(Down[i, j], Left[i, j]);
                ret = Math.Max(Right[i, j], ret);
            }
            else if (direction == 2)
            {
                ret = Math.Max(Up[i, j], Left[i, j]);
                ret = Math.Max(Right[i, j], ret);
            }
            else if (direction == 3)
            {
                ret = Math.Max(Up[i, j], Down[i, j]);
                ret = Math.Max(Right[i, j], ret);
            }
            else
            {
                ret = Math.Max(Up[i, j], Down[i, j]);
                ret = Math.Max(Left[i, j], ret);
            }

            return ret;
        }
    }
}
