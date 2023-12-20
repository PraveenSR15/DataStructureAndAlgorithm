using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAConcepts.Lists
{
    public class DoublyLinkedList<T> : IEnumerable<T>
    {
        DoublyLinkedList<T> previous;
        T value;
        DoublyLinkedList<T> next;

        DoublyLinkedList<T> head;
        DoublyLinkedList<T> tail;

        public DoublyLinkedList()
        {
            
        }
        public DoublyLinkedList(T value, DoublyLinkedList<T> previous = null, DoublyLinkedList<T> next = null) 
        {
            this.previous = previous;
            this.value = value;
            this.next = next;
        }

        public static void ProcessDoublyLinkedList()
        {
            DoublyLinkedList<int> doublyLinkedList = new DoublyLinkedList<int>();
            doublyLinkedList.head = doublyLinkedList;
            doublyLinkedList.tail = doublyLinkedList;
            for (int i = 1;i<10;i++)
            {
                doublyLinkedList.AddTail(i);
            }
            
            Console.WriteLine("Head to Tail");
            var current = doublyLinkedList.head;
            while(current != null)
            {
                Console.WriteLine(current.value);
                current = current.next;
            }

            Console.WriteLine("Tail to Head");
            current = doublyLinkedList.tail;
            while (current != null)
            {
                Console.WriteLine(current.value);
                current = current.previous;
            }

            Console.WriteLine("Searcing for 5");
            var result = doublyLinkedList.Find(5);
            Console.WriteLine(result != null ? result.value : "5 not found");


            Console.WriteLine("Searcing for -5");
            result = doublyLinkedList.Find(-5);
            Console.WriteLine(result != null ? result.value : "-5 not found");

            Console.WriteLine("Removing 5");
            if (doublyLinkedList.Remove(5))
            {
                var iterate = doublyLinkedList.head;
                while (iterate != null)
                {
                    Console.WriteLine(iterate.value);
                    iterate = iterate.next;
                }
            }
        }

        public bool GetHead(out T value)
        {
            if(head != null)
            {
                value = head.value;
                return true;
            }

            value = default;
            return false;
        }

        public bool GetTail(out T value)
        {
            if (head != null)
            {
                value = head.value;
                return true;
            }

            value = default;
            return false;
        }

        public void RemoveHead()
        {
            if(head != null )
            {
                head = head.next;
                head.previous = null;
            }
        }
        public void RemoveTail()
        {
            if (tail != null)
            {
                tail = tail.previous;
                tail.next = null;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            DoublyLinkedList<T> current = head;
            while (current != null)
            {
                yield return current.value;
                current = current.next;
            }
        }

        public void AddHead(T n)
        {
            if(head == null)
            {
                head = new DoublyLinkedList<T>(n, null, head);
                tail = head;
            }
            else
            {
                head.previous = new DoublyLinkedList<T>(n, null, head);
                head = head.previous;
            }
        }

        public void AddTail(T n)
        {
            if(tail == null && head == null)
            {
                tail = new DoublyLinkedList<T>(n, null, head);
                head = tail;
            }
            else
            {
                tail.next = new DoublyLinkedList<T>(n, tail, null);
                tail = tail.next;
            }
        }

        public DoublyLinkedList<T> Find(T node)
        {
            var current = head;
            while(current != null) 
            {
                if(current.value.Equals(node))
                    return current;
                current = current.next;
            }
            return null;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public bool Remove(T node) 
        {
            var found = Find(node);
            if(found == null) return false;
            var prevNode = found.previous;
            var nexT = found.next;
            if(prevNode == null) 
            {
                head = next;
                if (head != null)
                    head.previous = null;
            }
            else
            {
                found.previous.next = nexT;
            }
            if(nexT == null)
            {
                tail = prevNode;
                if (tail != null)
                    tail.next = null;
            }
            else
            {
                found.next.previous = prevNode;
            }
            return true;
        }

    }
}
