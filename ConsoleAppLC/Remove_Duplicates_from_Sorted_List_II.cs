using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Remove_Duplicates_from_Sorted_List_II
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null || head.next == null)
                return head;

            ListNode F = null, L = null, P = head, C = head.next;

            if (P.val != C.val) F = L = P;

            while (C != null)
            {
                if (P.val != C.val && (C.next == null || C.val != C.next.val))
                {
                    if (F == null) F = C;
                    if (L == null)
                        L = C;
                    else
                    {
                        L.next = C;
                        L = L.next;
                    }
                }
                C = C.next;
                P = P.next;
            }
            if (L != null) L.next = null;

            return F;
        }
    }
}
