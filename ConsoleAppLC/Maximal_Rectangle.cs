using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Maximal_Rectangle
    {
        public int MaximalRectangle(char[][] matrix)
        {
            int N = matrix.Length;
            if (N == 0) return 0;
            int M = matrix[0].Length;
            int[,] rows = new int[N, M];

            for (int i = 0; i < N; i++)
                for (int j = 0; j < M; j++)
                {
                    var x = matrix[i][j] == '0' ? 0 : 1;
                    rows[i, j] = i == 0 || x == 0 ? x : x + rows[i - 1, j];
                }
            int maxArea = 0;
            for (int i = 0; i < N; i++)
            {
                int j = 0;
                Stack<int> st = new Stack<int>();
                st.Push(-1);
                while (j<M)
                {
                    while (st.Peek() != -1 && rows[i, st.Peek()] > rows[i, j])
                    {
                        int h = rows[i, st.Pop()];
                        int w = j - st.Peek() - 1;
                        maxArea = Math.Max(maxArea, h * w);
                    }
                    st.Push(j++);
                }

                while(st.Peek() !=-1)
                {
                    int h = rows[i, st.Pop()];
                    int w = j - st.Peek() - 1;
                    maxArea = Math.Max(maxArea, h * w);
                }
            }
            return maxArea;
        }


    }
}
