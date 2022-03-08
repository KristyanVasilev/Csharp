namespace WildFarm.Animal
{
    public abstract class Bird : Animal
    {
        protected Bird(string name, double wieght, double wingSize)
            : base(name, wieght)
        {
            this.WingSize = wingSize;
        }

        public double WingSize { get; set; }

        public override string ToString()
            => $"{this.GetType().Name} [{this.Name}, {this.WingSize}, {this.Weight}, {this.FoodEaten}]";
    }
}
