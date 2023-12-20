using DSAConcepts.Lists;
using DSAConcepts.StackAndQueue;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Singly Linked List : ");
        SinglyLinkedList<int>.ProcessSInglyLinkedList();
        Console.WriteLine("Doubly Linked List");
        DoublyLinkedList<int>.ProcessDoublyLinkedList();
        Console.WriteLine("Sorted List");
        SortedList<int>.ProcessSortedList();
        Console.WriteLine("Queue");
        DSAConcepts.StackAndQueue.Queue<int>.ProcessQueue();
        Console.WriteLine("Stack");
        DSAConcepts.StackAndQueue.Stack<int>.ProcessStack();
    }
    
    
}