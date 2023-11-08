using AddTwoNumbersRecursion;

class program
{
    public static void Main(String[] args)
    {
        AddTwoNumbers addTwo = new AddTwoNumbers();
        var node1 = new ListNode(2,new ListNode(4,new ListNode(3)));
        var node2 = new ListNode(5, new ListNode(6, new ListNode(4)));
        var res = addTwo.Solution(node1,node2);
    }
    
}