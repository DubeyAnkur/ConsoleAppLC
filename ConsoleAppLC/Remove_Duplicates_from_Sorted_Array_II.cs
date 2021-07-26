using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Remove_Duplicates_from_Sorted_Array_II
    {
        public int RemoveDuplicates(int[] nums)
        {
            int i = 0;
            foreach (var num in nums)
                if (i < 2 || num > nums[i - 2])
                    nums[i++] = num;
            return i;
        }

        public int RemoveDuplicates1(int[] nums)
        {

            if (nums.Length <= 2)
                return nums.Length;

            int i = 1, j = 2;
            while (j < nums.Length)
            {
                if (nums[j] == nums[j - 1] && nums[j] == nums[j - 2])
                {
                    if (nums[i] == nums[j] && nums[i] != nums[i-1])
                        i++;
                    j++;
                }
                else
                    nums[++i] = nums[j++];
            }

            return i+1;
        }
    }
}
