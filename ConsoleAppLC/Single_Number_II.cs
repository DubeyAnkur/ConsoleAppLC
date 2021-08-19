using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Single_Number_II
    {
        public int SingleNumber(int[] nums)
        {
            int total = 0;
            int xor = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                xor = xor ^ nums[i];
                total = total + nums[i];
            }

            var ret = (total + 3 * xor) / 4;

            return ret;
        }
    }
}
