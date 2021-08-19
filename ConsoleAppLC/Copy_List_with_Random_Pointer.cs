using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Copy_List_with_Random_Pointer
    {
        public class Node
        {
            public int val;
            public Node next;
            public Node random;

            public Node(int _val)
            {
                val = _val;
                next = null;
                random = null;
            }
        }

        public Node CopyRandomList(Node head)
        {
            if (head == null)
                return null;

            Node old = head;
            
            while (old != null)
            {
                Node newN = new Node(old.val);
                newN.next = old.next;
                old.next = newN;
                old = newN.next;
            }

            old = head;
            while (old != null)
            {
                old.next.random = old.random !=null ? old.random.next : null;
                old = old.next.next;
            }

            Node newHead = head.next;
            old = head;
            while (old != null)
            {
                Node newN = old.next;
                old.next = old.next.next;
                newN.next = newN.next != null ? newN.next.next : null;
                old = old.next;
            }
            return newHead;
        }

    }
}
