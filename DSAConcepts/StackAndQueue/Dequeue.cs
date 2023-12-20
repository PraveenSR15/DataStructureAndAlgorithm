using DSAConcepts.Lists;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAConcepts.StackAndQueue
{
    public class Dequeue<T> : IEnumerable<T>
    {
        DoublyLinkedList<T> queue = new DoublyLinkedList<T>();

        public void EnqueueHead(T value)
        {
            queue.AddHead(value);
        }
        public void EnqueueTail(T value)
        {
            queue.AddTail(value);
        }
        public T DequeueHead()
        {
            T value;
            if(queue.GetHead(out value))
            {
                queue.RemoveHead();
                return value;
            }
            throw new InvalidOperationException();
        }
        public T DequeueTail()
        {
            T value;
            if (queue.GetTail(out value))
            {
                queue.RemoveTail();
                return value;
            }
            throw new InvalidOperationException();
        }

        public bool PeekHead(out T value)
        {
            return queue.GetHead(out value);
        }
        public bool PeekTail(out T value)
        {
            return queue.GetTail(out value);
        }
        public IEnumerator<T> GetEnumerator()
        {
            return queue.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
