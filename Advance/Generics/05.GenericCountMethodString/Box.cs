using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generic
{
    public class Box<T>
        where T : IComparable
    {
        public List<T> Store { get; set; } = new List<T>();

        public void Swap(int firstIndex, int secondIndex) => 
            (Store[firstIndex], Store[secondIndex]) = (Store[secondIndex], Store[firstIndex]);

        public int Count(T itemToCompare)
        {
            int count = 0;
            foreach (var item in Store)
            {
                if (item.CompareTo(itemToCompare) > 0)
                {
                    count++;
                }
            }

            return count;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var item in Store)
            {
                sb.AppendLine($"{typeof(T)}: {item}");
            }
            return sb.ToString();
        }
    }
}
