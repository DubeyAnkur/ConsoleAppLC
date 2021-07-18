using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Pow
    {
        public double MyPow(double x, int n)
        {
            if (n == 0)
                return 1;
            else if (n < 0)
            {
                if (n == int.MinValue)
                {
                    x = x * x;
                    n = (n / 2) + 1;
                }
                x = 1 / x;
                n *= -1;
            }

            return n % 2 == 0 ? MyPow(x * x, n / 2) : x * MyPow(x * x, n / 2);
        }
    }
}
