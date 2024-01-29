using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LetterCombinationsPhoneNumber_HashTable_Loop
{
    public class LetterCombination
    {
        string[] Keys = new string[10];
        List<string> Result = new List<string>();
        public LetterCombination()
        {
            Keys[2] = "abc";
            Keys[3] = "def";
            Keys[4] = "ghi";
            Keys[5] = "jkl";
            Keys[6] = "mno";
            Keys[7] = "pqrs";
            Keys[8] = "tuv";
            Keys[9] = "wxyz";
        }
        public IList<string> LetterCombinations(string digits)
        {
            
            int levels = digits.Length;
            if (levels == 0)
                return Result;

            int l1 = digits[0] - '0';
            foreach(var char1 in Keys[l1])
            {
                if(levels > 1)
                {
                    int l2 = digits[1] - '0';
                    foreach(var char2 in Keys[l2]) 
                    {
                        if(levels > 2) 
                        {
                            int l3 = digits[2] - '0';
                            foreach(var char3 in Keys[l3])
                            {
                                if (levels > 3)
                                {
                                    int l4 = digits[3] - '0';
                                    foreach (var char4 in Keys[l4])
                                    {
                                        Result.Add(char1.ToString() + char2.ToString() + char3.ToString() + char4.ToString());
                                    }
                                }
                                else
                                    Result.Add(char1.ToString() + char2.ToString() + char3.ToString());
                            }
                        }
                        else
                            Result.Add(char1.ToString() + char2.ToString());
                    }
                }
                else
                    Result.Add(char1.ToString());
            }

            return Result;
        }
    }
}
