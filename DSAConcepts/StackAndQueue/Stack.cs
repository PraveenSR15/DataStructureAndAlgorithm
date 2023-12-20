using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAConcepts.StackAndQueue
{
    public class Stack<T>
    {
        readonly Dequeue<T> stack = new Dequeue<T> ();

        public void Push(T value)
        {
            stack.EnqueueHead(value);
        }
        public T Pop() 
        {
            return stack.DequeueHead();
        }

        public T Peek()
        {
            T value;
            if (stack.PeekHead(out value))
            {
                return value;
            }
            throw new InvalidOperationException();
        }

        public int Count
        {
            get { return stack.Count(); }
        }

        public static void ProcessStack()
        {
            Stack<int> stack = new Stack<int> ();
            stack.Push(0);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            
            foreach (var item in stack.stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Head");
            Console.WriteLine(stack.Peek());
            Console.WriteLine("Pop");
            stack.Pop();
            Console.WriteLine("Head");
            Console.WriteLine(stack.Peek());
        }
    }
}
