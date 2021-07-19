using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Unique_Paths
    {
        public int UniquePaths(int m, int n)
        {
            int c = Math.Max(m, n);
            int k = Math.Min(m, n);

            n = c + k - 2;
            m = k - 1;

            c = Math.Max(m, n - m);
            k = Math.Min(m, n - m);


            long num = 1;
            for (int i = c+1; i <= n; i++)
            {
                num = num * i;
            }
            long den = 1;
            for (int i = 1; i <= k; i++)
            {
                den = den * i;
            }

            return (int)(num / den);

        }
    }
}
