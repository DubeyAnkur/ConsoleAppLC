using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Permutation_Sequence
    {
        public string GetPermutation(int n, int k)
        {
            string s = "";
            int[] perm = new int[n];
            perm[0] = 1;
            List<int> order = new List<int>();

            for (int i = 1; i < n; i++)
            {
                perm[i] = perm[i - 1] * i;
                order.Add(i);
            }
            order.Add(n);
            int x = n-1;
            int count = 0;
            while (s.Length < n)
            {
                count = (k-1) / perm[x];
                k = k - (perm[x] * count);
                s = s + order[count];
                order.RemoveAt(count);
                x--;
            }

            return s;
        }
    }
}
