using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Food;

namespace WildFarm.Animal
{
    public class Owl : Bird
    {
        public Owl(string name, double wieght, double wingSize)
            : base(name, wieght, wingSize)
        {
        }
       
        public override void Eat(IFood food)
        {
            if (!(food is Meat))
            {
                ThrowInvalidOperationExceptionForFood(this, food);
            }
            this.FoodEaten += food.Quantity;
            this.Weight += food.Quantity * 0.25;
        }

        public override string ProduceSound()
            => "Hoot Hoot";
    }
}
