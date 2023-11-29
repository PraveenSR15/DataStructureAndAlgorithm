using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ConcatArray_Array_Loop
{
    public class ConcatArray
    {
        public int[] GetConcatenation(int[] nums)
        {
            int[] res = new int[nums.Length * 2];
            int index = 0;
            for (int i = 0; i < res.Length; i++)
            {
                res[i] = nums[index];
                index++;

                if (index == nums.Length)
                    index = 0;
            }
            return res;
        }
        public int[] GetConcatenationOptimal(int[] nums)
        {
            int[] ans = new int[2 * nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                ans[i] = nums[i];
                ans[i + nums.Length] = nums[i];
            }
            return ans;
        }
    }
}
