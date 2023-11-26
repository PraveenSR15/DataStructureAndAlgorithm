using GeeksForGeeks.ArrayProblems;

public class Program
{
    public static void Main(string[] args)
    {
        int[] arr = new int[] { 10, 4, 3, 50, 23, 90, 90 };
        LargestThreeNumbers.print3largest(arr,arr.Length);

        int[] arr2 = new int[] { 1, 2, 0, 4, 3, 0, 5, 0 };
        PushZeros.PushZerosToEnd(arr2,arr2.Length);
        
        int[] arr3 = new int[] { 20, 17 };
        var res = EvenPositionedGreater.assign(arr3,arr3.Length);
        
        foreach(var r in res)
            Console.WriteLine(r);
    }
}