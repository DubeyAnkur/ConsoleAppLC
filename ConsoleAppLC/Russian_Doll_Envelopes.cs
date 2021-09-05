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

            int N = envelopes.Length;
            int[] count = new int[N];

            Array.Fill(count, 1);
            int max = 1;

            for (int i = 0; i < N - 1; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    if (envelopes[i][0] < envelopes[j][0] && envelopes[i][1] < envelopes[j][1])
                    {
                        count[j] = Math.Max(count[i] + 1, count[j]);
                        max = Math.Max(max, count[j]);
                    }
                }
            }
            return max;
        }

        private int comparer(int[] a, int[] b)
        {
            if (a[0] > b[0])
                return 1;
            else if (a[0] < b[0])
                return -1;
            else
            {
                if (a[1] > b[1])
                    return 1;
                else if (a[1] < b[1])
                    return -1;
                else return 0;
            }
        }
    }
}
