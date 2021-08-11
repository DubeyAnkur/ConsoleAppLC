using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    public class Node
    {
        public int val;
        public Node left;
        public Node right;
        public Node next;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, Node _left, Node _right, Node _next)
        {
            val = _val;
            left = _left;
            right = _right;
            next = _next;
        }
    }
    class Populating_Next_Right_Pointers_in_Each_Node_II
    {

        public Node Connect(Node root)
        {
            if (root == null)
                return null;

            var c = root;
            Node n = null;
            Node r = null;

            while (c != null)
            {
                while (c != null)
                {
                    while (c != null && c.left == null && c.right == null)
                        c = c.next;

                    if (c != null)
                    {
                        if (r == null)
                            r = c.left != null ? c.left : c.right;
                        else
                        {
                            r.next = c.left != null ? c.left : c.right;
                            r = r.next;
                        }
                        if (n == null)
                            n = r;

                        if (c.left == r && c.right != null)
                        {
                            r.next = c.right;
                            r = r.next;
                        }

                        c = c.next;
                    }
                }
                c = n;
                n = null;
                r = null;
            }
            return root;
        }


    }
}
