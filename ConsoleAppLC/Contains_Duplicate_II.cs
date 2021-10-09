using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Contains_Duplicate_II
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            Hashtable ht = new Hashtable();

            for (int i = 0; i < nums.Length; i++)
            {
                if (ht.Contains(nums[i]))
                {
                    int j = (int)ht[nums[i]];
                    if (i - j <= k)
                        return true;
                    ht[nums[i]] = i;
                }
                else
                    ht.Add(nums[i], i);
            }
            return false;
        }
    }
}
