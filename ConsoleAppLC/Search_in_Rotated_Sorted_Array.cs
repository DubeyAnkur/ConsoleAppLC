using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Search_in_Rotated_Sorted_Array
    {
        public int Search(int[] nums, int target)
        {
            int ret = -1;

            int i = 0;
            int j = nums.Length - 1;

            while (i < j)
            {
                int k = (i + j) / 2;
                if (nums[k] == target)
                    return k;
                if (nums[k] >= nums[i])
                {
                    if (nums[i] <= target && nums[k] >= target)
                    {
                        j = k;
                    }
                    else
                    {
                        i = k+1;
                    }
                }
                else
                {
                    if (nums[k] <= target && nums[j] >= target)
                    {
                        i = k;
                    }
                    else
                    {
                        j = k-1;
                    }
                }
            }

            if (nums[i] == target)
                return i;
            return ret;

        }
    }
}
