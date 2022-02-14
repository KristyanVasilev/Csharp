using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOfT
{
    public class Box<T>
    {
        public List<T> InternalList = new List<T>();

        public int Count => InternalList.Count;

        public void Add(T element)
        {
            InternalList.Add(element);
        }

        public T Remove()
        {
            var element = InternalList[InternalList.Count - 1];
            InternalList.RemoveAt(InternalList.Count - 1);
            return element;
        }
    }
}
