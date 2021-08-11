using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Balanced_Binary_Tree
    {
        public bool IsBalanced(TreeNode root)
        {
            if (root == null)
                return true;
            else
            {
                var (r, h) = MaxHeight(root);
                return r;
            }
        }
        private (bool, int) MaxHeight(TreeNode root)
        {
            if (root == null)
                return (true, 0);
            else
            {
                var (l, left) = MaxHeight(root.left);
                var (r, right) = MaxHeight(root.right);

                if (!l || !r || Math.Abs(left - right) > 1)
                    return (false, 0);
                else
                    return (true, Math.Max(left, right)+1);
            }
        }
    }
}
