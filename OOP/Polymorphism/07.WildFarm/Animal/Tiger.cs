using WildFarm.Food;

namespace WildFarm.Animal
{
    public class Tiger : Feline
    {
        public Tiger(string name, double wieght, string livingRegion, string breed)
            : base(name, wieght, livingRegion, breed)
        {
        }

        public override void Eat(IFood food)
        {
            if (!(food is Meat))
            {
                ThrowInvalidOperationExceptionForFood(this, food);
            }
            this.FoodEaten += food.Quantity;
            this.Weight += food.Quantity;
        }

        public override string ProduceSound()
        => "ROAR!!!";
    }
}
