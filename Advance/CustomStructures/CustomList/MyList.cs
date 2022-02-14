using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementingCustomList
{
    class MyList<T>
    {
        public const int DefaultCapacity = 2;
        public T[] elements;
        public int count;

        public MyList()
        {
            elements = new T[DefaultCapacity];
            count = 0;
        }
        public T this[int i]
        {
            get
            {
                IsInRange(i);
                return elements[i];
            }
            set
            {
                IsInRange(i);
                elements[i] = value;
            }
        }

        public void Add(T element)
        {
            Resize();
            elements[count] = element;
            count++;
        }


        public T RemoveAt(int index)
        {
            if (IsInRange(index))
            {
                T elementToRemove = elements[index];
                count--;
                for (int i = index; i < count; i++)
                {
                    elements[i] = elements[i + 1];
                }

                if (count <= elements.Length / 4)
                {
                    Shrink();
                }

                return elementToRemove;
            }
            throw new IndexOutOfRangeException();
        }

        public void Shrink()
        {
            var newArr = new T[count];
            for (int i = 0; i < count; i++)
            {
                newArr[i] = elements[i];
            }

            elements = newArr;
        }
        public void ForEach(Action<T> action)
        {
            for (int i = 0; i < count; i++)
            {
                action(elements[i]);
            }
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            IsInRange(firstIndex);
            IsInRange(secondIndex);

            (elements[firstIndex], elements[secondIndex]) = (elements[secondIndex], elements[firstIndex]);
        }

        public bool Contains(T element)
        {
            for (int i = 0; i < count; i++)
            {
                if (elements[i].Equals(element))
                {
                    return true;
                }
            }

            return false;
        }

        private bool IsInRange(int index)
        {
            if (index >= 0 && index <= count)
            {
                return true;
            }

            return false;
        }

        private void Resize()
        {
            if (count == elements.Length)
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
