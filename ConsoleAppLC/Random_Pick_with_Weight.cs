using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Random_Pick_with_Weight
    {
        int total = 0;
        int[] we;
        int[] p;
        public Random_Pick_with_Weight(int[] w)
        {
            we = w;
            p = new int[w.Length];
            p[0] = w[0];
            for (int i = 0; i < w.Length; i++)
            {
                total = total + w[i];
                if (i > 0)
                    p[i] = p[i - 1] + w[i];
            }
        }

        public int PickIndex()
        {
            var r = new Random();
            int n = r.Next(1, total+1);

            //find index i which has p[i] < n < p[i+1]; 
            int i = 0, j = we.Length - 1;
            while (i < j)
            {
                int temp = (i + j) / 2;

                if (p[temp] == n)
                {
                    i = temp;
                    break;
                }
                else if (p[temp] > n)
                    j = temp;
                else
                    i = temp + 1;
            }
            return i;
        }
    }
}

