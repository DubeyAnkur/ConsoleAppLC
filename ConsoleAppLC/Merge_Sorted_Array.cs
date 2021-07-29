using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Merge_Sorted_Array
    {
        public void Merge1(int[] nums1, int m, int[] nums2, int n)
        {
            int[] ret = new int[m + n];
            int i = 0, j = 0, k = 0;
            if (n == 0)
                return;
            while (i < m || j < n)
            {
                if (i < m && (j == n || nums1[i] < nums2[j]))
                    ret[k++] = nums1[i++];
                else
                    ret[k++] = nums2[j++];
            }
            for (i = 0; i < m + n; i++)
                nums1[i] = ret[i];
        }

        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int i = m-1, j = n-1, k = m+n-1;

            while (j >= 0)
            {
                if (i < 0 || nums1[i] <= nums2[j])
                    nums1[k--] = nums2[j--];
                else
                    nums1[k--] = nums1[i--];
            }
        }

    }
}
