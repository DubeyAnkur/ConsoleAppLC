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

            Traverse(nums, k, M, currentSum + nums[start] * M[used], start+1, end, used+1);
            Traverse(nums, k, M, currentSum + nums[end] * M[used], start, end-1, used+1);
        }

        public int FindMaxValue1(int[] nums, int k, int[] M)
        {
            int[,] DP = new int[k,nums.Length];
            int left =  TraverseDP(nums, k, M, 1, nums.Length - 1, 0, 0, DP);
            int right = TraverseDP(nums, k, M, 0, nums.Length - 2, 0, nums.Length-1, DP);

            return Math.Max(left, right);
        }
        private int TraverseDP(int[] nums, int k, int[] M, int start, int end, int used, int current, int[,] DP)
        {
            if (used == k)
                return 0;

            if (DP[used, current] != 0)
                return DP[used, current];

            int left = TraverseDP(nums, k, M, start + 1, end, used + 1, start, DP);
            int right = TraverseDP(nums, k, M, start, end - 1, used + 1, end, DP);

            DP[used, current] = Math.Max(left, right) + nums[current] * M[used];

            return DP[used, current];
        }


    }
}
