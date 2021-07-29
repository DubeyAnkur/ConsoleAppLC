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
            int maxArea = 0;
            Stack<int> st = null;

            for (int i = 0; i < N; i++)
            {
                st = new Stack<int>();
                st.Push(-1);
                for (int j = 0; j < M; j++)
                {
                    var x = matrix[i][j] == '0' ? 0 : 1;
                    rows[i, j] = i == 0 || x == 0 ? x : x + rows[i - 1, j];
                    while (st.Peek() != -1 && rows[i, st.Peek()] > rows[i, j])
                    {
                        int h = rows[i, st.Pop()];
                        int w = j - st.Peek() - 1;
                        maxArea = Math.Max(maxArea, h * w);
                    }
                    st.Push(j);
                }
                while (st.Peek() != -1)
                {
                    int h = rows[i, st.Pop()];
                    int w = M - st.Peek() - 1;
                    maxArea = Math.Max(maxArea, h * w);
                }
            }
            return maxArea;
        }

        public int MaximalRectangle3(char[][] matrix)
        {
            int N = matrix.Length;
            if (N == 0) return 0;
            int M = matrix[0].Length;
            int[,] rows = new int[N, M];
            int maxArea = 0;


            for (int i = 0; i < N; i++)
                for (int j = 0; j < M; j++)
                {
                    var x = matrix[i][j] == '0' ? 0 : 1;
                    rows[i, j] = i == 0 || x == 0 ? x : x + rows[i - 1, j];

                    int k = j;
                    int minHeight = rows[i, j];
                    while (k >= 0 && rows[i, j] > 0)
                    {
                        minHeight = Math.Min(minHeight, rows[i, k]);
                        maxArea = Math.Max(maxArea, minHeight * (j - k + 1));
                        k--;
                    }
                }
            return maxArea;
        }


        public int MaximalRectangle1(char[][] matrix)
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
                while (j < M)
                {
                    while (st.Peek() != -1 && rows[i, st.Peek()] > rows[i, j])
                    {
                        int h = rows[i, st.Pop()];
                        int w = j - st.Peek() - 1;
                        maxArea = Math.Max(maxArea, h * w);
                    }
                    st.Push(j++);
                }

                while (st.Peek() != -1)
                {
                    int h = rows[i, st.Pop()];
                    int w = j - st.Peek() - 1;
                    maxArea = Math.Max(maxArea, h * w);
                }
            }
            return maxArea;
        }

        public int MaximalRectangle2(char[][] matrix)
        {

            if (matrix.Length == 0 || matrix[0].Length == 0)
            {
                return 0;
            }

            var mat = matrix;
            var m = mat.Length;
            var n = mat[0].Length;
            int[][] dp = new int[m][];

            for (var i = 0; i < m; i++)
            {
                dp[i] = new int[n];
            }

            int result = 0;
            for (var i = 0; i < m; i++)
            {
                for (var j = 0; j < n; j++)
                {

                    if (mat[i][j] == '1')
                    {

                        result = Math.Max(result, GetMax(i, j, m, n, dp));
                    }

                }
            }

            return result;

        }

        public int GetMax(int i, int j, int m, int n, int[][] dp)
        {
            ////if()

            if (j > 0)
            {
                dp[i][j] = dp[i][j - 1] + 1;
            }
            else
            {
                dp[i][j] = 1;
            }

            int min = dp[i][j];
            int result = 1;
            int index = i;
            while (index >= 0 && dp[index][j] > 0)
            {

                min = Math.Min(min, dp[index][j]);
                result = Math.Max(result, min * (i - index + 1));
                index -= 1;
            }

            return result;



        }
    }
}
