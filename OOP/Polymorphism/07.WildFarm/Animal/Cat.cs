using WildFarm.Food;

namespace WildFarm.Animal
{
    public class Cat : Feline
    {
        public Cat(string name, double wieght, string livingRegion, string breed)
            : base(name, wieght, livingRegion, breed)
        {
        }

        public override void Eat(IFood food)
        {
            if (food is Vegetable || food is Meat)
            {
                this.FoodEaten += food.Quantity;
                this.Weight += food.Quantity * 0.30;
            }
            else
            {
                ThrowInvalidOperationExceptionForFood(this, food);
            }
        }

        public override string ProduceSound()
            => "Meow";
    }
}
