using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Median_Array
{
    public class Median
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] mer = (nums1.Concat(nums2)).ToArray();
            Array.Sort(mer);
            
            if(mer.Length %2 == 0)
            {
                var mid = mer.Length / 2;
                return double.Parse(Decimal.Divide(mer[mid] + mer[mid - 1], 2).ToString());
            }
            else
            {
                return mer.Length / 2;
            }
        }

        public double FindMedianSortedArraysOptimal(int[] nums1, int[] nums2)
        {

            if (nums1.Length > nums2.Length)
            {
                return FindMedianSortedArraysOptimal(nums2, nums1);
            }

            int x = nums1.Length;
            int y = nums2.Length;

            int start = 0;
            int end = x;

            while (start <= end)
            {
                int partitionX = (start + end) / 2;
                int partitionY = (x + y + 1) / 2 - partitionX;

                int maxLeftX = (partitionX == 0) ? Int32.MinValue : nums1[partitionX - 1];
                int minRightX = (partitionX == x) ? Int32.MaxValue : nums1[partitionX];

                int maxLeftY = (partitionY == 0) ? Int32.MinValue : nums2[partitionY - 1];
                int minRightY = (partitionY == y) ? Int32.MaxValue : nums2[partitionY];

                if (maxLeftX <= minRightY && maxLeftY <= minRightX)
                {
                    if ((x + y) % 2 == 0)
                    {
                        return ((double)Math.Max(maxLeftX, maxLeftY) + (double)Math.Min(minRightX, minRightY)) / 2;
                    }
                    else
                    {
                        return (double)Math.Max(maxLeftX, maxLeftY);
                    }
                }

                else if (maxLeftX > minRightY)
                {
                    end = partitionX - 1;
                }
                else
                {
                    start = partitionX + 1;
                }

            }
            throw new ArgumentException();
        }
    }
}
