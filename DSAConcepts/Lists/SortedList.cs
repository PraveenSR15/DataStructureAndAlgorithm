using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAConcepts.Lists
{
    public class SortedList<T> : IComparable<T>, IEnumerable<T> where T : IComparable
    {
        public SortedList<T> head;
        public SortedList<T> tail;
        public SortedList<T> next;
        public SortedList<T> previous;
        public T value;

        public static void ProcessSortedList()
        {
            SortedList<int> sortedList = new SortedList<int>();
            sortedList.Add(5);
            sortedList.Add(4);
            sortedList.Add(6);
            sortedList.Add(3);
            sortedList.Add(7);


            foreach(var list in sortedList)
                Console.WriteLine(list);
        }
        public SortedList()
        {
            
        }
        public SortedList(T value, SortedList<T> previous = null, SortedList<T> next = null)
        {
            this.value = value;
            this.previous = previous;
            this.next = next;
        }

        
        public int CompareTo(T other)
        {
            return value.CompareTo(other);
            //var existing = int.Parse(value.ToString());
            //var incoming = int.Parse(other.value.ToString());

            //if (existing == incoming)
            //    return 0;
            //else if(existing < incoming)
            //    return -1;
            //else 
            //    return 1;
        }

        void Add(T value) 
        {
            if (head == null)
            {
                head = new SortedList<T>(value);
                tail = head;
            }
            else if(head.CompareTo(value) >= 0)
            {
                SortedList<T> newHead = new SortedList<T>(value);
                newHead.next = head;
                head.previous = newHead;
                head = newHead;
            }
            else if(tail.CompareTo(value) < 0)
            {
                SortedList<T> newTail = new SortedList<T>(value);
                newTail.previous = tail;
                tail.next = newTail;
                tail = newTail;
            }
            else
            {
                SortedList<T> insertBefore = head;
                while(insertBefore.CompareTo(value) < 0) 
                {
                    insertBefore = insertBefore.next;
                }
                SortedList<T> inserT = new SortedList<T>(value);
                inserT.next = insertBefore;
                inserT.previous = insertBefore.previous;
                insertBefore.previous.next = inserT;
                insertBefore.previous = inserT;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            SortedList<T> current = head;
            while (current != null)
            {
                yield return current.value;
                current = current.next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
