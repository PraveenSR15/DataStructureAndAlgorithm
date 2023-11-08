using System;
using System.Numerics;

namespace AddTwoNumbersRecursion
{
    public class AddTwoNumbers
    {
        public AddTwoNumbers()
        {

        }

        public ListNode Solution(ListNode l1, ListNode l2)
        {
            BigInteger value1 = BigInteger.Parse(NodeToString(l1));
            BigInteger value2 = BigInteger.Parse(NodeToString(l2));
            BigInteger sum = value1 + value2;

            var res = stringToNode(sum.ToString());
            return res;
        }

        public string NodeToString(ListNode l)
        {
            string val = "";
            if (l.next != null)
                val += NodeToString(l.next);

            val += l.val.ToString();
            return val;
        }
        public ListNode stringToNode(string val)
        {
            if (val.Length > 1)
                return new ListNode(int.Parse(val[val.Length - 1].ToString()), stringToNode(val.Remove(val.Length - 1)));
            else
                return new ListNode(int.Parse(val), null);
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode? next = default)
        {
            this.val = val;
            this.next = next;
        }
    }


}
