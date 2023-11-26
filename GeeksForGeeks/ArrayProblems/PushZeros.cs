using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeks.ArrayProblems
{
    public class PushZeros
    {
        public static void PushZerosToEnd(int[] arr, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                if (arr[i] == 0)
                {
                    for(int j=i+1; j < n; j++)
                    {
                        if (arr[j] > 0)
                        {
                            int temp = arr[j];
                            arr[j] = arr[i];
                            arr[i] = temp;
                            i++;
                        }
                    }
                }
            }
            Console.WriteLine(arr);
        }
    }
}
