using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Permutation_Array_Loop
{
    public class PermutationArray
    {
        public int[] BuildArray(int[] nums)
        {
            int[] res = new int[nums.Length];
            for(int i = 0; i < nums.Length; i++) 
            {
                res[i] = nums[nums[i]];
            }
            return res;
    }
    }
}
