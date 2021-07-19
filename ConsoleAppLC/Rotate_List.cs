using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{

    class Rotate_List
    {
        public ListNode RotateRight(ListNode head, int k)
        {
            ListNode newHead;
            ListNode current = head;
            ListNode kNode = null;
            ListNode end;
            int count = 1;

            if (head == null) return head;
            if (k == 0) return head;

            while (current.next != null)
            {
                count++;
                current = current.next;
            }

            k = k % count;
            if (k == 0) return head;

            k = count - k-1;
            end = current;
            current = head;
            
            while (k>0)
            {
                k--;
                current = current.next;
            }

            newHead = current.next;
            end.next = head;
            current.next = null;

            return newHead;
        }
    }
}
