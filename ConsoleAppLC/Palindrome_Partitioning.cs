using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Palindrome_Partitioning
    {
        List<IList<string>> ret = new List<IList<string>>();
        public IList<IList<string>> Partition(string s)
        {
            Traverse(s, new List<string>());
            return ret;
        }

        private void Traverse(string s, List<string> arr)
        {
            if (s.Length == 0)
                ret.Add(new List<string>(arr));

            for (int i = 1; i <= s.Length; i++)
            {
                var l = s.Substring(0, i);
                var r = s.Substring(i, s.Length - i);
                if (IsPalindrome(l))
                {
                    arr.Add(l);
                    Traverse(r, arr);
                    arr.RemoveAt(arr.Count - 1);
                }
            }
        }

        private bool IsPalindrome(string s)
        {
            if (s.Length <= 1)
                return true;
            else
            {
                for (int i = 0; i < s.Length / 2; i++)
                {
                    if (s[i] != s[s.Length - i - 1])
                        return false;
                }
            }
            return true;
        }



    }
}
