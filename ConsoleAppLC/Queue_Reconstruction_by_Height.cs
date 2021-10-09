using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Queue_Reconstruction_by_Height
    {
        public int[][] ReconstructQueue(int[][] people)
        {
            Array.Sort(people, comparer);

            List<List<int>> ret = new List<List<int>>();

            for (int i = 0; i < people.Length; i++)
            {
                int j = 0;
                int count = 0;
                while (j < ret.Count && (count < people[i][1] || people[i][0] > ret[j][0]))
                {
                    if (ret[j][0] >= people[i][0])
                        count++;
                    j++;
                }
                if (j < ret.Count)
                    ret.Insert(j, new List<int>() { people[i][0], people[i][1] });
                else
                    ret.Add(new List<int>() { people[i][0], people[i][1] });
            }

            int[][] rArr = new int[people.Length][];
            for (int i = 0; i < ret.Count; i++)
            {
                rArr[i] = new int[2] { ret[i][0], ret[i][1] };
            }
            return rArr;
        }

        private int comparer(int[] a, int[] b)
        {
            if (a[1] == b[1])
                return a[0] - b[0];
            else
                return a[1] - b[1];
        }
    }
}
