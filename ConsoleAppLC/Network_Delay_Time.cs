using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Network_Delay_Time
    {
        public int NetworkDelayTime(int[][] times, int n, int k)
        {
            int[,] graph = new int[n + 1, n + 1];

            for (int i = 0; i < times.Length; i++)
            {
                int a = times[i][0];
                int b = times[i][1];
                int c = times[i][2];
                graph[a, b] = c;
            }

            List<int> ss = new List<int>();
            int[] path = new int[n + 1];
            Array.Fill(path, int.MaxValue);

            path[k] = 0;
            ss.Add(k);

            while (ss.Count > 0)
            {
                int cur = ss[ss.Count - 1];
                ss.RemoveAt(ss.Count - 1);

                for (int i = 0; i < n + 1; i++)
                {
                    if (graph[cur, i] != 0 && path[cur] + graph[cur, i] < path[i])
                    {
                        path[i] = path[cur] + graph[cur, i];
                        ss.Add(i);
                    }
                }
            }

            int max = int.MinValue;
            for (int i = 1; i < n + 1; i++)
            {
                if (path[i] == int.MaxValue)
                    return -1;
                else
                    max = Math.Max(max, path[i]);
            }
            return max;

        }
    }
}
