using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class RangeModule
    {
        List<List<int>> lst;

        public RangeModule()
        {
            lst = new List<List<int>>();
        }

        public void AddRange(int left, int right)
        {
            if (lst.Count == 0 || lst[lst.Count - 1][1] < left)
            {
                lst.Add(new List<int> { left, right });
            }
            else if (lst[lst.Count - 1][0] >= left && lst[lst.Count - 1][1] <= left)
            {
                lst[lst.Count - 1][1] = Math.Max(lst[lst.Count - 1][1], right);
            }
            else
            {
                int i = Find(left);
                int start = 0;

                if (i == 0)
                    start = left;
                else
                    start = Math.Min(left, lst[i][0]);

                int j = i > 0 ? i - 1 : 0;
                while (j < lst.Count && lst[j][1] < right)
                {
                    lst.RemoveAt(j);
                }

                if (lst.Count > 0)
                {
                    if (right < lst[j][0])
                        lst.Insert(j, new List<int>() { start, right });
                    else
                        lst[j] = new List<int>() { start, Math.Max(right, lst[j][1]) };
                }
                else
                {
                    lst.Add(new List<int>() { left, right });
                }
            }
        }

        public bool QueryRange(int left, int right)
        {
            if (lst[lst.Count - 1][0] <= left)
            {
                if (lst[lst.Count - 1][1] >= right)
                    return true;
                else
                    return false;
            }

            int i = Find(left);
            if (i == 0 || lst[i - 1][1] < right)
                return false;
            else
                return true;
        }

        public void RemoveRange(int left, int right)
        {
            if (right < lst[0][0])
                return;

            int i = Find(left);

            if (i == 0 && lst[i][0] > left )
            {
                if (lst[i][0] < right)
                {
                    lst[i][0] = right;
                    return;
                }
            }

            if (lst[i][0] < left && lst[i][1] > right)
            {
                lst[i][1] = left;
                lst.Insert(i, new List<int>() { right, lst[i][1]});
                return;
            }

            if (i != 0 && lst[i - 1][0] != left)
                lst[i - 1][1] = Math.Min(lst[i - 1][1], left);

            int j = i > 0 ? i - 1 : 0;
            while (j < lst.Count && lst[j][1] < right)
            {
                lst.RemoveAt(j);
            }

            if (lst.Count > 0)
                lst[j][0] = right;

        }

        private int Find(int s)
        {
            int i = 0, j = lst.Count - 1;

            while (i < j)
            {
                int mid = (i + j) / 2;

                if (lst[i][0] >= s)
                    i = mid + 1;
                else
                    j = mid;

            }
            return i;
        }
    }
}
