using System;
using System.Linq;

namespace T04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            //51 47 32 61 21
            //2
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int numOfRotations = int.Parse(Console.ReadLine());

            for (int rotation = 0; rotation < numOfRotations; rotation++) //Брой ротации, които взимаме от numOfRotations.
            {
                int temp = array[0]; //Пазим 1вото число на масива. 51,47,32,61,21 --> temp = 51.
                for (int operations = 0; operations < array.Length - 1; operations++)
                {
                    array[operations] = array[operations + 1]; //Въртим числата с едно на ляво! 51,47,32,61,21 --> 47,32,61,21,21.
                }
                array[array.Length - 1] = temp; //Последното число от масива е равно на първото. 21(array.Lenght-1) = 51(temp)
            }
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
