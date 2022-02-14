using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace CustomDoublyLinkedList
{
    public class DoublyLinkedList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }


        public void AddFirst(Node node)
        {
            if (!IsHeadIsNull(node))
            {
                var currHead = Head;
                Head = node;
                Head.Next = currHead;
                currHead.Previous = Head;
            }
        }

        public void AddLast(Node node)
        {
            if (!IsHeadIsNull(node))
            {
                var currTail = Tail;
                Tail = node;
                Tail.Previous = currTail;
                currTail.Next = Tail;
            }
        }

        public Node RemoveFirst()
        {
            var newHead = Head.Next;
            var oldHead = Head;
            if (newHead != null)
            {
                Head = newHead;
                newHead.Previous = null;
                oldHead.Next = null;
            }
            return oldHead;
        }
        public Node RemoveLast()
        {
            var newTail = Tail.Previous;
            var oldTail = Tail;
            if (newTail != null)
            {
                Tail = newTail;
                newTail.Next = null;
                oldTail.Previous = null;
            }
            return oldTail;
        }

        public void ForEach(Action<Node> action)
        {
            var node = Head;

            while (node != null)
            {
                action(node);
                node = node.Next;
            }
        }

        public Node[] ToArray()
        {
            List<Node> list = new List<Node>();

            var node = Head;
            while (node != null)
            {
                list.Add(node);
                node = node.Next;
            }

            Node[] array = list.ToArray();
            return array;
        }
        private bool IsHeadIsNull(Node node)
        {
            if (Head == null)
            {
                Head = node;
                Tail = node;
                return true;
            }
            return false;
        }
    }
}
