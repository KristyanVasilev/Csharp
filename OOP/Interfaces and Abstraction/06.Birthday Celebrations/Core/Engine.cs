using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BorderControl
{
    public class Engine
    {
        private List<IBirthable> repository;

        public Engine()
        {
            this.repository = new List<IBirthable>();
        }

        public void Run()
        {
            string input = Console.ReadLine();
            while (input != "End")
            {
                var command = input.Split();
                Identification(command);
                input = Console.ReadLine();
            }

            string yearToIdentificate = Console.ReadLine();
            string[] birthables = this.repository.Where(x => x.Birthdate.Split('/').Last() == yearToIdentificate).Select(x => x.Birthdate).ToArray();
           //string[] birthables = this.repository.Where(x => x.Birthdate.EndsWith(yearToIdentificate)).Select(x => x.Birthdate).ToArray();

            PrintBirthable(birthables);
        }

        private void Identification(string[] command)
        {
            string type = command[0];
            if (type == "Citizen")
            {
                string name = command[1];
                int age = int.Parse(command[2]);
                string id = command[3];
                string birthdate = command[4];

                IBirthable citizen = new Citizen(name, age, id, birthdate);
                this.repository.Add(citizen);
            }
            else if (type == "Pet")
            {

                string name = command[1];
                string birthdate = command[2];

                IBirthable pet = new Pet(name, birthdate);
                this.repository.Add(pet);        
            }
        }

        private void PrintBirthable(IEnumerable<string> birthables)
        {
            foreach (var date in birthables)
            {
                Console.WriteLine(date);
            }
        }
    }
}
