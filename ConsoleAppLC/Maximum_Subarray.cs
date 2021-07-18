using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Maximum_Subarray
    {
        public int MaxSubArray(int[] nums)
        {
            int maxSum = int.MinValue;
            int temp = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                temp = temp + nums[i];
                maxSum = Math.Max(temp, maxSum);
                temp = Math.Max(0, temp);
            }
            return maxSum;
        }
    }
}
