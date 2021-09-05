using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Maximum_Gap
    {
        public int MaximumGap(int[] nums)
        {
            int N = nums.Length;
            int Min = int.MaxValue;
            int Max = int.MinValue;

            if (N < 2)
                return 0;

            for (int i = 0; i < N; i++)
            {
                Min = Math.Min(Min, nums[i]);
                Max = Math.Max(Max, nums[i]);
            }

            int bucketSize = (int)Math.Ceiling((float)(Max - Min) / (N-1));

            if (bucketSize == 0)
                return 0;

            int[] bucketMin = new int[N];
            int[] bucketMax = new int[N];

            Array.Fill(bucketMin, int.MaxValue);
            Array.Fill(bucketMax, int.MinValue);

            for (int i = 0; i < N; i++)
            {
                int bIndex = (nums[i] - Min) / bucketSize;
                bucketMin[bIndex] = Math.Min(bucketMin[bIndex], nums[i]);
                bucketMax[bIndex] = Math.Max(bucketMax[bIndex], nums[i]);
            }

            int maxGap = 0;
            int previous = Min;
            for (int i = 0; i < N; i++)
            {
                if (bucketMin[i] == int.MaxValue && bucketMax[i] == int.MinValue)
                    continue;
                
                maxGap = Math.Max(maxGap, bucketMax[i] - bucketMin[i]);
                maxGap = Math.Max(maxGap, bucketMin[i] - previous);

                previous = bucketMax[i];
            }

            return maxGap;
        }
    }
}
