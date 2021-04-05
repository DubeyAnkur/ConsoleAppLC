using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Letter_Combinations_of_a_Phone_Number
    {

        public IList<string> LetterCombinations(string digits)
        {
            List<string> ret = new List<string>();
            string[] map = GetMapping();

            Recurse("", digits, map, 0, digits.Length, ret);

            return ret;
        }

        private void Recurse(string parent, string digits, string[] map, int level, int maxLevel, List<string> ret)
        {
            if (level == maxLevel)
            {
                if(parent != "")
                    ret.Add(parent);
                return;
            }
            int current = (int)(digits[level]) - 48;
            foreach (var c in map[current])
            {
                Recurse(parent + c, digits, map, level + 1, maxLevel, ret);
            }
            
        }

        private string[] GetMapping()
        {
            string[] ret = new string[10];
            ret[2] = "abc";
            ret[3] = "def";
            ret[4] = "ghi";
            ret[5] = "jkl";
            ret[6] = "mno";
            ret[7] = "pqrs";
            ret[8] = "tuv";
            ret[9] = "wxyz";

            return ret;
        }
    }
}
