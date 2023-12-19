using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAConcepts.Lists
{
    public class SinglyLinkedList<T> : IEnumerable<T>
    {
        public T value;
        public SinglyLinkedList<T> next;

        public SinglyLinkedList<T> head;
        public SinglyLinkedList<T> tail;

        public SinglyLinkedList()
        {
            
        }
        public SinglyLinkedList(T value, SinglyLinkedList<T> next = null)
        {
                this.value = value;
                this.next = next;
        }

        public static void ProcessSInglyLinkedList()
        {
            SinglyLinkedList<int> singlyLinkedList = new SinglyLinkedList<int>();
            singlyLinkedList.tail = singlyLinkedList;
            singlyLinkedList.head = singlyLinkedList;

            for(int i=1;i<10;i++)
                singlyLinkedList.AddTail(i);
            
            var current = singlyLinkedList;
            while (current != null)
            {
                Console.WriteLine(current.value);
                current = current.next;
            }

            Console.WriteLine("Searcing for 5");
            var result = singlyLinkedList.Find(5);
            Console.WriteLine(result != null ? result.value : "5 not found");


            Console.WriteLine("Searcing for -5");
            result = singlyLinkedList.Find(-5);
            Console.WriteLine(result != null ? result.value : "-5 not found");

            Console.WriteLine("Removing 5");
            if (singlyLinkedList.Remove(5))
            {
                var node = singlyLinkedList.head;
                while (node != null)
                {
                    Console.WriteLine(node.value);
                    node = node.next;
                }
            }
        }
        void AddTail(T node) 
        {
            tail.next = new SinglyLinkedList<T>(node);
            tail = tail.next;
        }

        public SinglyLinkedList<T> Find(T node)
        {
            var current = head;
            while (current != null)
            {
                if (current.value.Equals(node))
                    return current;
                current = current.next;
            }
            return null;
        }


        IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }

        public System.Collections.Generic.IEnumerator<T> GetEnumerator()
        {
            SinglyLinkedList<T> current = head;
            while (current != null)
            {
                yield return current.value;
                current = current.next;
            }
        }

        public bool Remove(T node)
        {
            var current = head;
            while(current != null) 
            {
                if(current.next.value.Equals(node))
                {
                    current.next = current.next.next;
                    return true;
                }
                current = current.next;
            }
            return false;
        }

    }
}
