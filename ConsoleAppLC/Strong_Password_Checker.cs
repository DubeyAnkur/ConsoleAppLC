using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Strong_Password_Checker
    {
        public int StrongPasswordChecker(string password)
        {
            int N = password.Length;
            int lower = 0, upper = 0, digit = 0;
            int i = 0;
            int replace = 0;
            int oneDel = 0;
            int twoDel = 0;

            while(i < N)
            {
                int a = (int)password[i];
                if (a >= 97 && a <= 122)
                    lower = 1;

                if (a >= 65 && a <= 90)
                    upper = 1;

                if (a >= 48 && a <= 57)
                    digit = 1;

                int len = 2;
                while (i >= 2 && i <N && password[i] == password[i - 1] && password[i] == password[i - 2])
                {
                    len++; i++;
                }

                if (len > 2)
                {
                    replace = replace + len / 3;
                    if (len % 3 == 0) oneDel++;
                    if (len % 3 == 1) twoDel++;
                }
                else
                    i++;
            }

            if (N < 6)
            {
                int x = 3 - lower - upper - digit;
                int op = Math.Max(replace, x);
                return Math.Max(op, 6 - N);
            }
            else if (N < 20)
            {
                int x = 3 - lower - upper - digit;
                int op = Math.Max(replace, x);
                return op;
            }
            else
            {

                int del = N - 20;
                int x = 3 - lower - upper - digit;
                replace = Math.Max(replace , x);

                if (del - oneDel >= 0)
                {
                    replace = replace - oneDel;
                    del = del - oneDel;
                }
                else
                    return N - 20 + replace - del; 

                if (del - (twoDel * 2) >= 0)
                {
                    replace = replace - twoDel;
                    del = del - (twoDel * 2);
                }
                else
                    return N - 20 + Math.Max(replace - del / 2, x);

                if (del - replace * 3 >= 0)
                    return N - 20 + x;
                else
                    return N-20 + Math.Max(replace - del / 3, x);
            }
        }



        public int StrongPasswordChecker1(string password)
        {
            int N = password.Length;
            char[] s = password.ToCharArray();
            int[] lower = new int[N];
            int[] upper = new int[N];
            int[] digit = new int[N];
            int[] triple = new int[N];

            int a = (int)s[0];
            if (a >= 97 && a <= 122)
                lower[0] = 1;

            if (a >= 65 && a <= 90)
                upper[0] = 1;

            if (a >= 48 && a <= 57)
                digit[0] = 1;

            for (int i = 1; i < N; i++)
            {
                a = (int)s[i];
                if (a >= 97 && a <= 122)
                    lower[i] = lower[i - 1] + 1;
                else
                    lower[i] = lower[i - 1];

                if (a >= 65 && a <= 90)
                    upper[i] = upper[i - 1] + 1;
                else
                    upper[i] = upper[i - 1];

                if (a >= 48 && a <= 57)
                    digit[i] = digit[i - 1] + 1;
                else
                    digit[i] = digit[i - 1];

                if (i >= 2 && s[i] == s[i - 1] && s[i] == s[i - 2])
                {
                    s[i] = '$';
                    triple[i] = triple[i - 1] + 1;
                }
                else
                    triple[i] = triple[i - 1];
            }

            if (N <= 20)
            {
                int replace = triple[N - 1];
                int insert = 0;
                if (lower[N - 1] == 0)
                    insert = insert + 1;
                if (upper[N - 1] == 0)
                    insert = insert + 1;
                if (digit[N - 1] == 0)
                    insert = insert + 1;

                if (N < 6)
                {
                    insert = Math.Max(6 - N, insert);
                    int operation = Math.Max(replace, insert);
                    return operation;
                }
                else
                {
                    return Math.Max(replace, insert);
                }
            }
            else
            {
                int minStep = int.MaxValue;

                for (int i = 20; i < N; i++)
                {
                    int replace = triple[i] - triple[i - 20];
                    int insert = 0;
                    if (lower[i] - lower[i - 20] == 0)
                        insert = insert + 1;
                    if (upper[i] - upper[i - 20] == 0)
                        insert = insert + 1;
                    if (digit[i] - digit[i - 20] == 0)
                        insert = insert + 1;

                    minStep = Math.Min(minStep, Math.Max(insert, replace));
                }

                minStep = N - 20 + minStep;
                return minStep;
            }
        }
    }
}
