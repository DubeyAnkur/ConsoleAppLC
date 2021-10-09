using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace ConsoleAppLC
{
    class Maximum_Performance_of_a_Team
    {
        public int MaxPerformance1(int n, int[] speed, int[] efficiency, int k)
        {
            int max = 0;
            int sum = 0;
            int minE = int.MaxValue;
            int mod = (int)(Math.Pow(10, 9) + 7);
            HashSet<int> hs = new HashSet<int>();

            for (int j = 0; j < k; j++)
            {
                int localS = 0;
                int localE = minE;
                int localMax = 0;
                int lasti = 0;
                for (int i = 0; i < n; i++)
                {
                    if (hs.Contains(i))
                        continue;
                    int temp = (sum + speed[i]) * Math.Min(minE, efficiency[i]);
                    if (temp > localMax)
                    {
                        localS = speed[i];
                        localE = efficiency[i];
                        localMax = temp;
                        lasti = i;
                    }
                }
                hs.Add(lasti);
                sum = sum + localS;
                minE = Math.Min(minE, localE);
                max = Math.Max(max, localMax);
            }
            return max;
        }

        public int MaxPerformance(int n, int[] speed, int[] efficiency, int k)
        {
            BigInteger max = 0;
            int mod = (int)(Math.Pow(10, 9) + 7);
            SortedSet<int[]> ss = new SortedSet<int[]>(new ArrayExtension());
            int[][] eng = new int[n][];

            var r = new Random();
            for (int i = 0; i < n; i++)
            {
                eng[i] = new int[3];
                eng[i][0] = speed[i];
                eng[i][1] = efficiency[i];
                eng[i][2] = r.Next();
            }

            Array.Sort(eng, comparer);
            BigInteger sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum = sum + eng[i][0];
                ss.Add(eng[i]);

                if (ss.Count > k)
                {
                    sum = sum - ss.Min[0];
                    ss.Remove(ss.Min);
                }
                BigInteger temp = sum * eng[i][1];
                max = temp > max ? temp : max;
            }
            return (int)(max % mod);
        }

        public class ArrayExtension : IComparer<int[]>
        {
            public int Compare(int[] a, int[] b)
            {
                if (a[0] == b[0])
                    return a[2] - b[2];
                else
                    return a[0] - b[0];
            }
        }

        private int comparer(int[] a, int[] b)
        {
            return b[1] - a[1];
        }

    }
}
