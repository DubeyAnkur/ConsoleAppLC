using System;
using System.Collections.Generic;
using System.Text;
using static ConsoleAppLC.Remove_Nth_Node_From_End_of_List;

namespace ConsoleAppLC
{
    class Swap_Nodes_in_Pairs
    {
        public ListNode SwapPairs(ListNode head)
        {
            ListNode x = head;
            ListNode y = null;
            if (x != null)
                y = x.next;
            while(x != null && y != null)
            {
                int temp = x.val;
                x.val = y.val;
                y.val = temp;

                x = y.next;
                if (x != null)
                    y = x.next;
            }

            return head;
        }
    }
}
