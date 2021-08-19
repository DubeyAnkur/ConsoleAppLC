using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Valid_Palindrome
    {
        public bool IsPalindrome(string s)
        {
            int i = 0;
            int j = s.Length - 1;

            while (j > i)
            {
                int atI = (int)Char.ToLower(s[i]);
                int atJ = (int)Char.ToLower(s[j]);

                while (!((atI >= 97 && atI <= 122) || (atI >= 48 && atI <= 57)) && i < s.Length-1)
                {
                    i++;
                    atI = (int)Char.ToLower(s[i]);
                }

                while (!((atJ >= 97 && atJ <= 122) || (atJ >= 48 && atJ <= 57)) && j> 0)
                {
                    j--;
                    atJ = (int)Char.ToLower(s[j]);
                }
                if (j > i && atI != atJ)
                    return false;

                i++; j--;
            }

            return true;

        }



    }
}
