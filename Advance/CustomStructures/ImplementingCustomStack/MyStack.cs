using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementingCustomStack
{
    public class MyStack<T>
    {

        public const int DefaultCapacity = 4;

        public T[] elements = new T[DefaultCapacity];
        public int Count { get; private set; } = 0;



        public void Push(T element)
        {
            Resize();
            elements[Count] = element;
            Count++;
        }


        public T Pop()
        {
            if (elements.Length == 0)
            {
                throw new InvalidOperationException();
            }
            Count--;
            T lastElement = elements[Count];
            if (Count <= elements.Length / 4)
            {
                Shrink();
            }
            return lastElement;
        }

        public T Peek()
        {
            if (elements.Length == 0)
            {
                throw new InvalidOperationException();
            }

            var lastElement = elements[Count - 1];
            return lastElement;
        }

        public void ForEach(Action<T> action)
        {
            for (int i = 0; i < Count; i++)
            {
                action(elements[i]);
            }
        }

        public void Shrink()
        {
            var newArr = new T[Count];
            for (int i = 0; i < Count; i++)
            {
                newArr[i] = elements[i];
            }

            elements = newArr;
        }


        public bool Contains(T element)
        {
            for (int i = 0; i < Count; i++)
            {
                if (elements[i].Equals(element))
                {
                    return true;
                }
            }

            return false;
        }


        private void Resize()
        {
            if (Count == elements.Length)
            {
                var newArr = new T[elements.Length * 2];
                for (int i = 0; i < elements.Length; i++)
                {
                    newArr[i] = elements[i];
                }

                elements = newArr;
            }
        }
    }
}
