using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Count_of_Smaller_Numbers_After_Self
    {
        public IList<int> CountSmaller(int[] nums)
        {
            int[][] deal = new int[nums.Length][];
            int[] ret = new int[nums.Length];
            for(int i = 0; i<nums.Length; i++)
            {
                deal[i] = new int[] { nums[i], i};
            }
            Mergesort(deal, ret, 0, nums.Length-1);
            return ret;
        }
        private void Mergesort(int[][] deal, int[] ret, int start, int end)
        {
            if (start == end)
                return;

            int mid = (start + end) / 2;

            Mergesort(deal, ret, start, mid);
            Mergesort(deal, ret, mid + 1, end);

            int[,] temp = new int[end-start+1,2];
            int i = start, j = mid + 1;
            int k = 0;
            int increment = 0;
            while (i <= mid && j<=end)
            {
                if (deal[i][0] > deal[j][0])
                {
                    increment++;
                    //ret[deal[i][1]] += increment;
                    temp[k,0] = deal[j][0];
                    temp[k,1] = deal[j][1];
                    j++;
                }
                else //if (deal[i][0] <= deal[j][0])
                {
                    temp[k,0] = deal[i][0];
                    temp[k,1] = deal[i][1];
                    ret[deal[i][1]] += increment;
                    i++;
                }
                k++;
            }

            while (i <= mid)
            {
                temp[k, 0] = deal[i][0];
                temp[k, 1] = deal[i][1];
                ret[deal[i][1]] += increment;
                i++; k++;
            }
            while (j <= end)
            {
                temp[k,0] = deal[j][0];
                temp[k,1] = deal[j][1];
                j++; k++;
            }

            for (k = 0; k < end - start + 1; k++)
            {
                deal[start + k][0] = temp[k,0];
                deal[start + k][1] = temp[k,1];
            }
        }

    }
}
