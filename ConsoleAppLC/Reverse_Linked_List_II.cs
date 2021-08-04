using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Reverse_Linked_List_II
    {
        public ListNode ReverseBetween(ListNode head, int left, int right)
        {
            if (left == right)
                return head;

            ListNode fake = new ListNode(0, head);
            ListNode p1, p2, p3;
            p1 = p2 = p3 = fake;

            while (left > 1)
            {
                p3 = p3.next;
                left--;
                right--;
            }
            p2 = p3.next;
            p1 = p2.next;
            right--;

            while (right > 0)
            {
                p2.next = p1.next;
                p1.next = p3.next;
                p3.next = p1;

                p1 = p2.next;
                right--;
            }

            return fake.next;
        }
    }
}
