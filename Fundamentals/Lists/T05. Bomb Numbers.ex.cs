using System;
using System.Linq;
using System.Collections.Generic;

namespace T05._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] bombSpecifications = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int bombPosition = bombSpecifications[0];                      
            int damage = bombSpecifications[1];

            for (int i = 0; i < numbers.Count; i++)                         
            {
                if (numbers[i] == bombPosition)                            
                {
                    for (int j = i - damage; j <= i + damage; j++)//стартираме от настоящата бомба i минус обхвата, по усл. взривяваме от ляво на дясно и обхождаме до i+обхвата
                    {
                        if (j < 0 || j >= numbers.Count)//проверяваме дали индекса на числото-бомба е в границите на масива, ако не е - преминаваме към следваща итерация
                        {
                            continue;
                        }
                        numbers[j] = 0;                                    
                    }
                }
            }
            Console.WriteLine(numbers.Sum());
        }
    }
}
