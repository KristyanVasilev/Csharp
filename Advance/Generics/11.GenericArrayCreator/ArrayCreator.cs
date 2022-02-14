using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GenericArrayCreator
{
    public class ArrayCreator<T>
    {
        public static T[] Create(int lenght, T item)           
        {
            T[] array = new T[lenght];
            for (int i = 0; i < lenght; i++)
            {
                array[i] = item;
            }

            return array;
        }
    }
}
