using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Connect_Nodes_at_Same_Level
    {
        public class Node
        {
            public int data;
            public Node left;
            public Node right;
            public Node nextRight;

            public Node(int key)
            {
                this.data = key;
                this.left = null;
                this.right = null;
                this.nextRight = null;
            }
        }
        public void connect(Node root)
        {
            //code here
            if (root == null)
                return;

            List<Node> read = new List<Node>();
            List<Node> write = new List<Node>();

            read.Add(root);

            while (read.Count > 0)
            {
                int i = 0;
                while (i < read.Count)
                {
                    Node cur = read[i];
                    if (cur.left != null)
                    {
                        write.Add(cur.left);
                        cur.left.nextRight = GetNext(cur, 1);
                    }
                    if (cur.right != null)
                    {
                        write.Add(cur.right);
                        cur.right.nextRight = GetNext(cur, 2);
                    }
                    i++;
                }
                read = write;
                write = new List<Node>();
            }
        }
        private Node GetNext(Node parent, int child)
        {
            if (child == 1 && parent.right != null)
                return parent.right;

            parent = parent.nextRight;
            while (parent != null && parent.left == null && parent.right == null)
                parent = parent.nextRight;

            if (parent == null)
                return null;
            else if (parent.left != null)
                return parent.left;
            else
                return parent.right;
        }
    }
}
