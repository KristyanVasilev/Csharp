using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
    public class RandomList<T> : List<T>
    {
        private Random random;

        public RandomList()
        {
            random = new Random();
        }

        public T RandomString()
        {
            var index = random.Next(0, Count);
            var element = this[index];
            RemoveAt(index);
            return element;
        }   
    }
}
