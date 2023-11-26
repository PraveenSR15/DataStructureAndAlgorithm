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

        public ListNode AddTwoNumbersOptimal(ListNode l1, ListNode l2, int carry)
        {
            var total = carry;
            carry = 0;
            if (l1 == null && l2 == null)
            {
                if (total > 0)
                {
                    return new ListNode(total);
                }
                return null;
            }
            var ln = new ListNode();
            if (l1 == null)
            {
                total += l2.val;
                if (total > 9)
                {
                    carry = total / 10;
                }
                ln.val = total % 10;
                ln.next = AddTwoNumbersOptimal(null, l2.next, carry);
                return ln;
            }

            if (l2 == null)
            {
                total += l1.val;
                if (total > 9)
                {
                    carry = total / 10;
                }
                ln.val = total % 10;
                ln.next = AddTwoNumbersOptimal(l1.next, null, carry);
                return ln;
            }
            total += l1.val + l2.val;
            if (total > 9)
            {
                carry = total / 10;
            }
            ln.val = total % 10;
            ln.next = AddTwoNumbersOptimal(l1.next, l2.next, carry);
            return ln;
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
