using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BorderControl
{
    public class Engine
    {
        private List<IBuyer> repository;

        public Engine()
        {
            this.repository = new List<IBuyer>();
        }

        public void Run()
        {
            var n = int.Parse(Console.ReadLine());
            FillRepository(n);

            string input = Console.ReadLine();
            while (input != "End")
            {
                IBuyer currBuyer = FindBuyer(input);
                currBuyer?.BuyFood();

                input = Console.ReadLine();
            }

            PrintFoodCount();
        }

        private void PrintFoodCount()
            => Console.WriteLine(this.repository.Sum(x => x.Food));
        

        private IBuyer FindBuyer(string input)
            => this.repository.FirstOrDefault(x => x.Name == input);


        private void FillRepository(int n)
        {
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                string name = input[0];
                int age = int.Parse(input[1]);

                switch (input.Length)
                {
                    case 4:
                        string id = input[2];
                        string birthdate = input[3];
                        IBuyer citizen = new Citizen(name, age, id, birthdate);
                        this.repository.Add(citizen);
                            break;
                    case 3:
                        string group = input[2];                        
                        IBuyer rebel = new Rebel(name, age, group);
                        this.repository.Add(rebel);
                        break;
                }
            }
        }
    }
}
