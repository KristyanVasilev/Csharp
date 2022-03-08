using System;
using System.Collections.Generic;
using WildFarm.Animal;
using WildFarm.Food;

namespace WildFarm
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<IAnimal> animals = new List<IAnimal>();

            string[] input = Console.ReadLine().Split();
            input = ReadInput(animals, input);

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }
        }

        private static string[] ReadInput(List<IAnimal> animals, string[] input)
        {
            while (input[0] != "End")
            {
                string[] foodInput = Console.ReadLine().Split();

                string animalType = input[0];
                string name = input[1];
                double weight = double.Parse(input[2]);
                IAnimal animal = null;

                string foodType = foodInput[0];
                int qty = int.Parse(foodInput[1]);
                IFood food = null;

                try
                {
                    switch (animalType)
                    {
                        case "Dog":
                            string dogRegion = input[3];
                            animal = new Dog(name, weight, dogRegion);
                            break;

                        case "Mouse":
                            string mouseRegion = input[3];
                            animal = new Mouse(name, weight, mouseRegion);
                            break;

                        case "Cat":
                            string catRegion = input[3];
                            string catBreed = input[4];
                            animal = new Cat(name, weight, catRegion, catBreed);
                            break;

                        case "Tiger":
                            string tigerRegion = input[3];
                            string tigerBreed = input[4];
                            animal = new Tiger(name, weight, tigerRegion, tigerBreed);
                            break;

                        case "Hen":
                            double henWingSize = double.Parse(input[3]);
                            animal = new Hen(name, weight, henWingSize);
                            break;

                        case "Owl":
                            double owlWingSize = double.Parse(input[3]);
                            animal = new Owl(name, weight, owlWingSize);
                            break;
                    }

                    switch (foodType)
                    {
                        case "Vegetable":
                            food = new Vegetable(qty);
                            break;

                        case "Meat":
                            food = new Meat(qty);
                            break;

                        case "Seeds":
                            food = new Seeds(qty);
                            break;

                        case "Fruit":
                            food = new Fruit(qty);
                            break;
                    }
                    animals.Add(animal);
                    Console.WriteLine(animal.ProduceSound());
                    animal.Eat(food);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                input = Console.ReadLine().Split();
            }

            return input;
        }
    }
}
