using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Combinations
    {
        public IList<IList<int>> Combine(int n, int k)
        {
            var ret = new List<IList<int>>();

            recurse(ret, new List<int>(), n, k, 0);

            return ret;
        }

        void recurse(List<IList<int>> ret, List<int> current, int n, int k, int last)
        {
            if (current.Count == k)
            {
                ret.Add(new List<int>(current));
            }
            else {
                for (int i = last+1; i <= n && last+k-current.Count <=n ; i++)
                {
                    current.Add(i);
                    recurse(ret, current, n, k, i);
                    current.Remove(i);
                }
            }
        }
    }
}
