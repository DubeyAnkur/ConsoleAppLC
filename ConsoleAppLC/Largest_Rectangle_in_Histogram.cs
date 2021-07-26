using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Largest_Rectangle_in_Histogram
    {
        public int LargestRectangleArea(int[] heights)
        {
            int maxArea = 0;
            Stack<int> st = new Stack<int>();
            st.Push(-1);
            int i = 0;
            while (i < heights.Length)
            {
                while (st.Peek() != -1 && heights[st.Peek()] > heights[i])
                {
                    int h = heights[st.Pop()];
                    int w = i - st.Peek() - 1;
                    maxArea = Math.Max(maxArea, h * w);
                }
                st.Push(i++);
            }

            while (st.Peek() != -1)
            {
                int h = heights[st.Pop()];
                int w = i - st.Peek() - 1;
                maxArea = Math.Max(maxArea, h * w);
            }

            return maxArea;
        }
        public int LargestRectangleArea2(int[] heights)
        {
            Stack<int> st = new Stack<int>();
            st.Push(-1);
            int i = 0, n = heights.Length, maxArea = 0;
            while (i < n)
            {
                while (st.Peek() != -1 && heights[st.Peek()] > heights[i])
                {
                    int h = heights[st.Pop()];
                    int w = i - st.Peek() - 1;
                    maxArea = Math.Max(maxArea, h * w);
                }

                st.Push(i++);
            }

            while (st.Peek() != -1)
            {
                int h = heights[st.Pop()];
                int w = n - 1 - st.Peek();
                maxArea = Math.Max(maxArea, h * w);
            }

            return maxArea;
        }
        public int LargestRectangleArea1(int[] heights)
        {
            int N = heights.Length;
            int[] left = new int[N];
            int[] right = new int[N];
            Stack<int> stLeft = new Stack<int>();
            Stack<int> stRight = new Stack<int>();

            for (int i = 0; i < N; i++)
            {
                while (stLeft.Count > 0 && heights[stLeft.Peek()] >= heights[i])
                    stLeft.Pop();
                left[i] = stLeft.Count > 0 ? stLeft.Peek() + 1 : 0;
                stLeft.Push(i);

                while (stRight.Count > 0 && heights[stRight.Peek()] >= heights[N - i - 1])
                    stRight.Pop();
                right[N - i - 1] = stRight.Count > 0 ? stRight.Peek() - 1 : N - 1;
                stRight.Push(N - i - 1);
            }

            int maxArea = 0;
            for (int i = 0; i < N; i++)
                maxArea = Math.Max(maxArea, (right[i] - left[i] + 1) * heights[i]);

            return maxArea;
        }
    }
}
