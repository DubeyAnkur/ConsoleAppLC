using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Jump_Game
    {
        public bool CanJump(int[] nums)
        {
            if (nums.Length == 0)
                return true;
            int i = 0;
            int j = nums[i];

            while (i <= j && i < nums.Length && j<nums.Length-1)
            {
                if (i + nums[i] > j)
                    j = i + nums[i];
                i++;
            }

            return j >= nums.Length-1;
        }
    }
}
