using System;
using System.Collections.Generic;
using System.Text;
using static ConsoleAppLC.Remove_Nth_Node_From_End_of_List;

namespace ConsoleAppLC
{
    class Reverse_Nodes_in_k_Group
    {
        public ListNode ReverseKGroup(ListNode head, int k)
        {
            int current = 0;
            int length = 0;
            ListNode x = head;
            while (x != null)
            {
                x = x.next;
                length++;
            }
            x = head;
            ListNode ret = null;
            ListNode tempHead = null;
            while (current + k <= length)
            {
                ListNode y = x;
                ListNode z = x.next;

                int j = k-1;
                while (j > 0)
                {
                    y.next = z.next;
                    z.next = x;
                    x = z;
                    z = y.next;
                    if (tempHead != null)
                        tempHead.next = x;
                    j--;
                }
                if (ret == null)
                    ret = x;

                tempHead = y;

                x = y.next;

                current = current + k;
            }

            return ret;
        }
    }
}
