using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Longest_Valid_Parentheses
    {
        public int LongestValidParentheses(string s)
        {
            int max = 0;
            Stack<int> stk = new Stack<int>();
            int[] mem = new int[s.Length];

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    stk.Push(i);
                }
                else
                {
                    if (stk.Count > 0)
                    {
                        int top = stk.Pop();
                        mem[i] = i - top+1;
                        //max = Math.Max(i - top + 1, max);
                    }
                }
            }

            int j = s.Length - 1;
            int temp = 0;
            while (j >= 0)
            {
                if (mem[j] > 0)
                {
                    temp = temp + mem[j];
                    max = Math.Max(temp, max);
                    j = j - mem[j];
                }
                else
                { j--; temp = 0; }
            }

            return max;
        }

        public int maxLength(String S)
        {
            // code here
            Stack<int> st = new Stack<int>();
            int max = 0;

            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == '(' || st.Count == 0 || S[st.Peek()] == ')')
                    st.Push(i);
                else
                {
                    int j = st.Pop();
                    int k = st.Count == 0 ? -1 : st.Peek();
                    max = Math.Max(max, i - k);
                }
            }

            return max;

        }
    }
}
