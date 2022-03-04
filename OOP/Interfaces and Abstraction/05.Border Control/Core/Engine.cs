using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BorderControl
{
    public class Engine
    {
        private List<IIdentifiable> repository;

        public Engine()
        {
            this.repository = new List<IIdentifiable>();
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

            string fakeId = Console.ReadLine();
            string[] fakeIds = this.repository.Where(x => x.Id.EndsWith(fakeId)).Select(x => x.Id).ToArray();

            PrintFakeIds(fakeIds);
        }

        private void Identification(string[] command)
        {
            if (command.Length == 3)
            {
                string name = command[0];
                int age = int.Parse(command[1]);
                string id = command[2];

                IIdentifiable citizen = new Citizen(name, age, id);
                this.repository.Add(citizen);
            }
            else
            {
                string model = command[0];
                string id = command[1];
                IIdentifiable robot = new Robot(model, id);
                this.repository.Add(robot);
            }
        }

        private void PrintFakeIds(IEnumerable<string> fakeIds)
        {
            foreach (var id in fakeIds)
            {
                Console.WriteLine(id);
            }
        }
    }
}
