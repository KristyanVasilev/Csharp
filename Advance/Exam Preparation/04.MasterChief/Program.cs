using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.MasterChief
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> ingredients = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Stack<int> freshnessLevel = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

            var dict = new SortedDictionary<string, int>();
            dict.Add("Dipping sauce", 0);
            dict.Add("Green salad", 0);
            dict.Add("Chocolate cake", 0);
            dict.Add("Lobster", 0);

            while (ingredients.Count > 0 && freshnessLevel.Count > 0)
            {
                var dishLevel = ingredients.Peek() * freshnessLevel.Peek();
                if (ingredients.Peek() == 0)
                {
                    ingredients.Dequeue();
                    continue;
                }

                freshnessLevel.Pop();

                if (dishLevel == 150)
                {
                    dict["Dipping sauce"]++;
                    ingredients.Dequeue();
                }
                else if (dishLevel == 250)
                {
                    dict["Green salad"]++;
                    ingredients.Dequeue();
                }
                else if (dishLevel == 300)
                {
                    dict["Chocolate cake"]++;
                    ingredients.Dequeue();
                }
                else if (dishLevel == 400)
                {
                    dict["Lobster"]++;
                    ingredients.Dequeue();
                }
                else
                {
                    var newIngredient = ingredients.Dequeue();
                    ingredients.Enqueue(newIngredient + 5);
                }
            }

            if (dict.Any(x => x.Value == 0))
            {
                Console.WriteLine("You were voted off. Better luck next year.");
                if (ingredients.Count > 0)
                {
                    Console.WriteLine($"Ingredients left: {ingredients.Sum()}");
                }
            }
            else
            {
                Console.WriteLine("Applause! The judges are fascinated by your dishes!");
            }

            var dishDict = dict.Where(x => x.Value > 0);
            foreach (var dish in dishDict)
            {
                Console.WriteLine($"# {dish.Key} --> {dish.Value}");
            }
        }
    }
}
//Dipping sauce	  -  150
//Green salad	  -  250
//Chocolate cake  -  300
//Lobster	      -  400
