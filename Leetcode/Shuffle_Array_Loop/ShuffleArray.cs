using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Shuffle_Array_Loop
{
    public class ShuffleArray
    {
        public int[] Shuffle(int[] nums, int n)
        {
            int[] res = new int[nums.Length];
            int j = 0;
            for (int i = 0; i < n; i++)
            {
                res[j] = nums[i];
                j++;
                res[j] = nums[i + n];
                j++;
            }
            return res;
        }
    }
}
