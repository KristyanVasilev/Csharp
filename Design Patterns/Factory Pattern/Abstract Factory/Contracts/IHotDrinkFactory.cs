namespace AbstractFactory
{
    public partial class Program
    {
        public interface IHotDrinkFactory
        {
            IHotDrink Prepare(int amount);
        }
    }
}
