using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Max_Value_of_Equation
    {
        public int FindMaxValueOfEquation(int[][] points, int k)
        {
            int max = int.MinValue;

            List<int> que = new List<int>();
            int index = 0;

            for (int l = 0; l < points.Length; l++)
            {
                int xj = points[l][0];
                int yj = points[l][1];

                //xi = points[index]
                while (index < que.Count && points[que[index]][0] + k < xj)
                    index++;

                if (index < que.Count)
                {
                    int xi = points[que[index]][0];
                    int yi = points[que[index]][1];
                    int temp = yi + yj + xj - xi; // given xj > xi
                    max = Math.Max(max, temp);
                }

                while (index < que.Count)
                {
                    int xi = points[que[que.Count - 1]][0];
                    int yi = points[que[que.Count - 1]][1];

                    if (yi - xi < yj - xj)
                        que.RemoveAt(que.Count - 1);
                    else
                        break;
                }
                que.Add(l);
            }

            return max;
        }
    }
}
