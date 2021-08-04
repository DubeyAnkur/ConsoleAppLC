using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Unique_Binary_Search_Trees
    {
        public int NumTrees(int n)
        {
            int[] mem = new int[n + 1];
            mem[0] = mem[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                int temp = 0;
                for (int j = 0; j < i; j++)
                {
                    temp = temp + mem[j] * mem[i-j-1];
                }
                mem[i] = temp;
            }
            return mem[n];
        }
    }
}
