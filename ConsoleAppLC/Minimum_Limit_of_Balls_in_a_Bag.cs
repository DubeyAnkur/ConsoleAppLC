using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Minimum_Limit_of_Balls_in_a_Bag
    {
        public int MinimumSize(int[] nums, int maxOperations)
        {
            int i = 1;
            int j = nums[nums.Length - 1];

            for (int k = 0; k < nums.Length; k++)
                j = Math.Max(nums[k], j);

            while (i < j)
            {
                int mid = (i + j) / 2;

                if (Possible(nums, maxOperations, mid))
                    j = mid;
                else
                    i = mid + 1;
            }
            return i;
        }

        private bool Possible(int[] nums, int mo, int mid)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int cut = (nums[i]-1) / mid;
                mo = mo - cut;

                if (mo < 0)
                    return false;
            }
            return true;
        }
    }
}
