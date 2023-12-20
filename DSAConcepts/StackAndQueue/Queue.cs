using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAConcepts.StackAndQueue
{
    public class Queue<T>
    {
        readonly Dequeue<T> queue = new Dequeue<T>();
        public void Enqueue(T value)
        {
            queue.EnqueueTail(value);
        }
        public T Dequeue()
        {
            return queue.DequeueHead();
        }
        public T Peek()
        {
            T value;
            if(queue.PeekHead(out value))
            {
                return value;
            }
            throw new InvalidOperationException();
        }

        public int Count
        {
            get { return queue.Count(); }
        }

        public static void ProcessQueue()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(0);
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);

            foreach (var item in queue.queue)
                Console.WriteLine(item);
            Console.WriteLine("Head");
            Console.WriteLine(queue.Peek());
            Console.WriteLine("Dequeue");
            queue.Dequeue();
            Console.WriteLine("Head");
            Console.WriteLine(queue.Peek());
        }

    }
}
