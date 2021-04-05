using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    public class String_to_Integer
    {
        public int MyAtoi(string s)
        {
            int ret = 0;
            int sign = 1;
            int i = 0;
            if (s.Length == 0)
                return 0;

            while (i < s.Length && s[i] == ' ')
                i++;

            if (i == s.Length)
                return 0;

            if (s[i] == '-' || s[i] == '+')
            {
                if (s[i] == '-')
                    sign = -1;
                i++;
            }

            for (int j = i; j < s.Length; j++)
            {
                try
                {
                    checked
                    {
                        int ch = (int)s[j];
                        if (ch >= 48 && ch <= 57)
                            ret = ret * 10 + (ch-48);
                        else
                            return ret * sign;
                    }
                }
                catch (Exception)
                {
                    if(sign > 0)
                        return int.MaxValue;
                    else
                        return int.MinValue;
                }
            }

            return ret * sign;
        }
    }
}
