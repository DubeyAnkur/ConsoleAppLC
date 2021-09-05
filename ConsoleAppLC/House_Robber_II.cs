using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class House_Robber_II
    {
        public int Rob(int[] nums)
        {
            int N = nums.Length;
            if (N == 1)
                return nums[0];

            int a = Rob(nums, 0, N-1);
            int b = Rob(nums, 1, N);
            return Math.Max(a, b);
        }

        private int Rob(int[] nums, int start, int end)
        {
            int N = end - start;
            if (N == 1)
                return nums[start];

            int inc = 0, exc = 0;
            for (int j = start; j < end; j++)
            {
                int i = exc + nums[j];
                int e = Math.Max(inc, exc);

                inc = i; exc = e;
            }
            return Math.Max(inc, exc);
        }
    }
}
