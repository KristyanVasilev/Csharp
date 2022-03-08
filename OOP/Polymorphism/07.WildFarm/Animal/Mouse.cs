using WildFarm.Food;

namespace WildFarm.Animal
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double wieght, string livingRegion)
            : base(name, wieght, livingRegion)
        {
        }

        public override void Eat(IFood food)
        {
            if (food is Vegetable || food is Fruit)
            {
                this.FoodEaten += food.Quantity;
                this.Weight += food.Quantity * 0.10;
            }
            else
            {
                ThrowInvalidOperationExceptionForFood(this, food);
            }
        }

        public override string ProduceSound()
           => "Squeak";

        public override string ToString()
             => $"{this.GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
    }
}
