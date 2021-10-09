using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Find_Duplicate_Subtrees
    {
        Hashtable ht;
        HashSet<string> hs;
        public IList<TreeNode> FindDuplicateSubtrees(TreeNode root)
        {
            var ret = new List<TreeNode>();

            if (root == null)
                return ret;

            ht = new Hashtable();
            hs = new HashSet<string>();

            Traverse(root, ret, "");
            return ret;
        }

        private string Traverse(TreeNode root, List<TreeNode> ret, string tree)
        {
            if (root == null)
                return " ,";

            string s = root.val.ToString() + "," + Traverse(root.left, ret, tree) + "," + Traverse(root.right, ret, tree);

            if (ht.Contains(s))
            {
                if (!hs.Contains(s))
                {
                    ret.Add(root);
                    hs.Add(s);
                }
            }
            else
                ht.Add(s, 1);

            return s;
        }
    }
}
