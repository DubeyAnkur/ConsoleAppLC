using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Maximum_Points_You_Can_Obtain_from_Cards
    {
        public int MaxScore(int[] cardPoints, int k)
        {
            int currentSum = 0;
            int maxSum = 0;

            for (int i = 0; i < k; i++)
                currentSum = currentSum + cardPoints[i];

            maxSum = currentSum;
            if (k == cardPoints.Length)
                return maxSum;

            for (int i = 0; i < k; i++)
            {
                currentSum = currentSum - cardPoints[k - 1 - i] + cardPoints[cardPoints.Length - 1 - i];
                maxSum = Math.Max(currentSum, maxSum);
            }
            return maxSum;
        }
    }
}
