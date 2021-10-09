using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Jumping_Numbers
    {
        long ret = 0;
        public long JumpingNumbers(long val)
        {
            if (val <= 10)
                return val;

            long temp = val;
            Stack<int> st = new Stack<int>();
            while (temp > 0)
            {
                long a = temp % 10;
                long b = temp / 10;

                st.Push((int)a);
                temp = b;
            }

            var lst = new List<int>();
            while (st.Count > 0)
            {
                lst.Add(st.Pop());
            }

            if (!BackTrack(lst, lst[0], lst[0], 1, lst[0]))
            {
                var prev = lst[0] - 1;
                if (prev == 0)
                    BackTrack(lst, 9, lst[0] * 10 + lst[1], 2, 9);
                else
                    BackTrack(lst, lst[0] - 1, lst[0], 1, lst[0] - 1);
            }
            return ret;
        }


        private bool BackTrack(List<int> lst, long path, long current, int ind, int r)
        {
            if (path > current || r == 10 || r == -1)
                return false;

            if (ind == lst.Count)
            {
                ret = path;
                return true;
            }

            bool tillNow = BackTrack(lst, path * 10 + r + 1, current * 10 + lst[ind], ind + 1, r + 1);
            if(!tillNow)
                return BackTrack(lst, path * 10 + r - 1, current * 10 + lst[ind], ind + 1, r - 1);

            return tillNow;

        }
    }
}
