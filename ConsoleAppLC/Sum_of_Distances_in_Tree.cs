using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Sum_of_Distances_in_Tree
    {
        public int[] SumOfDistancesInTree(int n, int[][] edges)
        {
            int[,] DP = new int[n, n];

            for (int i = 0; i < edges.Length; i++)
            {
                DP[edges[i][0], edges[i][1]] = 1;
                DP[edges[i][1], edges[i][0]] = 1;
            }


            bool loop = false;
            for (int k = 0; k < n; k++)
            {
                loop = false;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (DP[i, j] != 0)
                        {
                            for (int x = 0; x < n; x++)
                                if (DP[j, x] != 0 && x != i)
                                {
                                    if (DP[x, i] == 0)
                                    {
                                        DP[x, i] = DP[x, j] + 1;
                                        DP[i, x] = DP[j, x] + 1;
                                    }
                                    else
                                    {
                                        DP[x, i] = Math.Min(DP[x, i], DP[x, j] + 1);
                                        DP[i, x] = Math.Min(DP[x, i], DP[j, x] + 1);
                                    }
                                }
                        }
                        else if (i != j)
                            loop = true;
                    }
                }
                if (!loop)
                    break;
            }
            int[] ret = new int[n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    ret[i] = ret[i] + DP[i, j];
                }
            }

            return ret;
        }
    }
}
