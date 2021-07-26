using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Sort_Colors
    {

        public void SortColors(int[] nums)
        {
            int r = 0, w = 0, b = 0;
            foreach (var num in nums)
            {
                if (num == 0) { nums[b++] = 2; nums[w++] = 1; nums[r++] = 0; }
                else if (num == 1) { nums[b++] = 2; nums[w++] = 1; }
                else b++;
            }

        }
        public void SortColors_1(int[] nums)
        {
            int red = 0, white = 0, blue = nums.Length - 1;
            while (white <= blue)
            {
                if (nums[white] == 0)
                {
                    var temp = nums[red];
                    nums[red] = nums[white];
                    nums[white] = temp;
                    red++;
                    white++;
                }
                else if (nums[white] == 1)
                    white++;
                else
                {
                    var temp = nums[blue];
                    nums[blue] = nums[white];
                    nums[white] = temp;
                    blue--;
                }
            }
        }

    }
}
