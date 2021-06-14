using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Trapping_Rain_Water
    {
        public int Trap(int[] height)
        {
            int ret = 0;

            int N = height.Length;
            int[] left = new int[N];
            int[] right = new int[N];

            
            for (int i = 1; i < N; i++)
            {
                left[i] = Math.Max(left[i - 1], height[i - 1]);
                right[N - 1 - i] = Math.Max(right[N- i], height[N - i]);
            }

            for (int i = 0; i < N; i++)
            {
                int softMin = Math.Min(left[i], right[i]);
                if (softMin > height[i])
                    ret = ret + (softMin - height[i]);
            }

            return ret;
        }

        public int Trap2(int[] height)
        {
            if (height.Length == 0)
                return 0;
            int left = 0;
            int right = height.Length - 1;
            int leftSide = height[0];
            int rightSide = height[right];

            int ret = 0;

            while (left < right)
            {
                if (height[left] > height[right])
                {
                    ret = ret + Math.Min(leftSide, rightSide) - height[right];
                    right--; 
                    rightSide = Math.Max(rightSide, height[right]);
                }
                else
                {
                    ret = ret + Math.Min(leftSide, rightSide) - height[left];
                    left++;
                    leftSide = Math.Max(leftSide, height[left]);
                }
            }

            return ret;
        }
    }
}
