namespace WildFarm.Animal
{
    public abstract class Mammal : Animal
    {
        protected Mammal(string name, double wieght, string livingRegion)
            : base(name, wieght)
        {
            this.LivingRegion = livingRegion;
        }

        public string LivingRegion { get; set; }
    }
}
