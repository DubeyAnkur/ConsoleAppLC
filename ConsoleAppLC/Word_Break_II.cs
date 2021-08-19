using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Word_Break_II
    {
        HashSet<string> hs = new HashSet<string>();
        List<List<string>> ret;
        public IList<string> WordBreak(string s, IList<string> wordDict)
        {
            ret = new List<List<string>>();
            if (s == "")
                return new List<string>();

            foreach (var w in wordDict)
                hs.Add(w);

            Traverse(s, new List<string>());
            List<string> output = new List<string>();

            foreach (var l in ret)
            {
                var temp = l[0];
                for (int i = 1; i < l.Count; i++)
                {
                    temp = temp + " " + l[i];
                }
                output.Add(temp);
            }
            return output;
        }

        private void Traverse(string s, List<string> path)
        {
            if (s == "")
            {
                ret.Add(new List<string>(path));
                return;
            }

            for (int i = 1; i <= s.Length; i++)
            {
                var l = s.Substring(0, i);
                var r = s.Substring(i, s.Length - i);

                if (hs.Contains(l))
                {
                    path.Add(l);
                    Traverse(r, path);
                    path.RemoveAt(path.Count - 1);
                }
            }


        }
    }
}
