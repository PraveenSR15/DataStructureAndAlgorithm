using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.MergeArray_Array_Tree
{
    public class MergeSortedArrays
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int len = m + n, j = 0, i;
            for (i = m; i < len; i++)
                nums1[i] = nums2[j++];
            for (i = 0; i < len - 1; i++)
            {
                for (j = 0; j < len - 1 - i; j++)
                {
                    if (nums1[j] > nums1[j + 1])
                    {
                        int temp = nums1[j];
                        nums1[j] = nums1[j + 1];
                        nums1[j + 1] = temp;
                    }
                }
            }
        }
    }
}
