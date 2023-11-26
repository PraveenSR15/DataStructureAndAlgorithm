using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeks.ArrayProblems
{
    public class LargestThreeNumbers
    {
        public static void print3largest(int[] arr, int arr_size)
        {
            int first, second, third;
            first = second = third = 0;

            for(int i = 0; i < arr_size; i++) 
            {
                if (arr[i] >= first)
                {
                    if (arr[i] == first)
                        first = arr[i];
                    else
                    {
                        third = second;
                        second = first;
                        first = arr[i];
                    }
                }
                else if (arr[i] >= second)
                {
                    if (arr[i] == second)
                        second = arr[i];
                    else
                    {
                        third = second;
                        second = arr[i];
                    }
                }
                else if (arr[i] >= third)
                    third = arr[i];
            }
            Console.WriteLine("First : " + first + " Second : " + second + " Third : " + third);
        }
    }
}
