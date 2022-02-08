using System;
using System.Collections.Generic;
using System.Text;

namespace Generic
{
    public class Box<T>
    {
        public List<T> Store { get; set; } = new List<T>();

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
