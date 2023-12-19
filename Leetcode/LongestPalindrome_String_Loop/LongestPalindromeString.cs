using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LongestPalindrome_String_Loop
{
    public class LongestPalindromeString
    {
        public string LongestPalindrome(string s)
        {
            //var res = "";
            //int i = 0;
            //for (int j = s.Length-1; j >= 0; j--)
            //{
            //    if (s[i] == s[j])
            //    {
            //        res += s[i];
            //        if (i != s.Length - 1)
            //            i++;
            //    }
            //}
            string res = "";
            int endIndex = s.Length-1;
            for(int i = 0;i<s.Length;i++)
            {
                for (int j = endIndex; j >= 0; j--)
                {
                    if (s[i] == s[j] && i != j)
                    {
                        res += s[i];
                        endIndex = j - 1;
                        break;
                    }
                    else if ((s[i] == s[j] && i == j && res != "") || (i == j && s.Length <= 2))
                    {
                        res += s[i];
                        endIndex = j - 1;
                        break;
                    }
                    if (s[i] != s[j] && i < j)
                        res = "";
                }
            }

            return "";
        }
    }
}
