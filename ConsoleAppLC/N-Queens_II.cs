using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    public class N_Queens_II
    {
        public int TotalNQueens(int n)
        {
            var perm = new List<List<int>>();
            bool[] used = new bool[n];
            FindValidPerm(perm, new List<int>(), n, used);

            return perm.Count;
        }
        void FindValidPerm(List<List<int>> perm, List<int> current, int n, bool[] used)
        {
            if (current.Count == n)
            {
                perm.Add(new List<int>(current));
                return;
            }

            for (int i = 0; i < n; i++)
            {
                if (!used[i])
                {
                    var conflict = false;
                    for (int j = 0; j < current.Count; j++)
                    {
                        int k = current[current.Count - j - 1];
                        if (i - j - 1 == k || i + j + 1 == k)
                            conflict = true;
                    }
                    if (conflict == false)
                    {
                        current.Add(i);
                        used[i] = true;

                        FindValidPerm(perm, current, n, used);
                        used[i] = false;
                        current.Remove(i);
                    }
                }
            }



        }

    }
}
