using System;
using System.Collections.Generic;
using System.Text;

namespace Generic
{
    public class Box<T>
    {
        public List<T> Store { get; set; } = new List<T>();

        public void Swap(int firstIndex, int secondIndex) => 
            (Store[firstIndex], Store[secondIndex]) = (Store[secondIndex], Store[firstIndex]);


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
