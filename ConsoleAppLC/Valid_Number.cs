using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Valid_Number
    {
        public bool IsNumber(string s)
        {
            int N = s.Length;
            int i = 0;
            if (s[i] == '+' || s[i] == '-')
                i++;
            bool dot = false;
            bool num = false;
            while (i < N)
            {
                if ((int)s[i] >= 48 && (int)s[i] <= 57)
                { i++; num = true; }
                else if (s[i] == '.')
                {
                    if (dot) return false;
                    else if(num) dot = true;
                    else if (i < N-1) dot = true;
                    else return false;
                    i++;
                }
                else
                    break;
            }

            if (i == N) return true;

            if (s[i] == 'e' || s[i] == 'E')
            {
                if (i == 0 || i == N - 1 || !num)
                    return false;
                else i++;

                if ((s[i] == '+' || s[i] == '-') && i < N - 1)
                    i++;
            }

            while (i < N)
            {
                if ((int)s[i] >= 48 && (int)s[i] <= 57)
                    i++;
                else
                    return false;
            }
            return true;

        }
    }
}
