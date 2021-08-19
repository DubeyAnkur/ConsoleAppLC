using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppLC
{
    class Max_Points_on_Line
    {
        public int MaxPoints(int[][] points)
        {
            if (points.Length == 1)
                return 1;
            Hashtable ht = new Hashtable();
            Dictionary<string, int> dic = new Dictionary<string, int>();
            int max = 0;

            for (int i = 0; i < points.Length - 1; i++)
            {
                dic = new Dictionary<string, int>();
                for (int j = i + 1; j < points.Length; j++)
                {
                    string s = "";

                    int y = points[i][1] - points[j][1];
                    int x = points[i][0] - points[j][0];

                    int gcd = 1;

                    if (x == 0)
                        s = y + "_0";
                    else if (y == 0)
                        s = "0_" + x;
                    else
                    {
                        if (x > y)
                            gcd = GCD(x, y);
                        else
                            gcd = GCD(y, x);

                        s = (y / gcd) + "_" + (x / gcd);
                    }

                    if (dic.ContainsKey(s))
                    {
                        dic[s]++;
                    }
                    else
                        dic.Add(s, 2);
                }
                foreach (var x in dic.Values)
                {
                    max = Math.Max(max, x);
                }
            }

            return max;
        }

        private int GCD(int a, int b)
        {
            if (a % b == 0 || b == 0)
                return b;
            else
                return GCD(b, a % b);
        }

        public int MaxPoints1(int[][] points)
        {
            if (points.Length == 1)
                return 1;
            Hashtable ht = new Hashtable();
            Dictionary<Tuple<decimal, decimal>, int> dic = new Dictionary<Tuple<decimal, decimal>, int>();

            for (int i = 0; i < points.Length - 1; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    decimal m = decimal.MaxValue;
                    decimal c = points[i][0];
                    if (points[i][0] != points[j][0])
                    {
                        m = ((decimal)(points[i][1] - points[j][1])) / (points[i][0] - points[j][0]);
                        c = points[i][1] - (m * points[i][0]);

                        m = Math.Round(m, 10);
                        c = Math.Round(c, 10);
                    }

                    if (dic.ContainsKey(new Tuple<decimal, decimal>(m, c)))
                    {
                        dic[new Tuple<decimal, decimal>(m, c)]++;
                    }
                    else
                        dic.Add(new Tuple<decimal, decimal>(m, c), 1);
                }
            }

            int max = 0;

            foreach (var i in dic.Values)
            {
                max = Math.Max(max, i);
            }
            max = Convert.ToInt32(Math.Pow(max * 2, 0.5)) + 1;
            return max;
        }
    }
}
