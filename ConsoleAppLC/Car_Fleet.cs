using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Car_Fleet
    {
        public int CarFleet(int target, int[] position, int[] speed)
        {
            int N = speed.Length;
            int[][] mem = new int[N][];

            for (int i = 0; i < N; i++)
            {
                mem[i] = new int[3] { position[i], speed[i], i };
            }

            Array.Sort(mem, comparer);

            double currentMax = 0;
            int count = 0;
            for (int i = 0; i < N; i++)
            {
                int p = mem[i][0];
                int s = mem[i][1];
                double temp = (double)(target - p) / s;

                if (temp > currentMax)
                {
                    currentMax = temp;
                    count++;
                }

            }
            return count;
        }

        private int comparer(int[] a, int[] b)
        {
            return b[0] - a[0];
        }
    }
}
