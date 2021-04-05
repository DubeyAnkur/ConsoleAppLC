using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using static ConsoleAppLC.Remove_Nth_Node_From_End_of_List;

namespace ConsoleAppLC
{
    class Merge_k_Sorted_Lists
    {
        public ListNode MergeKLists(ListNode[] lists)
        {
            List<ListNode> mem = new List<ListNode>();

            mem.AddRange(lists.ToList());

            while (mem.Count > 1)
            {
                var a = mem.First();
                mem.RemoveAt(0);
                var b = mem.First();
                mem.RemoveAt(0);
                mem.Add(Merge(a, b));
            }

            return mem.FirstOrDefault();
        }

        private ListNode Merge(ListNode a, ListNode b)
        {
            ListNode head = new ListNode();
            ListNode run = head;
            while (a != null && b != null)
            {
                if (a.val < b.val)
                {
                    run.next = a;
                    a = a.next;
                }
                else
                {
                    run.next = b;
                    b = b.next;
                }
                
                run = run.next;
            }

            run.next = a == null ? b : a;
            
            return head.next;
        }
    }
}
