using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Contains_Duplicate_III
    {
        public bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t)
        {
            Hashtable ht = new Hashtable();

            for (int i = 0; i < nums.Length; i++)
            {
                long val = (long)nums[i] - int.MinValue;
                long bIndex = val / (t + 1);

                if (ht.Contains(bIndex))
                {
                    return true;
                }
                else
                {
                    ht.Add(bIndex, i);
                }

                if (ht.Contains(bIndex - 1))
                {
                    int j = (int)ht[bIndex - 1];
                    if (i - j <= k && Math.Abs((long)nums[i] - nums[j]) <= t)
                        return true;
                }
                if (ht.Contains(bIndex + 1))
                {
                    int j = (int)ht[bIndex + 1];
                    if (i - j <= k && Math.Abs((long)nums[i] - nums[j]) <= t)
                        return true;
                }
                
                if (i - k >= 0)
                {
                    if (nums[i] != nums[i - k])
                    {
                        val = (long)nums[i - k] - int.MinValue;
                        bIndex = val / (t + 1);

                        ht.Remove(bIndex);
                    }
                    else
                    {
                        ht[bIndex] = i;
                    }
                }

            }

            return false;
        }
    }
}
