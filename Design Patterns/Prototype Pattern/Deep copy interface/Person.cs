namespace DeepCopyInterface
{
    public class Person : IPrototype<Person>
    {
        public Person(string name, Adress adreess)
        {
            this.Name = name;
            this.Adreess = adreess;
        }

        public string Name { get; set; }

        public Adress Adreess { get; set; }

        public Person DeepCopy()
        {
            return new Person(this.Name, this.Adreess.DeepCopy());
        }

        public override string ToString()
        {
            return $"{this.Name} is living on {this.Adreess.ToString()}";
        }
    }
}
