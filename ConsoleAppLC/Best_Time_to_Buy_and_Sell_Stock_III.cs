using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Best_Time_to_Buy_and_Sell_Stock_III
    {

        public int MaxProfit(int[] prices)
        {
            if (prices.Length < 2)
                return 0;
            var (midI, midJ) = getIndex(prices, 0, prices.Length);
            var (leftI, leftJ) = getIndex(prices, 0, midI);
            var (rightI, rightJ) = getIndex(prices, midJ + 1, prices.Length);

            int left = prices[leftJ] - prices[leftI];
            int right = prices[rightJ] - prices[rightI];
            int mid = prices[midJ] - prices[midI];

            int edge = Math.Max(left, right);

            int maxProfit = 0;
            int i = midJ, j = midJ;
            int xI = 0, xJ = 0;
            while (j > midI)
            {
                if (maxProfit < prices[j] - prices[i])
                {
                    maxProfit = prices[j] - prices[i];
                    xI = i;
                    xJ = j;
                }
                if (prices[i] > prices[j])
                    i = j;
                j--;
            }

            int mid1 = prices[xJ] - prices[midI];
            int mid2 = prices[midJ] - prices[xI];

            return Math.Max(mid + edge, mid1+mid2);
        }

        private (int, int) getIndex(int[] prices, int start, int end)
        {
            int maxProfit = 0;
            int i = start, j = start + 1;
            int retI = 0, retJ = 0;
            while (j < end)
            {
                if (maxProfit < prices[j] - prices[i])
                {
                    maxProfit = prices[j] - prices[i];
                    retI = i;
                    retJ = j;
                }
                if (prices[i] > prices[j])
                    i = j;
                j++;
            }

            return (retI, retJ);
        }

    }
}
