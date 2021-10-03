using System;
using System.Linq;

namespace T05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < array.Length; i++) //Обикаляме през целия масив. For loop-а започва от array[0].
            {
                bool currentNumIsBigger = true; //Текущото число винаги е по-голямо.
                for (int j = i + 1; j < array.Length; j++) //for loop-а започва от array[1].
                {
                    if (array[i] <= array[j]) //Сравняваме Х число и тези от дясно на него. пр. array[0] <= array[1], array[2] и тн... 
                    {
                        currentNumIsBigger = false; // Ако array[0] <= array[1], array[2] и тн..., то текущото число е по-малко и не го принтираме.
                    }
                }
                if (currentNumIsBigger)
                {
                    Console.Write(array[i] + " "); //Пр. Принтираме array[1], ако array[1] > array[2] .
                }
            }
        }
    }
}
