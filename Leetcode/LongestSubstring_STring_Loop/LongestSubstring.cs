using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LongestSubstring_STring_Loop
{
    public class LongestSubstring
    {
        public int LengthOfLongestSubstring(string s)
        {
            int count = 0,res = 0;
            List<string> chars = new List<string>();
            for (int i = 0; i < s.Length; i++) 
            {
                if (chars.Contains(s[i].ToString()))
                {
                    if (count > res)
                        res = count;
                    int index = chars.IndexOf(s[i].ToString());
                    for(int j=0;j<= index; j++)
                    {
                        chars.RemoveAt(0);
                    }
                    chars.Add(s[i].ToString());
                    count = chars.Count;
                }
                else
                {
                    chars.Add(s[i].ToString());
                    count++;
                }
                    
            }

            return count > res ? count : res;
        }

        public int LengthOfLongestSubstringOptimal(string s)
        {
            int maxLength = 0;
            int start = 0;

            for (int i = 0; i < s.Length; i++)
            {
                char currentChar = s[i];
                int index = s.IndexOf(currentChar, start, i - start);
                if (index != -1)
                {
                    start = index + 1;
                }
                maxLength = Math.Max(maxLength, i - start + 1);
            }
            return maxLength;
        }
    }
}
