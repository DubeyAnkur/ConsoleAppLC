using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Permutations_II
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            var ret = new List<IList<int>>();
            Array.Sort(nums);
            Recurse(ret, new List<int>(), nums, new bool[nums.Length]);
            return ret;
        }

        public void Recurse(List<IList<int>> ret, List<int> current, int[] nums, bool[] used)
        {
            if (current.Count == nums.Length)
                ret.Add(new List<int>(current));
            else
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (!(used[i] || i > 0 && nums[i] == nums[i - 1] && !used[i - 1]))
                    {
                        current.Add(nums[i]);
                        used[i] = true;
                        Recurse(ret, current, nums, used);
                        current.RemoveAt(current.Count - 1);
                        used[i] = false;
                    }
                }
            }
        }


    }
}
