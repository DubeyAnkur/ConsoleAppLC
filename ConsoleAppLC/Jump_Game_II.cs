using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Jump_Game_II
    {
        public int Jump(int[] nums)
        {
            int ret = 0;

            int[] DP = new int[nums.Length];
            int maxReach = 0;
            int current = 0;

            while (maxReach < nums.Length-1)
            {
                if (current + nums[current] >= nums.Length)
                    return DP[current] + 1;
                int temp = Math.Max(1, maxReach - current);
                while (current + temp < nums.Length && temp <= nums[current])
                {
                    if (DP[current + temp] == 0 || DP[current + temp] > DP[current] + 1)
                        DP[current + temp] = DP[current] + 1;

                    maxReach = Math.Max(maxReach, current + temp);
                    temp++;
                }
                current++;
            }

            return DP[nums.Length-1];
        }
        public int Jump2(int[] nums)
        {
            int start = 0, end = 0;
            int step = 0;
            int maxEnd = 0;

            while (end < nums.Length - 1)
            {
                step++;
                for (int i = start; i <= end; i++)
                {
                    if (i + nums[i] > nums.Length - 1)
                        return step;
                    maxEnd = Math.Max(maxEnd, i + nums[i]);
                }
                start = end+1;
                end = maxEnd;
            }

            return step;
        }
        public int Jump3(int[] nums)
        {
            int start = 0, end = 0;
            int step = 0;
            int maxEnd = 0;

            while (end < nums.Length - 1)
            {
                step++;
                for (int i = end; i >= start; i--)
                {
                    if (i + nums[i] > nums.Length - 1)
                        return step;
                    maxEnd = Math.Max(maxEnd, i + nums[i]);
                }
                start = end + 1;
                end = maxEnd;
            }

            return step;
        }

    }
}
