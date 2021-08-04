using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Subsets_II
    {
        public IList<IList<int>> SubsetsWithDup(int[] nums)
        {
            var ret = new List<IList<int>>();
            bool[] used = new bool[nums.Length];
            Array.Sort(nums);

            Recurse(ret, new List<int>(), used, nums, 0);

            return ret;
        }

        private void Recurse(List<IList<int>> ret, List<int> current, bool[] used, int[] nums, int start)
        {
            ret.Add(new List<int>(current));
            for (int i = start; i < used.Length; i++)
            {
                if (!used[i] && (i == 0 || nums[i] != nums[i - 1] || used[i - 1]))
                {
                    used[i] = true;
                    current.Add(nums[i]);
                    Recurse(ret, current, used, nums, i+1);
                    used[i] = false;
                    current.RemoveAt(current.Count-1);
                }
            }
        }

    }
}
