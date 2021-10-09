using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Swap_Adjacent_in_LR_String
    {
        public bool CanTransform(string start, string end)
        {
            int N = start.Length;
            StringBuilder sb = new StringBuilder(start);
            int j = N;
            for (int i = N - 1; i >= 0; i--)
            {
                if (sb[i] != end[i] && end[i] == 'R')
                {
                    if(j > i) j = i;
                    while (j >= 0 && sb[j] == 'X')
                        j--;

                    if (j >= 0 && sb[j] == 'R' && j != i)
                    {
                        sb[i] = 'R';
                        sb[j] = 'X';
                    }
                    else
                        return false;
                }
            }
            j = 0;
            for (int i = 0; i < N; i++)
            {
                if (sb[i] != end[i])
                {
                    if(j < i) j = i;
                    while (j<N && sb[j] == 'X')
                        j++;

                    if (j<N && sb[j] == 'L' && j != i)
                    {
                        sb[i] = 'L';
                        sb[j] = 'X';
                    }
                    else
                        return false;
                }
            }
            return true;
        }
    }
}
