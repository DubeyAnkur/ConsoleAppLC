using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Binary_Tree_Postorder_Traversal
    {
        public IList<int> PostorderTraversal(TreeNode root)
        {
            Stack<TreeNode> st = new Stack<TreeNode>();
            var ret = new List<int>();
            st.Push(root);
            TreeNode cur;
            var last = root;

            while (st.Count > 0)
            {
                root = st.Peek();
                while (st.Peek().left != null || st.Peek().right != null)
                {
                    if (root.right == null && root.left == last)
                        break;

                    if (root.right != null && root.right == last)
                        break;

                    cur = st.Peek();
                    if (cur.right != null) st.Push(cur.right);
                    if (cur.left != null) st.Push(cur.left);
                }

                last = st.Pop();
                ret.Add(last.val);
            }

            return ret;
        }
    }
}
