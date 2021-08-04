using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Unique_Binary_Search_Trees_II
    {
        public IList<TreeNode> GenerateTrees(int n)
        {
            var ret = CreateTrees(1, n);
            return ret;
        }

        private IList<TreeNode> CreateTrees(int start, int end)
        {
            var ret = new List<TreeNode>();

            if (start > end)
            {
                ret.Add(new TreeNode(0, null, null));
                return ret;
            }
            if (start == end)
            {
                ret.Add(new TreeNode(start, null, null));
                return ret;
            }

            for (int i = start; i <= end; i++)
            {
                var leftList = CreateTrees(start, i - 1);
                var rightList = CreateTrees(i+1, end);

                foreach (var nodeL in leftList)
                    foreach (var nodeR in rightList)
                    {
                        var root = new TreeNode(i, null, null);
                        root.left = nodeL.val == 0 ? null : nodeL;
                        root.right = nodeR.val == 0 ? null : nodeR;

                        ret.Add(root);
                    }
            }
            return ret;
        }
    }
}
