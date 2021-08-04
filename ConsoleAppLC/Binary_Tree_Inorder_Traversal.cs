using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    class Binary_Tree_Inorder_Traversal
    {
        public IList<int> InorderTraversal(TreeNode root)
        {
            var ret = new List<int>();
            IOT(root, ret);
            return ret;
        }

        private void IOT(TreeNode root, List<int> ret)
        {
            if (root == null) return;
            IOT(root.left, ret);
            ret.Add(root.val);
            IOT(root.right, ret);
        }

    }
}
