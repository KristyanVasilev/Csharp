namespace Person
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string name = System.Console.ReadLine();
            int age = int.Parse(System.Console.ReadLine());

            if (age < 0)
            {
                return;
            }

            Person person;
            if (age <= 15)
            {
                person = new Child(name, age);
            }
            else
            {
                person = new Person(name, age);
            }

            System.Console.WriteLine(person);
        }
    }
}