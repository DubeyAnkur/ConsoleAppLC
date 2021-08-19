using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Longest_Consecutive_Sequence
    {
        public int LongestConsecutive(int[] nums)
        {
            int max = 0;
            Hashtable ht = new Hashtable();
            for (int i = 0; i < nums.Length; i++)
                if (!ht.Contains(nums[i]))
                    ht.Add(nums[i], 1);

            for (int i = 0; i < nums.Length; i++)
            {
                int x = nums[i];
                while (ht.Contains(x-1))
                    x--;

                int seq = 0;
                while (ht.Contains(x))
                { 
                    seq++;
                    ht.Remove(x);
                    x++;
                }
                max = Math.Max(max, seq);
            }

            return max;
        }

    }
}
