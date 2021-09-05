using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Rotate_Array
    {
        public void Rotate(int[] nums, int k)
        {
            int N = nums.Length;
            k = k % N;

            if (k == 0)
                return;

            int j = N - k;
            for (int i = 0; i < N; i++)
            {
                if (j == N)
                {
                    k = k % (N-i);
                    j = N - k;
                }
                if (k == 0)
                    return;

                int temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;

                j++;
            }
        }
    }
}
