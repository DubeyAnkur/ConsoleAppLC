using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Construct_Binary_Tree_from_Preorder_and_Inorder_Traversal
    {
        int j = 0;
        Hashtable ht = new Hashtable();
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            if (inorder.Length == 0)
                return null;
            for (int i = 0; i < inorder.Length; i++)
            {
                ht.Add(inorder[i], i);
            }
            return Traverse(preorder, inorder, 0, inorder.Length-1);
        }

        private TreeNode Traverse(int[] preorder, int[] inorder, int start, int end)
        {
            if (start > end)
                return null;

            else if (start == end)
            {
                int i = Convert.ToInt32(ht[preorder[j++]]);
                return new TreeNode(inorder[i], null, null);
            }
            else
            {
                int i = Convert.ToInt32(ht[preorder[j]]);
                var x = new TreeNode(preorder[j++], null, null);
                x.left = Traverse(preorder, inorder, start, i - 1);
                x.right = Traverse(preorder, inorder, i + 1, end);
                return x;
            }
        }



    }
}
