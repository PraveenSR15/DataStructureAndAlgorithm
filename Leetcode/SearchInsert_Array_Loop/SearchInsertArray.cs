using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.SearchInsert_Array_Loop
{
    public class SearchInsertArray
    {
        public int SearchInsert(int[] nums, int target)
        {
            int index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                    return i;
                else if (nums[i] > target)
                {
                    index = i;
                    break;
                }
                else if (nums[nums.Length - 1] < target)
                    index = nums.Length;
            }
            return index;
        }
        public int SearchInsertOptimal(int[] nums, int target)
        {
            int k = 0;
            int v = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    k = i;
                    break;
                }
                else
                {

                    if (nums[i] > target)
                    {
                        k = target = v; ;
                        break;
                    }
                    else if (nums[i] < target && i == nums.Length - 1)
                    {
                        k = i + 1;

                    }
                    v++;
                }
            }
            return k;
        }
    }
}
