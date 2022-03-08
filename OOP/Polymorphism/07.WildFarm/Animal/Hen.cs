using WildFarm.Food;

namespace WildFarm.Animal
{
    public class Hen : Bird
    {
        public Hen(string name, double wieght, double wingSize)
            : base(name, wieght, wingSize)
        {
        }

        public override void Eat(IFood food)
        {
            this.FoodEaten += food.Quantity;
            this.Weight += food.Quantity * 0.35;
        }

        public override string ProduceSound()
              => "Cluck";
    }
}
