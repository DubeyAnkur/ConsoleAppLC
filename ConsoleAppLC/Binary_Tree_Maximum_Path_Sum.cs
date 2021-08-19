using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Binary_Tree_Maximum_Path_Sum
    {
        int maxValue = int.MinValue;
        public int MaxPathSum(TreeNode root)
        {
            if (root == null)
                return 0;
            traverse(root);

            return maxValue;
        }

        private int traverse(TreeNode root)
        {
            if (root == null)
                return int.MinValue;

            int left = traverse(root.left);
            int right = traverse(root.right);

            maxValue = Math.Max(maxValue, root.val);
            if (left < 0 && right < 0)
            {
                maxValue = Math.Max(maxValue, root.val);
                return root.val;
            }
            else if (left < 0)
            {
                maxValue = Math.Max(maxValue, right);
                maxValue = Math.Max(maxValue, right + root.val);
                return root.val + right;
            }
            else if (right <0)
            {
                maxValue = Math.Max(maxValue, left);
                maxValue = Math.Max(maxValue, left + root.val);
                return root.val + left;
            }
            else
            {
                maxValue = Math.Max(maxValue, left);
                maxValue = Math.Max(maxValue, right);

                int temp = root.val + left + right;
                maxValue = Math.Max(maxValue, temp);
                return root.val + Math.Max(left, right);
            }
        }

    }
}
