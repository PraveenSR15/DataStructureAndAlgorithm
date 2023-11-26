using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LengthOfLastWord_String_Array
{
    public class LengthOfLastWord
    {
        public int LengthOfLastWordSolution(string s)
        {
            string[] inp = s.Trim().Split(' ');
            return inp[inp.Length - 1].Length;
        }
    }
}
