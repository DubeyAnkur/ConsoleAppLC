using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Insert_Interval
    {
        public int[][] Insert(int[][] intervals, int[] newInterval)
        {
            var left = new List<Tuple<int, int>>();
            var right = new List<Tuple<int, int>>();
            int start = newInterval[0];
            int end = newInterval[1];

            for(int i=0; i < intervals.Length; i++)
            {
                if (intervals[i][1] < start)
                {
                    left.Add(new Tuple<int, int>(intervals[i][0], intervals[i][1]));
                }
                else if (intervals[i][0] > end)
                {
                    right.Add(new Tuple<int, int>(intervals[i][0], intervals[i][1]));
                }
                else 
                {
                    start = Math.Min(start, intervals[i][0]);
                    end = Math.Max(end, intervals[i][1]);
                }
            }

            int[][] ret = new int[left.Count+right.Count+1][];

            int count = 0;
            foreach(var x in left)
            {
                ret[count] = new int[] { x.Item1, x.Item2};
                count++;
            }
            ret[count] = new int[] { start, end };
            count++;
            foreach (var x in right)
            {
                ret[count] = new int[] { x.Item1, x.Item2 };
                count++;
            }

            return ret;
        }
    }
}
