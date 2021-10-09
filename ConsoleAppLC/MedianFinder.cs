using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppLC
{
    class MedianFinder
    {
        List<int> small;
        List<int> large;
        
        /** initialize your data structure here. */
        public MedianFinder()
        {
            small = new List<int>();
            large = new List<int>();
        }

        public void AddNum(int num)
        {
            if (small.Count == large.Count)
            {
                large.Add(num);
                large.Sort();
                small.Add(large[0]);
                small.Sort();
                large.RemoveAt(0);
            }
            else
            {
                small.Add(num);
                small.Sort();
                large.Add(small[small.Count-1]);
                large.Sort();
                small.RemoveAt(small.Count - 1);
            }
        }

        public double FindMedian()
        {
            if ((small.Count + large.Count) % 2 == 0)
            {
                double ret = small[small.Count-1] + large[0];
                return ret / 2;
            }
            else
                return small[small.Count-1];
        }
    }
}
