using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Binary_Tree_Level_Order_Traversal
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            var ret = new List<IList<int>>();

            if (root == null)
                return ret;

            List<TreeNode> read = new List<TreeNode>();
            List<TreeNode> write = new List<TreeNode>();
            read.Add(root);

            while (read.Count > 0)
            {
                var temp = new List<int>();
                foreach (var n in read)
                {
                    temp.Add(n.val);
                    if(n.left != null) write.Add(n.left);
                    if (n.right != null) write.Add(n.right);
                }
                read = write;
                write = new List<TreeNode>();
                ret.Add(temp);
            }
            return ret;
        }


    }
}
