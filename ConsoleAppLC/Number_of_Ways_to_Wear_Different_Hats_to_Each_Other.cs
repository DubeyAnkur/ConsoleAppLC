using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Number_of_Ways_to_Wear_Different_Hats_to_Each_Other
    {
        public int numberWays(List<List<int>> hats)
        {
            int n = hats.Count;
            int[,] dp = new int[n,30];
            return dfs(hats, n, 0, 0, dp);
        }
        // dfs(...i, assignedHats...) number of ways to assign different hats for `i` people keep in mind that `assignedHats` is
        //    the mask of list of hats that we already assigned
        int dfs(List<List<int>> hats, int n, int i, long assignedHats, int[,] dp)
        {
            if (i == n) return 1; // assigned different hats to n people
            if (dp[i,assignedHats] != 0) return dp[i,assignedHats];
            int ans = 0;
            foreach (int hat in hats[i])
            {
                if (((assignedHats >> hat) & 1) == 1) continue; // Skip if this `hat` was already assigned
                ans += dfs(hats, n, i + 1, assignedHats | (1L << hat), dp);
                ans %= 1_000_000_007;
            }
            return dp[i,assignedHats] = ans;
        }
    }
}
