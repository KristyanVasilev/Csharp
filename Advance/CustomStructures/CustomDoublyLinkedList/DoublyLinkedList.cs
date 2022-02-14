using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace CustomDoublyLinkedList
{
    public class DoublyLinkedList<T>
    {
        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }
        private int count = 0;


        public void AddFirst(T element)
        {
            var node = new Node<T>(element);
            if (!IsHeadIsNull(node))
            {
                var currHead = Head;
                Head = node;
                Head.Next = currHead;
                currHead.Previous = Head;
                count++;
            }
        }

        public void AddLast(T element)
        {
            var node = new Node<T>(element);
            if (!IsHeadIsNull(node))
            {
                var currTail = Tail;
                Tail = node;
                Tail.Previous = currTail;
                currTail.Next = Tail;
                count++;
            }
        }

        public T RemoveFirst()
        {
            var newHead = Head.Next;
            var oldHead = Head;
            if (newHead != null)
            {
                Head = newHead;
                newHead.Previous = null;
                oldHead.Next = null;
                count--;
            }
            return oldHead.Value;
        }
        public T RemoveLast()
        {
            var newTail = Tail.Previous;
            var oldTail = Tail;
            if (newTail != null)
            {
                Tail = newTail;
                newTail.Next = null;
                oldTail.Previous = null;
                count--;
            }
            return oldTail.Value;
        }

        public void ForEach(Action<T> action)
        {
            var node = Head;

            while (node != null)
            {
                action(node.Value);
                node = node.Next;
            }
        }


        public T[] ToArray()
        {
            T[] array = new T[count];

            int index = 0;
            Node<T> node = Head;
            while (node != null)
            {
                array[index++] = node.Value;
                node = node.Next;
            }
            return array;
        }

        private bool IsHeadIsNull(Node<T> node)
        {
            if (Head == null)
            {
                Head = node;
                Tail = node;
                count++;
                return true;
            }
            return false;
        }
    }
}
