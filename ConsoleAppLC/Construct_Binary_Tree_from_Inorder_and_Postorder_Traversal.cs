using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Construct_Binary_Tree_from_Inorder_and_Postorder_Traversal
    {
        int j = 0;
        Hashtable ht = new Hashtable();
        public TreeNode BuildTree(int[] inorder, int[] postorder)
        {
            var N = postorder.Length;
            j = N-1;
            if (N == 0)
                return null;

            for (int i = 0; i < N; i++)
                ht.Add(inorder[i], i);

            return Traverse(inorder, postorder, 0, N - 1);
        }

        private TreeNode Traverse(int[] inorder, int[] postorder, int start, int end)
        {
            if (start > end)
                return null;

            if (j < 0)
                return null;

            int current = postorder[j--];
            int i = Convert.ToInt32(ht[current]);

            if (start == end)
                return new TreeNode(current, null, null);
            else
            {
                var x = new TreeNode(current, null, null);
                x.right = Traverse(inorder, postorder, i + 1, end);
                x.left = Traverse(inorder, postorder, start, i - 1);
                
                return x;
            }
        }

    }
}
