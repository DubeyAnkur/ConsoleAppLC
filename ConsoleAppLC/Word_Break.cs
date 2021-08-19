using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Word_Break
    {
        Hashtable ht = new Hashtable();

        public bool WordBreak(string s, IList<string> wordDict)
        {
            if (s == "")
                return true;

            foreach (var w in wordDict)
                ht.Add(w, "");

            bool[] DP = new bool[s.Length+1];
            DP[0] = true;
            for (int i = 1; i<=s.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (DP[j] && ht.Contains(s.Substring(j, i - j)))
                    {
                        DP[i] = true;
                        break;
                    }
                }
            }
            return DP[s.Length];
            //return Traverse(s);
        }

        private bool Traverse(string s)
        {
            if (s == "")
                return true;

            for (int i = 1; i <= s.Length; i++)
            {
                var l = s.Substring(0, i);
                var r = s.Substring(i, s.Length - i);

                if (ht.Contains(l) && Traverse(r))
                {
                    return true;
                }
            }
            return false;
        }

    }
}
