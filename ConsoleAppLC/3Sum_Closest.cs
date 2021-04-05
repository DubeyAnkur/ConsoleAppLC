using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ConsoleAppLC
{
    class _3Sum_Closest
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            int ret = 1000000;

            Array.Sort(nums);

            for (int i = 0; i < nums.Length - 2; i++)
            {
                int j = i + 1;
                int k = nums.Length - 1;
                while (j < nums.Length - 1 && j < k)
                {
                    int temp = nums[i] + nums[j] + nums[k];

                    if (Math.Abs(temp - target) < Math.Abs(ret - target))
                        ret = temp;

                    if (temp > target)
                        k--;
                    else if (temp < target)
                        j++;
                    else if (temp == target)
                        return temp;
                }
            }

            return ret;
        }
    }
}
