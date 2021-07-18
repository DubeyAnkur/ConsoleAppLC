using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class N_Queens
    {

        public IList<IList<string>> SolveNQueens(int n)
        {
            var ret = new List<IList<string>>();

            var perm = new List<List<int>>();
            bool[] used = new bool[n];
            FindValidPerm(perm, new List<int>(), n, used);

            var rows = new string[n];

            for (int i = 0; i < n; i++)
            {
                string s = "";
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                        s = s + 'Q';
                    else
                        s = s + '.';
                }
                rows[i] = s;
            }

            foreach (var a in perm)
            {
                var temp = new List<string>();
                foreach (var b in a)
                {
                    temp.Add(rows[b]);
                }
                ret.Add(temp);
            }

            return ret;
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
                        int k = current[current.Count - j-1];
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


        //Not the right solution. Can be improved but came up with better approach
        public IList<IList<string>> SolveNQueens_Bad(int n)
        {
            var ret = new List<IList<string>>();

            char[,] memory = new char[n, n];

            int count = 0;
            for (int j = 0; j < n; j++)
            {
                memory = new char[n, n];
                if (backtrack(memory, 0, j, 0, j, 0, n))
                {
                    count++;
                    var success = new List<string>();
                    for (int i = 0; i < n; i++)
                    {
                        string s = "";
                        for (int k = 0; k < n; k++)
                        {
                            if (memory[i, k] == 'Q')
                                s = s + 'Q';
                            else
                                s = s + ".";
                        }
                        success.Add(s);
                    }
                    ret.Add(success);
                }
            }
            return ret;
        }

        private bool backtrack(char[,] memory, int i, int j, int lastI, int lastJ, int QCount, int n)
        {
            if (QCount == n)
                return true;
            if (j == n)
                return false;
            if (check(memory, i, j, n))
            {
                memory[i, j] = 'Q';
                lastI = i;
                lastJ = j;
                if (backtrack(memory, i + 1, 0, lastI, lastJ, QCount + 1, n))
                    return true;
                else
                {
                    if (i == 0)
                        return false;
                    memory[i, j] = ' ';
                    return backtrack(memory, i, j + 1, lastI, lastJ, QCount, n);
                }
            }
            else
            {
                return backtrack(memory, i, j + 1, lastI, lastJ, QCount, n);
            }
        }

        private bool check(char[,] memory, int i, int j, int n)
        {
            for (int a = 0; a < n; a++)
            {
                if (memory[i, a] == 'Q' && a != j)
                    return false;
            }
            for (int b = 0; b < i; b++)
            {
                if (memory[b, j] == 'Q')
                    return false;
                if (j - b - 1 >= 0 && memory[i - b - 1, j - b - 1] == 'Q')
                    return false;
                if (j + b + 1 < n && memory[i - b - 1, j + b + 1] == 'Q')
                    return false;
            }

            return true;
        }
    }
}
