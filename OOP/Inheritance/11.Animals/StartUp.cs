using System.Collections.Generic;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string command = System.Console.ReadLine();
            List<Animal> animals = new List<Animal>();

            while (command != "Beast!")
            {
                string[] animalInfo = System.Console.ReadLine().Split();
                string name = animalInfo[0];
                int age = int.Parse(animalInfo[1]);
                string gender = animalInfo[2];

                if (command == "Cat")
                {
                    Animal cat = new Cat(name, age, gender);
                    animals.Add(cat);
                }
                else if (command == "Dog")
                {
                    Animal dog = new Dog(name, age, gender);
                    animals.Add(dog);
                }
                else if (command == "Frog")
                {
                    Animal frog = new Frog(name, age, gender);
                    animals.Add(frog);
                }
                else if (command == "Kitten")
                {
                    Kitten kitten = new Kitten(name, age);
                    animals.Add(kitten);
                }
                else if (command == "Tomcat")
                {
                    Tomcat tomcat = new Tomcat(name, age);
                    animals.Add(tomcat);
                }

                command = System.Console.ReadLine();
            }

            foreach (var animal in animals)
            {
                System.Console.WriteLine(animal.GetType().Name);
                System.Console.WriteLine($"{animal.Name} {animal.Age} {animal.Gender}");
                System.Console.WriteLine(animal.ProduceSound());
            }
        }
    }
}
