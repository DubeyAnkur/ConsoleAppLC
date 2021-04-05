using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    class Remove_Nth_Node_From_End_of_List
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            int count = 0;

            ListNode x = head;

            while (x != null)
            {
                x = x.next;
                count++;
            }

            int Node_to_Remove = count - n;

            x = head;
            while (Node_to_Remove > 1)
            {
                x = x.next;
                Node_to_Remove--;
            }

            if (count - n != 0)
                x.next = x.next.next;
            else
                head = x.next;

            return head;
        }

        public ListNode ArrayToList(int[] input)
        {
            ListNode head = null;
            ListNode temp = null;
            foreach (var i in input)
            {
                var new_node = new ListNode(i, null);
                if (head == null)
                {
                    head = new_node;
                    temp = head;
                }
                else
                {
                    temp.next = new_node;
                    temp = new_node;
                }
            }

            return head;

        }

    }
}
