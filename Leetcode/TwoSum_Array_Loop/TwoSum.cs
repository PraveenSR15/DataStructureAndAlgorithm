using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.TwoSum_Array_Loop
{
    public class TwoSum
    {
        public int[] TwoSumSolution(int[] nums, int target)
        {
            int[] result = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if ((nums[i] + nums[j]) == target)
                    {
                        result[0] = i;
                        result[1] = j;
                    }
                }
            }
            return result;
        }

        public int[] TwoSumOptimal(int[] nums, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int a = target - nums[i];
                if (dic.ContainsKey(a))
                {
                    return new int[] { dic[a], i };
                }
                dic[nums[i]] = i;
            }
            return new int[] { };
        }
    }
}
