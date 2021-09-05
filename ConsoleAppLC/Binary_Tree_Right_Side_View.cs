using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Binary_Tree_Right_Side_View
    {
        public IList<int> RightSideView(TreeNode root)
        {
            var ret = new List<int>();
            if (root == null)
                return ret;

            List<TreeNode> read = new List<TreeNode>();
            List<TreeNode> write = new List<TreeNode>();

            read.Add(root);

            while (read.Count > 0)
            {
                ret.Add(read[0].val);
                foreach (var n in read)
                {
                    if (n.right != null) write.Add(n.right);
                    if (n.left != null) write.Add(n.left);
                }

                read = write;
                write = new List<TreeNode>();
            }
            return ret;
        }
    }
}
