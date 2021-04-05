using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Find_First_and_Last_Position_of_Element_in_Sorted_Array
    {
        public int[] SearchRange(int[] nums, int target)
        {
            int i = 0;
            int j = nums.Length-1;
            int start = -1;
            while (i < j)
            {
                int k = (i + j) / 2;
                if (nums[k] >= target)
                    j = k;
                else
                    i = k + 1;
            }

            if (nums.Length == 0 || nums[i] != target)
                return new int[] { -1, -1 };
            else
                start = i;

            j = nums.Length - 1;
            while (i < j)
            {
                int k = ((i + j) / 2) + 1;
                if (nums[k] <= target)
                    i = k;
                else
                    j = k-1;
            }

            return new int[] { start, j };
        }
    }
}
