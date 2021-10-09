using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Interview1
    {
        int max = 0;
        public int FindMaxValue(int[] nums, int k, int[] M)
        {
            //Need to pick all k items
            //Given M.Length == k && k<= nums.Length
            Traverse(nums, k, M, 0, 0, nums.Length-1, 0);

            return max;
        }
        private void Traverse(int[] nums, int k, int[] M, int currentSum, int start, int end, int used)
        {
            if (k == used)
                max = Math.Max(currentSum, max);

            Traverse(nums, k, M, currentSum + nums[start] * M[used+1], start+1, end, used+1);
            Traverse(nums, k, M, currentSum + nums[end] * M[used + 1], start, end-1, used+1);
        }
    }
}
