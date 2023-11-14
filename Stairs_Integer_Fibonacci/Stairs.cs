using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Stairs_Integer_Fibonacci
{
    public class Stairs
    {
        public int ClimbStairs(int n)
        {
            int previous = 1;
            int current = 2;
            int res = 0;
            for(int i=3;i<=n;i++)
            {
                res = current + previous;
                previous = current;
                current = res;
            }
            
            return res;
        }

        public int ClimbStairsOptimal(int n)
        {
            Dictionary<int, int> memo = new Dictionary<int, int>();
            return climbStairsOptimal(n, memo);
        }
        private int climbStairsOptimal(int n, Dictionary<int, int> memo)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            if (!memo.ContainsKey(n))
            {
                memo.Add(n, climbStairsOptimal(n - 1, memo) + climbStairsOptimal(n - 2, memo));
            }
            return memo[n];
        }
    }
}
