using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Palindrome_Number
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;
            int temp = x;
            int ret = 0;
            while (temp > 0)
            {
                try
                {
                    checked
                    {
                        ret = ret * 10 + temp % 10;
                        temp = temp / 10;
                    }
                }
                catch (Exception)
                {
                    return false;
                }
            }
            if (ret == x)
                return true;
            else
                return false;
        }
    }
}
