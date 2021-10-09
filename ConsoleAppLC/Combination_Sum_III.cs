using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Combination_Sum_III
    {
        public IList<IList<int>> CombinationSum3(int k, int n)
        {
            var ret = new List<IList<int>>();

            if (k > n)
                return ret;

            DFS(ret, new List<int>(), n, k, 0, 0);
            return ret;
        }

        private void DFS(List<IList<int>> ret, List<int> path, int n, int k, int start, int sum)
        {
            if (path.Count == k - 1)
            {
                if (n - sum > start && n- sum <=9)
                {
                    var temp = new List<int>(path);
                    temp.Add(n - sum);
                    ret.Add(temp);
                }
                return;
            }

            for (int i = start + 1; i < n - sum && i<=9; i++)
            {
                if (n - sum > i)
                {
                    path.Add(i);
                    DFS(ret, path, n, k, i, sum + i);
                    path.RemoveAt(path.Count - 1);
                }
            }
        }
    }
}
