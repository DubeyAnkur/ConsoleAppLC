using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Permutations
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            var ret = new List<IList<int>>();

            Recurse(ret, new List<int>(), nums);

            return ret;
        }

        public void Recurse(List<IList<int>> ret, List<int> current, int[] nums)
        {
            if (current.Count == nums.Length)
                ret.Add(new List<int>(current));
            else
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (!current.Contains(nums[i]))
                    {
                        current.Add(nums[i]);
                        Recurse(ret, current, nums);
                        current.RemoveAt(current.Count-1);
                    }
                }
            }
        }



    }
}
