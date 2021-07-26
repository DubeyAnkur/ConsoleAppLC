using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ConsoleAppLC
{
    class Subsets1
    {
        public IList<IList<int>> Subsets(int[] nums)
        {
            var ret = new List<IList<int>>();

            bool[] used = new bool[nums.Length];
            backtrack(ret, new List<int>(), nums, 0);

            return ret;
        }

        private void backtrack(IList<IList<int>> ret, List<int> current, int[] nums, int start)
        {
            ret.Add(new List<int>(current));
            for (int i = start; i < nums.Length; i++)
            {
                current.Add(nums[i]);
                backtrack(ret, current, nums, i + 1);
                //current.Remove(nums[i]);
                current.RemoveAt(current.Count - 1);
            }
        }
    }
}
