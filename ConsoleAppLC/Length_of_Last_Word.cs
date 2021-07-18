using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Length_of_Last_Word
    {
        public int LengthOfLastWord(string s)
        {
            int count = 0;
            s = s.Trim();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == ' ')
                    break;
                count++;
            }
            return count;
        }
    }
}
