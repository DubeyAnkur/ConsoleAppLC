using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Russian_Doll_Envelopes
    {
        public int MaxEnvelopes(int[][] envelopes)
        {
            Array.Sort(envelopes, comparer);

            List<List<int>> piles = new List<List<int>>();
            piles.Add(new List<int>() { 0 });

            for (int i = 1; i < envelopes.Length; i++)
            {
                AddEnvToPile(envelopes, piles, i);
            }

            return piles.Count;
        }

        private void AddEnvToPile(int[][] env, List<List<int>> piles, int i)
        {
            var lp = piles[piles.Count - 1];

            if (env[lp[lp.Count - 1]][0] < env[i][0] && env[lp[lp.Count - 1]][1] < env[i][1])
            {
                piles.Add(new List<int>() { i });
            }
            else
            {
                int j = 0, k = piles.Count - 1;

                while (j < k)
                {
                    int mid = (j + k) / 2;

                    var mp = piles[mid];
                    int id = mp[mp.Count - 1];
                    if (env[i][0] > env[id][0] && env[i][1] > env[id][1])
                        j = mid+1;
                    else
                        k = mid;
                }
                piles[j].Add(i);
            }
        }

        private int comparer(int[] a, int[] b)
        {
            if (a[0] != b[0])
                return a[0] - b[0];
            else
                return b[1] - a[1];
        }
    }
}