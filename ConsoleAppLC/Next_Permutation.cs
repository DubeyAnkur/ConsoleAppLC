using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ConsoleAppLC
{
    class Next_Permutation
    {
        public void NextPermutation(int[] nums)
        {
            int N = nums.Length;
            List<int> lst = new List<int>();
            int i = N - 2;
            for (; i >= 0; i--)
            {
                lst.Add(nums[i + 1]);
                if (nums[i] < nums[i + 1])
                    break;
            }

            if (i < 0)
            {
                Array.Reverse(nums);
                return;
            }

            bool replaced = false;
            for (int j = i + 1; j < N; j++)
            {
                if (lst[0] <= nums[i] || replaced)
                {
                    nums[j] = lst[0];
                    lst.RemoveAt(0);
                }
                else // should run only once.
                {
                    int temp = nums[i];
                    nums[i] = lst[0];
                    nums[j] = temp;
                    replaced = true;
                    lst.RemoveAt(0);
                }
            }
        }
    }
}
