using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Operations_Array_Loop
{
    public class OperationsArray
    {
        public int FinalValueAfterOperations(string[] operations)
        {
            int x = 0;
            for (int i = 0; i < operations.Length; i++)
            {
                if (operations[i].Contains("++"))
                    x++;
                else
                    x--;
            }
            return x;
        }
    }
}
