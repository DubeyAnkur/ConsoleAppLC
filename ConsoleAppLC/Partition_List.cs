using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Partition_List
    {
        public ListNode Partition(ListNode head, int x)
        {
            var Left = new ListNode(0, null);
            var Right = new ListNode(0, null);

            ListNode lLast=Left, rLast =Right;

            var current = head;

            while (current != null)
            {
                if (current.val < x)
                {
                    lLast.next = current;
                    lLast = lLast.next;
                }
                else
                {
                    rLast.next = current;
                    rLast = rLast.next;
                }
                current = current.next;
            }

            lLast.next = Right.next;
            rLast.next = null;
            return Left.next;
        }
    }
}
