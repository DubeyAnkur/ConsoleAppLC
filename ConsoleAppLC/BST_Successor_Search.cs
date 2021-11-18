using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class BST_Successor_Search
    {
        public Node FindInOrderSuccessor(Node inputNode, int val)
        {
            var root = inputNode;
            Stack<Node> st = new Stack<Node>();

            while (root!= null && root.val != val)
            {
                st.Push(root);
                if (root.val > val)
                    root = root.right;
                else
                    root = root.left;
            }

            if (root == null)
                return null;

            Node parent = root;
            if (root.right != null)
                parent = root.right;
            else
            {
                while (st.Count > 0 && (parent.right == null || parent.right == root))
                {
                    root = parent;
                    parent = st.Pop();
                }
                if (parent.val > val)
                    return parent;
                else
                    return null;
            }

            while (parent != null)
            {
                if (parent.left != null)
                    parent = parent.left;
                else
                    return parent;
            }
            return null;
        }
    }
}
