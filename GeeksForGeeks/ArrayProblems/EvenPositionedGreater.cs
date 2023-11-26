using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeks.ArrayProblems
{
    public class EvenPositionedGreater
    {
        public static ArrayList assign(int[] a, int n)
        {
            ArrayList arr = new ArrayList();
            //n = n%2 == 0 ? n-1 : n - 2;
            for (int i = 1; i < n; i++)
            {
                if(i%2 == 1)
                {
                    if (a[i] < a[i-1])
                    {
                        int temp = a[i];
                        a[i] = a[i-1]; 
                        a[i-1] = temp;
                    }

                    if (i<n-1 && a[i] < a[i+1])
                    {
                        int temp = a[i];
                        a[i] = a[i+1];
                        a[i+1] = temp;
                    }
                }
                else
                {
                    if (a[i] > a[i - 1])
                    {
                        int temp = a[i];
                        a[i] = a[i - 1];
                        a[i - 1] = temp;
                    }

                    if (i < n - 1 && a[i] > a[i + 1])
                    {
                        int temp = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = temp;
                    }
                }
            }
            for (int i = 0;i<n;i++)
            {
                arr.Add(a[i]);
            }

            return arr;
;
        }
    }
}