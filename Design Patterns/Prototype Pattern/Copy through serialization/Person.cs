using System;

namespace CopyThroughSerialization
{
    [Serializable]
    public class Person
    {
        public string Name;

        public int Age;


        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Age)}: {Age}";
        }
    }
}
