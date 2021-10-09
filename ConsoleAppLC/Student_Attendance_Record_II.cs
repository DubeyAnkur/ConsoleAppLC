using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Student_Attendance_Record_II
    {
        public int CheckRecord(int n)
        {
            int mod = (int)(Math.Pow(10, 9) + 7);
            double P = 1; // Math.Pow(3, n);
            for (int i = 0; i < n; i++)
            {
                P = P * 3;
                P = P % mod;
            }
            double L = 0;
            if (n > 2)
            {
                L = n - 2;
                L = L * (L - 1) / 2;
                L = L % mod;
            }

            double A = 0;
            double[] perm = new double[n + 1];
            perm[0] = 1;

            for (int i = 1; i <= n; i++)
            {
                perm[i] = perm[i - 1] * i;
                perm[i] = perm[i] % mod;
            }

            for (int i = 2; i <= n; i++)
            {

                double up = 1;
                if (n - i > i)
                {
                    for (int j = n - i + 1; j <= n; j++)
                        up = (up * j) % mod;
                    up = up / perm[i];
                }
                else
                {
                    for (int j = i + 1; j <= n; j++)
                        up = (up * j) % mod;
                    up = up / perm[n-i];
                }

                double temp = up;
                A = A + temp;
                A = A % mod;
            }
            int ret = (int)((P - L - A) % mod);
            return ret;
        }
    }
}
