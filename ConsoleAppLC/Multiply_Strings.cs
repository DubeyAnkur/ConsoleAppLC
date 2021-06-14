using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Multiply_Strings
    {
        

        public string Multiply(string num1, string num2)
        {
            string ret = "";
            ListNode ln = new ListNode();
            ListNode current = ln;
            ListNode prev = ln;
            int[] temp = new int[num1.Length];

            for (int i = num1.Length -1; i >=0;  i--)
            {
                int step = 0;
                int q = 0;
                int tempNum = 0;
                current = prev;

                for (int j = num2.Length - 1; j >= 0; j--)
                {
                    int mul = ((int)num2[j] - 48) * ((int)num1[i] - 48) + current.val;
                    int rem = mul % 10;
                    q = mul / 10;

                    current.val = rem;
                    if (current.next != null)
                        current.next.val = current.next.val + q;
                    else
                        current.next = new ListNode(q, null);

                    current = current.next;

                    tempNum = tempNum + (rem * (int)Math.Pow(10, step));
                    step++;
                }
                temp[i] = tempNum + (q * (int)Math.Pow(10, step));

                prev = prev.next;
            }

            while (ln != null)
            {
                ret = ln.val.ToString() + ret;
                ln = ln.next;
            }

            ret = ret.TrimStart('0');

            if (ret == "")
                ret = "0";

            return ret;
        }
    }
}
