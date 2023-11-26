using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.RemoveDuplicates_Array_Loop
{
    public class RemoveDuplicateNumbers
    {
        public int RemoveDuplicates(int[] nums)
        {

            HashSet<int> result = new HashSet<int>();
            for(int i = 0;i<nums.Length;i++)
                result.Add(nums[i]);
            Array.Clear(nums);
            int index = 0;
            foreach(var res in result)
            {
                nums[index] = res;
                index++;
            }
                
            return result.Count;
        }

        public int RemoveDuplicatesOptimal(int[] nums)
        {
            int index = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                bool hasUniqueElement = false;
                for (int j = 0; j < i; j++)
                {
                    if (nums[j] == nums[i])
                    {
                        hasUniqueElement = true;
                        break;
                    }
                }
                if (!hasUniqueElement)
                {
                    nums[index++] = nums[i];
                }
            }

            return index;
        }
    }
}
