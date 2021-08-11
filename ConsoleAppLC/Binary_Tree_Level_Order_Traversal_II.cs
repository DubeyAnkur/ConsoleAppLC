using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Binary_Tree_Level_Order_Traversal_II
    {

        List<IList<int>> ret = new List<IList<int>>();
        public IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            Traverse(root, 0);
            ret.Reverse();
            return ret;
        }

        private void Traverse(TreeNode root, int level)
        {
            if (root == null)
                return;
            if (ret.Count == level)
                ret.Add(new List<int>());

            Traverse(root.left, level + 1);
            ret[level].Add(root.val);
            Traverse(root.right, level + 1);
        }
    }
}
