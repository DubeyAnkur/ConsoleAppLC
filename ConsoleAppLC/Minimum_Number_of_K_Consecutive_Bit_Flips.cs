using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Minimum_Number_of_K_Consecutive_Bit_Flips
    {
        public int MinKBitFlips(int[] nums, int k)
        {
            int count = 0;
            int N = nums.Length;
            int flipCount = 0;
            bool[] end = new bool[N];

            for (int i = 0; i < N; i++)
            {
                bool flip = flipCount % 2 == 1;
                if ((nums[i] == 1 && flip) || (nums[i] == 0 && !flip))
                {
                    if (i + k - 1 >= N)
                        return -1;
                    end[i + k - 1] = true;

                    flipCount++;
                    count++;
                }
                if (end[i])
                    flipCount--;
            }
            return count;
        }
    }
}
