using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Maximum_Score_from_Performing_Multiplication_Operations
    {
        public int MaximumScore(int[] nums, int[] multipliers)
        {
            int N = multipliers.Length;
            int[,] DP = new int[N, N];
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                    DP[i, j] = int.MinValue;

            TraverseDP(nums, multipliers, 0, 0, DP);

            return DP[0, 0];
        }

        private int TraverseDP(int[] nums, int[] M, int start, int used, int[,] DP)
        {
            if (used == M.Length)
                return 0;

            if (DP[start, used] != int.MinValue)
                return DP[start, used];

            int end = nums.Length - 1 + start - used;
            int left = TraverseDP(nums, M, start + 1, used + 1, DP) + nums[start] * M[used];
            int right = TraverseDP(nums, M, start, used + 1, DP) + nums[end] * M[used];

            DP[start, used] = Math.Max(left, right);

            return DP[start, used];
        }
    }
}
