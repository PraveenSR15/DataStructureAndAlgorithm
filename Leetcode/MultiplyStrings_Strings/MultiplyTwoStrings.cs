using System;
using System.Numerics;

namespace MultiplyStrings
{
    public class MultiplyTwoStrings
    {
        public MultiplyTwoStrings()
        {
        }
        public string Multiply(string num1, string num2)
        {
            var val1 = num1;
            var val2 = num2;

            BigInteger res = BigInteger.Parse(val1) * BigInteger.Parse(val2);
            return res.ToString();
        }
    }

}
