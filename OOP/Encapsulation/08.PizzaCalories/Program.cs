using System;

namespace PizzaCalories
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] pizzaInfo = Console.ReadLine().Split();
                string pizzaName = pizzaInfo[1];

                string[] doughInfo = Console.ReadLine().Split();
                string doughType = doughInfo[1];
                string doughTechnique = doughInfo[2];
                double doughWeight = double.Parse(doughInfo[3]);

                var dough = new Dough(doughType, doughTechnique, doughWeight);
                var pizza = new Pizza(pizzaName, dough);

                string[] toppingInfo = Console.ReadLine().Split();

                while (toppingInfo[0] != "END")
                {
                    string type = toppingInfo[1];
                    double weight = double.Parse(toppingInfo[2]);
                    var topping = new Topping(type, weight);

                    pizza.AddTopping(topping);

                    toppingInfo = Console.ReadLine().Split();
                }

                Console.WriteLine($"{pizza.Name} - {pizza.CalculateTotalCalories():f2} Calories.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
