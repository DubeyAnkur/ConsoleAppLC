using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Cheapest_Flights_Within_K_Stops
    {
        public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k)
        {
            int[,] graph = new int[n, n];

            for (int i = 0; i < flights.Length; i++)
            {
                int a = flights[i][0];
                int b = flights[i][1];
                int c = flights[i][2];

                if (graph[a, b] == 0)
                    graph[a, b] = c;
                else
                    graph[a, b] = Math.Min(graph[a, b], c);
                //graph[b,a] = c;
            }

            HashSet<int> read = new HashSet<int>();
            HashSet<int> write = new HashSet<int>();
            int[] costRead = new int[n];
            int[] costWrite = new int[n];

            Array.Fill(costRead, int.MaxValue);
            Array.Fill(costWrite, int.MaxValue);
            read.Add(src);
            costRead[src] = 0;

            for (int i = 0; i <= k; i++)
            {
                foreach (var c in read)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (graph[c, j] != 0)
                        {
                            costWrite[j] = Math.Min(costWrite[j], Math.Min(costRead[j], graph[c, j] + costRead[c]));
                            write.Add(j);
                        }
                    }
                }
                read = write;
                write = new HashSet<int>();

                for (int j = 0; j < n; j++)
                {
                    costRead[j] = Math.Min(costRead[j], costWrite[j]);
                    costWrite[j] = int.MaxValue;
                }
            }
            return costRead[dst] == int.MaxValue ? -1 : costRead[dst];
        }
    }
}
