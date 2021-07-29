using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Gray_Code
    {
        public IList<int> GrayCode(int n)
        {
            int N = Convert.ToInt32(Math.Pow(2, n));
            int[] mem = new int[N];
            int i = 1, j = 0, k = 1;

            while (i < N)
            {
                while (j >= 0)
                {
                    mem[i++] = mem[j--] + k;
                }
                j = i - 1;
                k = k * 2;
            }

            return new List<int>(mem);
        }
    }
}
