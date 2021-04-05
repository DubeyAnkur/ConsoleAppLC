using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    public class Container_With_Most_Water
    {
        public int MaxArea(int[] height)
        {
            int ret = 0;

            int a = 0;
            int b = height.Length - 1;

            while (a < b)
            {
                int temp = (b - a) * Math.Min(height[a], height[b]);
                ret = Math.Max(temp, ret);

                if (height[a] > height[b])
                    b--;
                else
                    a++;
            }

            return ret;
        }
    }
}
