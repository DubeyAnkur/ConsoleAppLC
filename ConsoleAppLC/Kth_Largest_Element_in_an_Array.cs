using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Kth_Largest_Element_in_an_Array
    {
        public int FindKthLargest(int[] nums, int k)
        {
            int N = nums.Length;
            int index = N - k;

            if (N == 1)
                return nums[N - 1];

            int i = 0, j = 0, start = 0;

            while (i < N)
            {
                i = start;
                j = start;
                int r = new Random().Next(i, N);
                swap(nums, N-1, r);

                while (j < N - 1)
                {
                    if (i == j && nums[i] < nums[N - 1])
                        i++;
                    else if (nums[j] < nums[N - 1])
                    {
                        swap(nums, i, j);
                        i++;
                    }
                    j++;
                }
                swap(nums, i, N - 1);
                if (index == i)
                    return nums[index];
                else if (index > i)
                    start = i + 1;
                else if (index < i)
                {
                    N = i;
                    i = start;
                }
            }
            return nums[index];
        }

        private void swap(int[] nums, int j, int r)
        {
            int temp = nums[j];
            nums[j] = nums[r];
            nums[r] = temp;
        }
    }
}
