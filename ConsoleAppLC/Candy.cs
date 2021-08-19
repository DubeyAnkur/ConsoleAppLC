using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Candy1
    {
        public int Candy(int[] ratings)
        {
            int[] candy = new int[ratings.Length];
            if (ratings.Length == 1)
                return 1;
            int l = 0, r = 1;
            candy[0] = 1;

            while (r < ratings.Length)
            {
                if (ratings[r] > ratings[r - 1])
                {
                    candy[r] = candy[r - 1] + 1;
                    l = r;
                }
                else if (ratings[r] == ratings[r - 1])
                {
                    candy[r] = 1;
                    l = r;
                }
                r++;
                while (l < r && r < ratings.Length && ratings[r - 1] <= ratings[r])
                {
                    int temp = r - l;
                    if (temp > candy[l])
                        candy[l] = temp;
                    candy[++l] = --temp;
                }
            }
            while (l < r - 1)
            {
                int temp = r - l;
                if (temp > candy[l])
                    candy[l] = temp;
                candy[++l] = --temp;
            }
            int total = 0;
            for (int i = 0; i < candy.Length; i++)
            {
                total = total + candy[i];
            }
            return total;

        }
    }
}
