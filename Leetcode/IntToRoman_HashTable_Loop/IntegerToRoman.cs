﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.IntToRoman_HashTable_Loop
{
    public class IntegerToRoman
    {
        public string IntToRoman(int num)
        {
            string res = "";
            while (num > 0) 
            {
                
                if(num >= 1000)
                {
                    num -= 1000;
                    res += "M";
                }
                else if(num >= 900)
                {
                    num -= 900;
                    res += "CM";
                }
                else if(num >= 500)
                {
                    num -= 500;
                    res += "D";
                }
                else if (num >= 400)
                {
                    num -= 400;
                    res += "CD";
                }
                else if(num >= 100)
                {
                    num -= 100;
                    res += "C";
                }
                else if (num >= 90)
                {
                    num -= 90;
                    res += "XC";
                }
                else if (num >= 50)
                {
                    num -= 50;
                    res += "L";
                }
                else if (num >= 40)
                {
                    num -= 40;
                    res += "XL";
                }
                else if (num >= 10)
                {
                    num -= 10;
                    res += "X";
                }
                else if (num == 9)
                {
                    num -= 9;
                    res += "IX";
                }
                else if (num >= 5)
                {
                    num -= 5;
                    res += "V";
                }
                else if (num == 4)
                {
                    num -= 4;
                    res += "IV";
                }
                else if (num >= 1)
                {
                    num -= 1;
                    res += "I";
                }
            }
            return res;
        }
    }
}
