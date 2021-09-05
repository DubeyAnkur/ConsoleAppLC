using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Max_Area_of_Island
    {
        int gArea = 0;
        public int MaxAreaOfIsland(int[][] grid)
        {
            int N = grid.Length;
            int M = grid[0].Length;

            bool[,] trav = new bool[N, M];
            int MaxArea = 0;

            for (int i = 0; i < N; i++)
                for (int j = 0; j < M; j++)
                {
                    if (grid[i][j] == 1 && !trav[i, j])
                    {
                        gArea = 0;
                        DFS(grid, trav, i, j, N, M);
                        MaxArea = Math.Max(gArea, MaxArea);
                    }
                }
            return MaxArea;
        }

        private void DFS(int[][] grid, bool[,] trav, int i, int j, int N, int M)
        {
            if (i < 0 || j < 0 || i >= N || j >= M) return;
            if (grid[i][j] == 0 || trav[i, j]) return;

            trav[i, j] = true;
            gArea++;

            DFS(grid, trav, i + 1, j, N, M);
            DFS(grid, trav, i - 1, j, N, M);
            DFS(grid, trav, i, j + 1, N, M);
            DFS(grid, trav, i, j - 1, N, M);
        }
    }
}
