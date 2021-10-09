using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Redundant_Connection
    {
        public int[] FindRedundantConnection(int[][] edges)
        {
            int N = edges.Length;

            int[] root = new int[N + 1];

            for (int i = 0; i < N; i++)
            {
                int[] e = edges[i];
                int aRoot = e[0];
                int bRoot = e[1];

                while (root[aRoot] != 0)
                    aRoot = root[aRoot];

                if (root[bRoot] == 0)
                    root[bRoot] = aRoot;
                else
                {
                    while (root[bRoot] != 0)
                    {
                        int temp = bRoot;
                        bRoot = root[bRoot];
                        root[temp] = aRoot;
                    }
                    root[bRoot] = aRoot;
                }
                if (aRoot == bRoot)
                    return e;
            }
            return null;
        }
    }
}
