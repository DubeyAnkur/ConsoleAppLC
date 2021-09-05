using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Repeated_DNA_Sequences
    {
        public IList<string> FindRepeatedDnaSequences(string s)
        {
            HashSet<string> hs = new HashSet<string>();
            HashSet<string> hs1 = new HashSet<string>();

            var ret = new List<string>();

            for (int i = 0; i + 9 < s.Length; i++)
            {
                var temp = s.Substring(i, 10);
                if (hs.Contains(temp))
                    hs1.Add(temp);
                else
                    hs.Add(temp);
            }
            foreach (var r in hs1)
                ret.Add(r);
            return ret;
        }
    }
}
