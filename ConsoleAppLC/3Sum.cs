using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppLC
{
    public class _3Sum
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> ret = new List<IList<int>>();

            var ht = new Hashtable();
            Array.Sort(nums);

            for (int n = 0; n < nums.Length; n++)
            {
                if (!ht.ContainsKey(nums[n]))
                    ht.Add(nums[n], n);
                else
                    ht[nums[n]] = n;
            }

            int i = 0;
            while (i < nums.Length - 2)
            {
                int a = nums[i];
                i++;
                int j = i;
                while (j < nums.Length - 1)
                {
                    int b = nums[j];
                    int c = 0 - a - b;

                    if (ht.ContainsKey(c))
                    {
                        int lastIndex = (int)ht[c];
                        if (lastIndex > j)
                        {
                            List<int> temp = new List<int>();
                            temp.Add(a); temp.Add(b); temp.Add(c);

                            ret.Add(temp);
                        }
                        j++;
                        while (nums[j] == nums[j - 1] && j < nums.Length - 1)
                            j++;
                    }
                    else
                        j++;
                }
                while (nums[i] == nums[i - 1] && i < nums.Length - 2)
                    i++;
            }

            return ret;
        }

    }
}
