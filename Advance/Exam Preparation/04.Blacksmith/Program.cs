using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Blacksmith
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> steel = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Stack<int> carbon = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

            var swords = new SortedDictionary<string, int>();
            swords.Add("Gladius", 0);
            swords.Add("Shamshir", 0);
            swords.Add("Katana", 0);
            swords.Add("Sabre", 0);
            swords.Add("Broadsword", 0);

            while (steel.Count > 0 && carbon.Count > 0)
            {
                var swordValue = steel.Peek() + carbon.Peek();
                steel.Dequeue();
                var carbonValue = carbon.Pop();

                if (swordValue == 70)
                {
                    swords["Gladius"]++;
                }
                else if (swordValue == 80)
                {
                    swords["Shamshir"]++;
                }
                else if (swordValue == 90)
                {
                    swords["Katana"]++;
                }
                else if (swordValue == 110)
                {
                    swords["Sabre"]++;
                }
                else if (swordValue == 150)
                {
                    swords["Broadsword"]++;
                }
                else
                {
                    carbon.Push(carbonValue + 5);
                }
            }

            Console.WriteLine((swords.Any(x => x.Value > 0) 
                ? $"You have forged {swords.Values.Sum()} swords." 
                : "You did not have enough resources to forge a sword."));

            if (steel.Count > 0) Console.WriteLine($"Steel left: {string.Join(", ", steel)}");
            else Console.WriteLine("Steel left: none");


            if (carbon.Count > 0) Console.WriteLine($"Carbon left: {string.Join(", ", carbon)}");
            else Console.WriteLine("Carbon left: none");          

            var anySwords = swords.Where(x => x.Value > 0);
            foreach (var dish in anySwords)
            {
                Console.WriteLine($"{dish.Key}: {dish.Value}");
            }
        }
    }
}
/*Gladius	70
Shamshir	80
Katana	90
Sabre	110
Broadsword	150
*/
