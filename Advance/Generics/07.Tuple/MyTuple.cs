using System;
using System.Collections.Generic;
using System.Text;

namespace _07.Tuple
{
    public class MyTuple<T1,T2>
    {
        public MyTuple(T1 firstItem, T2 secondItem)
        {
            FirstItem = firstItem;
            SecondItem = secondItem;
        }

        public T1 FirstItem { get; set; }
        public T2 SecondItem { get; set; }

        public override string ToString() => $"{FirstItem} -> {SecondItem}";
    }
}
