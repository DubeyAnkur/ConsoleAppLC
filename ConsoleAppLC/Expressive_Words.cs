using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Expressive_Words
    {
        public int ExpressiveWords(string s, string[] words)
        {
            int count = 0;
            int N = s.Length;
            for (int i = 0; i < words.Length; i++)
            {
                int j = 0;
                int k = 0;

                if (N < words[i].Length)
                    continue;

                int tempCount = 0;
                int lastCount = 0;
                while (j < N && k < words[i].Length)
                {
                    if (words[i][k] == s[j])
                    {
                        if(k != words[i].Length-1)
                            k++;
                        else
                            lastCount++;
                        j++;
                        tempCount++;
                    }
                    else
                    {
                        while (k > 0 && k < words[i].Length && j < N && words[i][k - 1] == s[j])
                        {
                            tempCount++;
                            j++;
                        }
                        if (tempCount < 3)
                            break;
                        tempCount = 0;
                    }
                }
                if (j == N && k >= words[i].Length - 1 && lastCount != 2)
                    count++;
            }

            return count;
        }
    }
}
