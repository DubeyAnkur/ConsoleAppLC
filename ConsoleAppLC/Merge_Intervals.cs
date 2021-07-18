using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Merge_Intervals
    {
        public int[][] Merge(int[][] intervals)
        {
           
            Array.Sort(intervals, new Comparison<int[]>((x,y) => { return x[0] <y[0] ? -1: (x[0] > y[0] ? 1:0); }));

            List<Tuple<int, int>> temp = new List<Tuple<int, int>>();

            int start = intervals[0][0];
            int end = intervals[0][1];
            for (int i = 1; i < intervals.Length; i++)
            {
                if (start <= intervals[i][0] && intervals[i][0] <= end)
                    end = Math.Max(end, intervals[i][1]);
                else
                {
                    temp.Add(new Tuple<int, int>(start, end));
                    start = intervals[i][0];
                    end = intervals[i][1];
                }
            }
            temp.Add(new Tuple<int, int>(start, end));

            var ret = new int[temp.Count][];

            for (int i = 0; i < temp.Count; i++)
            {
                ret[i] = new int[2] { temp[i].Item1, temp[i].Item2};
            }

            return ret;
        }
    }
}
