
using Microsoft.VisualBasic;

namespace Linked_List
{
    public class LinkedList
    {

        private class Node
        {
            public int value;
            public Node? next;

            public Node(int value)
            {
                this.value = value;
            }
        }
        private Node? first;
        private Node? last;
        private int size;

        public void AddLast(int item)
        {
            var node = new Node(item);
            if (IsEmpty())
            {
                first = last = node;
            }
            else
            {
                last!.next = node;
                last = node;
            }
            size++;

        }

        public void AddFirst(int item)
        {
            var node = new Node(item);
            if (IsEmpty())
            {
                first = last = node;
            }
            else
            {
                first!.next = node;
                first = node;
            }
            size++;
        }

        public int IndexOf(int item)
        {
            int index = 0;
            var current = first;
            while (current != null)
            {
                if (current.value == item) return index;
                current = current.next;
                index++;
            }
            return -1;
        }

        public bool Contains(int item)
        {
            return IndexOf(item) != -1;

        }


        public void RemoveFirst()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException();
            }

            if (first == last)
            {
                first = last = null;
            }
            else
            {
                // [10 20 -> 30]
                var second = first!.next;
                first!.next = null;
                first = second;
                // first --> 20
            }
            size--;
        }

        public void RemoveLast()
        {
            if (IsEmpty()) throw new NotSupportedException();

            if (first == last)
            {
                first = last = null;
            }
            else
            {
                var previous = GetPrevious(last!);
                last = previous;
                last.next = null;
            }
            size--;

        }

        public int Size()
        {
            return size;
        }

        // addFirst
        // addLast
        // deleteFirst
        // deleteLast
        // contains

        private bool IsEmpty()
        {
            return first == null;
        }

        private Node GetPrevious(Node node)
        {
            var current = first;
            while (current != null)
            {
                if (current.next == node) return current;
                current = current.next;
            }
            return null!;
        }

        public int[] ToArray()
        {
            int[] array = new int[size];
            var current = first;
            var index = 0;
            while (current != null)
            {
                array[index] = current.value;
                index++;
                current = current.next;
            }
            return array;
        }


    }
}