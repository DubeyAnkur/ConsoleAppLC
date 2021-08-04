using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Validate_Binary_Search_Tree
    {
        public bool IsValidBST(TreeNode root)
        {
            return IOT(root, int.MinValue, int.MaxValue, false, false);
        }

        private bool IOT(TreeNode root, int min, int max, bool maxxed, bool minned)
        {
            if (root == null)
                return true;

            if (root.val == int.MinValue && !minned && root.val >= min && root.val < max)
            {
                minned = true;
                return IOT(root.left, min, root.val, maxxed, minned) && IOT(root.right, root.val, max, maxxed, minned);
            }
            else if (root.val == int.MaxValue && !maxxed && root.val > min && root.val <= max)
            {
                maxxed = true;
                return IOT(root.left, min, root.val, maxxed, minned) && IOT(root.right, root.val, max, maxxed, minned);
            }
            else if (root.val > min && root.val < max)
                return IOT(root.left, min, root.val, maxxed, minned) && IOT(root.right, root.val, max, maxxed, minned);
            else
                return false;
        }
    }
}
