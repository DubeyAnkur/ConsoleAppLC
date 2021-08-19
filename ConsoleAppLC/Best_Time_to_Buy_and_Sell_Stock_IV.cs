using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Best_Time_to_Buy_and_Sell_Stock_IV
    {
        public int MaxProfit(int k, int[] prices)
        {
            int spikes = 0;
            int profit = 0;
            int[] dir = new int[prices.Length - 1];

            for (int i = 1; i < prices.Length; i++)
            {
                dir[i - 1] = prices[i] < prices[i - 1] ? -1 : 1;
                if (prices[i] > prices[i - 1])
                    profit = profit + prices[i] - prices[i - 1];
            }
            for (int i = 1; i < dir.Length; i++)
                if (dir[i - 1] == 1 && dir[i] == -1)
                    spikes++;

            if (spikes < k) //Will not have last climb. Spike = Actual Spike or Actual spike -1;
                return profit;

            int maxProfit;
            int[,] DP = new int[k + 1, prices.Length];

            for (int i = 1; i < k + 1; i++)
            {
                maxProfit = -prices[0];
                for (int j = 1; j < prices.Length; j++)
                {
                    DP[i, j] = Math.Max(prices[j] + maxProfit, DP[i, j - 1]);
                    maxProfit = Math.Max(maxProfit, DP[i - 1, j] - prices[j]);
                }
            }
            return DP[k, prices.Length - 1];
        }


    }
}
