using System;
using System.Collections.Generic;
using System.Linq;


namespace T01.Train.ex
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> waggons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] tokens = command.Split(); //Правим масив от команди, които ги разделяме със space.
                if (tokens.Length == 2) //Ако дължината е = 2, имаме 2 команди, първата е "Add", втората е бройката на пасажери във вагон.
                {
                    int addWaggons = int.Parse(tokens[1]); //Превръщаме втората команда от string => int.
                    waggons.Add(addWaggons); //Добавяме вагона с пасажерите му накрая на влака.
                }
                else
                {
                    int addPassenger = int.Parse(tokens[0]);
                    findPlaceForPassenger(waggons, maxCapacity, addPassenger);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(String.Join(" ", waggons));
        }

        private static void findPlaceForPassenger(List<int> waggons, int maxCapacity, int addPassenger)
        {
            for (int i = 0; i < waggons.Count; i++) //Намираме вагон, който може да събере пътниците.
            {
                if (waggons[i] + addPassenger <= maxCapacity)
                {
                    waggons[i] += addPassenger;
                    break;
                }
            }
        }
    }
}
