using AddTwoNumbersRecursion;
using LeetCode.IndexOfString_String_Loop;
using LeetCode.RemoveDuplicates_Array_Loop;
using LeetCode.Stairs_Integer_Fibonacci;
using LeetCode.TwoSum_Array_Loop;
using MultiplyStrings;

class program
{
    public static void Main(String[] args)
    {
        //AddTwoNumbers addTwo = new AddTwoNumbers();
        //var node1 = new ListNode(2,new ListNode(4,new ListNode(3)));
        //var node2 = new ListNode(5, new ListNode(6, new ListNode(4)));
        //var res = addTwo.Solution(node1,node2);

        //MultiplyTwoStrings multiply = new MultiplyTwoStrings();
        //multiply.Multiply("6913259244", "71103343");

        //RemoveDuplicateNumbers removeDuplicateNumbers = new RemoveDuplicateNumbers();
        //removeDuplicateNumbers.RemoveDuplicates(new int[] { 1, 1, 2, 3, 5, 5, 5, 6 });

        //TwoSum twoSum = new TwoSum();
        //var res = twoSum.TwoSumSolution(new int[] { 2, 7, 11, 15 }, 9);

        //IndexOfString index = new IndexOfString();
        //index.StrStr("mississippi", "issipy");

        Stairs stairs = new Stairs();
        var res = stairs.ClimbStairs(6);
    }
    
}