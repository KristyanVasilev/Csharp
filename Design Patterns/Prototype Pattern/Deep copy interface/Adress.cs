namespace DeepCopyInterface
{
    public class Adress : IPrototype<Adress>
    {
        public string Street { get; set; }
        public string HouseNumber { get; set; }

        public Adress DeepCopy()
        {
           return new Adress { Street = Street, HouseNumber = HouseNumber };
        }

        public override string ToString()
        {
            return $"{Street} with house number {HouseNumber}";
        }
    }
}
