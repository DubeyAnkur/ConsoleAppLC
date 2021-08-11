using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Convert_Sorted_Array_to_Binary_Search_Tree
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {
            if (nums.Length == 0)
                return null;

            return Traverse(nums, 0, nums.Length - 1);
        }
        private TreeNode Traverse(int[] nums, int start, int end)
        {
            if (start > end)
                return null;

            int mid = (start + end) / 2;

            var x = new TreeNode(nums[mid], null, null);
            x.left = Traverse(nums, start, mid - 1);
            x.right = Traverse(nums, mid + 1, end);

            return x;
        }
    }
}
