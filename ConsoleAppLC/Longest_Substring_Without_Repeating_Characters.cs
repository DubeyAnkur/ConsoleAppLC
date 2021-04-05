using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Longest_Substring_Without_Repeating_Characters
    {
        public int LengthOfLongestSubstring(string s)
        {
            int maxLen = 0;
            int[] memory = new int[128];

            for (int i = 0; i < memory.Length; i++)
                memory[i] = -1;

            int start = 0;

            for (int i = 0; i < s.Length; i++)
            {
                int c = (int)s[i];
                if (memory[c] >= 0)
                {
                    int temp = i - start;
                    if (temp > maxLen)
                        maxLen = temp;

                    int last = memory[c];
                    if(last + 1 > start)
                        start = last + 1;
                    memory[c] = i;
                }
                else
                {
                    memory[c] = i;
                }
            }

            if (s.Length - start > maxLen)
                maxLen = s.Length - start;

            return maxLen;
        }
    }
}
