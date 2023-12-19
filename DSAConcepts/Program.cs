using DSAConcepts.Lists;
using System.Collections;
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
    }
    
    
}