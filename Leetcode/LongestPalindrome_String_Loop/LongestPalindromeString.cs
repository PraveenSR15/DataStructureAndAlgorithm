using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LongestPalindrome_String_Loop
{
    public class LongestPalindromeString
    {
        string input;
        public string LongestPalindrome(string s)
        {
            input = s;
            string res = "";
            int endIndex = s.Length-1;
            int start = 0, end = 0;
            for (int i = 0; i < s.Length; i++)
            {
                string palindrome = "";
                start = i;end = i;
                palindrome = longestpalindrome(start, end);
                //while(true)
                //{
                //    if(i == 0 && res == "")
                //    {
                //        res = s.Substring(start, end - start + 1);
                //        break;
                //    }
                //    else if (i == s.Length - 1)
                //    {
                //        break;
                //    }
                //    else
                //    {
                //        start--;
                //        end++;
                //        if (s[start] == s[end])
                //        {
                //            palindrome = s.Substring(start, end - start + 1);
                //        }
                //        else
                //            break;
                //    }
                //}
                if(palindrome.Length > res.Length)
                    res = palindrome;
            }
            return res;
        }
        string longestpalindrome(int start,int end)
        {
            if (input[start] == input[end] && start > 0 && end < input.Length-1)
              return  longestpalindrome(start-1, end+1);
            
            return input.Substring(start, end - start + 1);
        }

        public bool checkPalindrome(string input)
        {
            var reverseArr = input.Reverse<char>().ToArray();
            string reverse = "";
            for (int i = 0; i < reverseArr.Length; i++)
                reverse += reverseArr[i];

            return input.Equals(reverse);
        }
    }
}
