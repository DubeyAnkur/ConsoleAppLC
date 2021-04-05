using System;
using System.Collections.Generic;
using System.Text;
using static ConsoleAppLC.Remove_Nth_Node_From_End_of_List;

namespace ConsoleAppLC
{
    public class Add_Two_Numbers
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode ret = null;
            ListNode prev = null;
            ListNode l1_temp = l1;
            ListNode l2_temp = l2;
            int q = 0;
            while (l1_temp != null || l2_temp != null)
            {
                int a = 0;
                int b = 0;

                if (l1_temp != null)
                {
                    a = l1_temp.val;
                    l1_temp = l1_temp.next;
                }
                if (l2_temp != null)
                {
                    b = l2_temp.val;
                    l2_temp = l2_temp.next;
                }

                int c = a + b + q;

                q = c / 10;
                int r = c % 10;
                var temp = new ListNode(r, null);
                if (prev != null)
                {
                    prev.next = temp;
                    prev = prev.next;
                }
                else
                {
                    prev = temp;
                    ret = prev;
                }
            }
            if (q > 0)
            {
                prev.next = new ListNode(q, null);
            }

            return ret;
        }


        public ListNode ArrayToList(int[] A)
        {
            ListNode ret = null;
            ListNode prev = ret;
            foreach (int a in A)
            {
                var temp = new ListNode(a, null);
                if (prev == null)
                {
                    prev = temp;
                    ret = prev;
                }
                else
                {
                    prev.next = temp;
                    prev = prev.next;
                }
            }
            return ret;
        }
    }
}
