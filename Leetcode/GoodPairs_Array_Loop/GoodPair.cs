using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.GoodPairs_Array_Loop
{
    public class GoodPair
    {
        public int NumIdenticalPairs(int[] nums)
        {
            int res = 0;
            for (int i = 0; i < nums.Length; i++)
                for (int j = i + 1; j < nums.Length; j++)
                    if (nums[i] == nums[j])
                        res++;
            return res;
        }

        public int NumIdenticalPairsOptimal(int[] nums)
        {
            var dict = new Dictionary<int, int>();
            foreach (var n in nums)
            {
                if (!dict.ContainsKey(n))
                {
                    dict.Add(n, 0);
                }

                dict[n] = dict[n] + 1;
            }

            var result = 0;
            foreach (var (key, value) in dict)
            {
                result += (value * (value - 1)) / 2;
            }

            return result;
        }
    }
}
