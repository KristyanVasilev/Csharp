using System;
using WildFarm.Food;

namespace WildFarm.Animal
{
    public abstract class Animal : IAnimal
    {
        protected Animal(string name, double wieght)
        {
            Name = name;
            Weight = wieght;
        }

        public string Name { get; set; }
        public double Weight { get; set; }
        public int FoodEaten { get; set; }

        public abstract void Eat(IFood food);

        public abstract string ProduceSound();

        protected void ThrowInvalidOperationExceptionForFood(IAnimal animalType, IFood foodType)
        {
            throw new InvalidOperationException($"{animalType.GetType().Name} does not eat {foodType.GetType().Name}!");
        }
    }
}
