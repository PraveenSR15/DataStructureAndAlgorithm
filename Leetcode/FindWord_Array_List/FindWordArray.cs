using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.FindWord_Array_List
{
    public class FindWordArray
    {
        public IList<int> FindWordsContaining(string[] words, char x)
        {
            List<int> res = new List<int>();
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Contains(x))
                    res.Add(i);
            }
            return res;
        }
    }
}
