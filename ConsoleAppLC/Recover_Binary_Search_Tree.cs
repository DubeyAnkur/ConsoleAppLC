using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Recover_Binary_Search_Tree
    {
        TreeNode first = null;
        TreeNode last = null;
        TreeNode lastNode;
        public void RecoverTree(TreeNode root)
        {

            lastNode = new TreeNode(int.MinValue, null, null);
            IOT(root);

            int temp = first.val;
            first.val = last.val;
            last.val = temp;
        }

        private void IOT(TreeNode root)
        {
            if (root == null) return;

            IOT(root.left);

            if (root.val < lastNode.val && first == null)
                first = lastNode;
            if (root.val < lastNode.val && first !=null)
                last = root;
            lastNode = root;

            IOT(root.right);
        }
    }
}
