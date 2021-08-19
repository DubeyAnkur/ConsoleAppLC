using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Sort_List
    {
        public ListNode SortList(ListNode head)
        {
            if (head == null || head.next == null)
                return head;

            ListNode slow = head;
            ListNode fast = head.next;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            var right = slow.next;
            slow.next = null;

            var left = SortList(head);
            right = SortList(right);

            ListNode fakeStart = new ListNode(int.MaxValue);
            ListNode fake = fakeStart;

            while (left != null && right != null)
            {
                if (left.val < right.val)
                {
                    fake.next = left;
                    left = left.next;
                }
                else
                {
                    fake.next = right;
                    right = right.next;
                }
                fake = fake.next;
            }

            if (left != null)
                fake.next = left;
            else
                fake.next = right;

            return fakeStart.next;
        }
    }
}
