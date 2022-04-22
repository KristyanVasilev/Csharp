namespace SingletonMonostate
{
    public class Car
    {
        private static string manufacture; 

        private static int year;

        private static string model;

        public string Manufacture
        {
            get => manufacture;
            set => manufacture = value;
        }
        public int Year
        {
            get => year;
            set => year = value;
        }
        public string Model
        {
            get => model;
            set => model = value;
        }

        public override string ToString()
        {
            return $"{this.Manufacture} {this.Model} is manufactured in {this.Year}";
        }
    }
}
