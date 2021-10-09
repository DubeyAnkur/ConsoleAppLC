using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Find_Two_Non_overlapping_Sub_arrays_Each_With_Target_Sum
    {
        public int MinSumOfLengths1(int[] arr, int target)
        {
            int l = 0, r = 0;
            int current = 0;

            List<List<int>> mem = new List<List<int>>();

            while (r < arr.Length)
            {
                current = current + arr[r];
                while (current > target && l < r)
                {
                    current = current - arr[l];
                    l++;
                }

                if (current == target)
                {
                    int newVal = r - l + 1;

                    mem.Add(new List<int>() { newVal, l, r });
                    current = current - arr[l];
                    l++;
                    if (l - 1 == r)
                    {
                        if (l < arr.Length) current = current + arr[l];
                        r = l;
                    }
                    else
                    {
                        current = current - arr[r];
                        r = r - 1;
                    }
                }
                r++;
            }

            int min = int.MaxValue;
            mem.Sort(comparer);
            bool[] used = new bool[mem.Count];

            for (int i = 0; i < mem.Count - 1; i++)
            {
                if (used[i]) return min == int.MaxValue ? -1 : min;
                for (int j = i+1; j < mem.Count; j++)
                {
                    if (mem[i][1] <= mem[j][2] && mem[i][2] >= mem[j][1])
                        continue;
                    min = Math.Min(min, mem[i][0] + mem[j][0]);
                    used[j] = true;
                    break;
                }
            }
            return min == int.MaxValue ? -1 : min;
        }

        private int comparer(List<int> a, List<int> b)
        {
            return a[0] - b[0];
        }


        public int MinSumOfLengths(int[] arr, int target)
        {
            Hashtable ht = new Hashtable();
            ht.Add(0, -1);
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
                ht.Add(sum, i);
            }
            sum = 0;
            int minLeft = int.MaxValue;
            int Right = int.MaxValue;
            int result = int.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
                if (ht.Contains(sum - target))
                {
                    minLeft = Math.Min(minLeft, i - (int)ht[sum-target]);
                }

                if (ht.Contains(sum + target) && minLeft != int.MaxValue)
                {
                    Right = (int)ht[sum + target] - i;
                    result = Math.Min(result, minLeft + Right);
                }
            }
            return result == int.MaxValue ? -1 : result;
        }
    }
}
