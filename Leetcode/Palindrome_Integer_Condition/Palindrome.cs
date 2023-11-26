using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Palindrome_Integer_Condition
{
    public class Palindrome
    {
        public bool IsPalindrome(int x)
        {
            var value = x.ToString().ToArray();
            var reverse = value.Reverse().ToArray();
            for(int i = 0; i<value.Length;i++ )
            {
                if (value[i] != reverse[i])
                    return false;
            }
            return true;
        }

        public bool IsPalindromeOptimal(int x)
        {
            if (x < 0)
                return false;

            int original = x;
            int reversed = 0;

            while (x != 0)
            {
                int digit = x % 10;
                x /= 10;

                reversed = reversed * 10 + digit;
            }
            return original == reversed;
        }
    }
}
