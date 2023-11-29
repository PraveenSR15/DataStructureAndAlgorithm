using AddTwoNumbersRecursion;
using LeetCode.IndexOfString_String_Loop;
using LeetCode.LengthOfLastWord_String_Array;
using LeetCode.LongestSubstring_STring_Loop;
using LeetCode.Median_Array;
using LeetCode.Palindrome_Integer_Condition;
using LeetCode.RemoveDuplicates_Array_Loop;
using LeetCode.RemoveElement_Array_loop;
using LeetCode.Stairs_Integer_Fibonacci;
using LeetCode.TwoSum_Array_Loop;
using MultiplyStrings;

class program
{
    public static void Main(String[] args)
    {
        bool exit = false;

        do
        {
            Console.WriteLine("Choose the problem: \n 1. AddTwoNumbers \n 2.MultiplyTwoStrings \n 3.RemoveDuplicateNumbers \n 4.TwoSum \n 5.IndexOfString \n 6.Stairs \n 7.Palindrome \n 8.Median \n 9.LongestSubstring \n 10.LengthOfLastWord \n 11.Remove Element");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddTwoNumbers addTwo = new AddTwoNumbers();
                    var node1 = new ListNode(2, new ListNode(4, new ListNode(3)));
                    var node2 = new ListNode(5, new ListNode(6, new ListNode(4)));
                    var res = addTwo.Solution(node1, node2);
                    do
                    {
                        Console.WriteLine(res.val);
                        res = res.next;
                    }
                    while (res.next != null);
                    break;
                case 2:
                    MultiplyTwoStrings multiply = new MultiplyTwoStrings();
                    Console.WriteLine(multiply.Multiply("6913259244", "71103343"));
                    break;
                case 3:
                    RemoveDuplicateNumbers removeDuplicateNumbers = new RemoveDuplicateNumbers();
                    Console.WriteLine(removeDuplicateNumbers.RemoveDuplicates(new int[] { 1, 1, 2, 3, 5, 5, 5, 6 }));
                    break;
                case 4:
                    TwoSum twoSum = new TwoSum();
                    Console.WriteLine(twoSum.TwoSumSolution(new int[] { 2, 7, 11, 15 }, 9));
                    break;
                case 5:
                    IndexOfString index = new IndexOfString();
                    Console.WriteLine(index.StrStr("mississippi", "issipy"));
                    break;
                case 6:
                    Stairs stairs = new Stairs();
                    Console.WriteLine(stairs.ClimbStairs(6));
                    break;
                case 7:
                    Palindrome palindrome = new Palindrome();
                    Console.WriteLine(palindrome.IsPalindrome(121));
                    break;
                case 8:
                    Median median = new Median();
                    Console.WriteLine(median.FindMedianSortedArrays(new int[] { 1, 2 }, new int[] { 3, 4 }));
                    break;
                case 9:
                    LongestSubstring longestSubstring = new LongestSubstring();
                    Console.WriteLine(longestSubstring.LengthOfLongestSubstring("jbpnbwwd"));
                    break;
                case 10:
                    LengthOfLastWord length = new LengthOfLastWord();
                    Console.WriteLine(length.LengthOfLastWordSolution("   fly me   to   the moon  "));
                    break;
                case 11:
                    RemoveArrayElement remove = new RemoveArrayElement();
                    remove.RemoveElement(new int[] { 4, 5 }, 4);
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
            
            Console.WriteLine("Do you want to exit ? : [y/n]");
            var exitChoice = Console.ReadLine();
            if (exitChoice == "y")
                exit = true;
            else if (exitChoice == "n")
                exit = false;
            else
                Console.WriteLine("Invalid Option.");

        } while (!exit);
        
    }
    
}