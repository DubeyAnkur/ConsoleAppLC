using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Triangle
    {

        public int MinimumTotal(IList<IList<int>> triangle)
        {
            int MinSum = int.MaxValue;
            if (triangle.Count == 1)
                return triangle[0][0];

            for (int i = 1; i < triangle.Count; i++)
            {
                for (int j = 0; j < triangle[i].Count; j++)
                {
                    if (j == 0)
                        triangle[i][j] = triangle[i][j] + triangle[i - 1][j];
                    else if (j == triangle[i - 1].Count)
                        triangle[i][j] = triangle[i][j] + triangle[i - 1][j - 1];
                    else
                        triangle[i][j] = triangle[i][j] + Math.Min(triangle[i - 1][j], triangle[i - 1][j - 1]);

                    if (i == triangle.Count - 1)
                        MinSum = Math.Min(triangle[i][j], MinSum);

                    Console.Write(triangle[i][j] + ",");
                }

                Console.WriteLine();
            }
            return MinSum;
        }


        public int MinimumTotal1(IList<IList<int>> triangle)
        {
            int runSum = 0;
            for (int i = 0; i < triangle.Count; i++)
            {
                runSum = runSum + triangle[i][0];
            }

            int MinSum = runSum;
            for (int j = 1; j < triangle[triangle.Count - 1].Count; j++)
                for (int i = triangle.Count - 1; i >= j; i--)
                {
                    runSum = runSum - triangle[i][j - 1] + triangle[i][j];
                    MinSum = Math.Min(runSum, MinSum);
                }

            return MinSum;
        }
    }
}
