using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.RemoveElement_Array_loop
{
    public class RemoveArrayElement
    {
        public int RemoveElement(int[] nums, int val)
        {
            int count = 0,i=0,j= nums.Length-1;
            for (; i < j; i++)
            {
                if (nums[i] == val)
                {
                    for (; j > i ; j--)
                    {
                        if (nums[j] != val)
                        {
                            int temp = nums[j];
                            nums[j] = nums[i];
                            nums[i] = temp;
                            break;
                        }
                    }
                }
            }
            return nums.Length - count;
        }
        public int RemoveElementOpimal(int[] nums, int val)
        {
            int[] values = new int[nums.Length];
            int count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    values[count] = nums[i];
                    count += 1;
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = values[i];
            }
            return count;
        }
    }
}
