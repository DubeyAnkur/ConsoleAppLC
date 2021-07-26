using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Search_in_Rotated_Sorted_Array_II
    {
        public bool Search(int[] nums, int target)
        {
            int i = 0, j = nums.Length - 1;

            while (i <= j)
            {
                int temp = (i + j) / 2;

                if (nums[temp] == target) return true;

                if (nums[temp] == nums[i] && nums[temp] == nums[j])
                {
                    i++; j--;
                }
                else if (nums[i] == target || nums[j] == target)
                    return true;
                else if (nums[temp] <= nums[j])
                    if (nums[temp] < target && target <= nums[j])
                        i = temp + 1;
                    else
                        j = temp - 1;
                else
                {
                    if (nums[i] <= target && target < nums[temp])
                        j = temp - 1;
                    else
                        i = temp + 1;
                }
            }
            return false;
        }
    }
}
