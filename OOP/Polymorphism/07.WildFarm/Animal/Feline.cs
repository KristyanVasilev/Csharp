namespace WildFarm.Animal
{
    public abstract class Feline : Mammal
    {
        protected Feline(string name, double wieght, string livingRegion, string breed)
            : base(name, wieght, livingRegion)
        {
            this.Breed = breed;
        }

        public string Breed { get; set; }

        public override string ToString()
             => $"{this.GetType().Name} [{this.Name}, {this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
    }
}
