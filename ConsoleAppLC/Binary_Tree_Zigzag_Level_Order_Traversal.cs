using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Binary_Tree_Zigzag_Level_Order_Traversal
    {
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            var ret = new List<IList<int>>();
            if (root == null)
                return ret;

            Stack<TreeNode> read = new Stack<TreeNode>();
            Stack<TreeNode> write = new Stack<TreeNode>();
            bool direction = false;
            read.Push(root);

            while (read.Count > 0)
            {
                var lst = new List<int>();
                while (read.Count > 0)
                {
                    var temp = read.Pop();
                    lst.Add(temp.val);
                    if (direction)
                    {
                        if(temp.right != null) write.Push(temp.right);
                        if (temp.left != null) write.Push(temp.left);
                    }
                    else
                    {
                        if (temp.left != null) write.Push(temp.left);
                        if (temp.right != null) write.Push(temp.right);
                    }
                }
                direction = !direction;

                read = write;
                write = new Stack<TreeNode>();

                ret.Add(lst);
            }

            return ret;
        }
    }
}
