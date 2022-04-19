namespace AbstractFactory
{
    public partial class Program
    {
        static void Main(string[] args)
        {
            var machine = new HotDrinkMachine();

            IHotDrink drink = machine.MakeDrink();
            drink.Consume();
        }
    }
}
