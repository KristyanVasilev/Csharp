using System;
using System.Collections.Generic;
using System.Text;

namespace CustomStack
{
    public class StackOfStrings<T> : Stack<T>
    {
        public bool IsEmpty()
        {
            return this.Count == 0;
        }

        public void AddRange(IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                Push(item);
            }
        }
    }
}
