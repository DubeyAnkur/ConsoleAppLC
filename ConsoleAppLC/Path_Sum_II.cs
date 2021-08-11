using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Path_Sum_II
    {
        public IList<IList<int>> PathSum(TreeNode root, int targetSum)
        {
            var ret = new List<IList<int>>();
            Traverse(root, targetSum, 0, new List<int>(), ret);
            return ret;
        }

        private void Traverse(TreeNode root, int targetSum, int current, List<int> path, List<IList<int>> ret)
        {
            if (root == null)
                return;

            path.Add(root.val);

            if (root.left == null && root.right == null && targetSum == current + root.val)
                ret.Add(new List<int>(path));

            Traverse(root.left, targetSum, current + root.val, path, ret);
            Traverse(root.right, targetSum, current + root.val, path, ret);
            path.RemoveAt(path.Count - 1);
        }
    }
}
