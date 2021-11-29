using System;
using System.Text;

namespace Т15._World_Tour
{
    class Program
    {

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder route = new StringBuilder(input);
            string cmd = Console.ReadLine();
            while (cmd != "Travel")
            {
                string[] commands = cmd.Split(":");
                string currCmd = commands[0];

                switch (currCmd)
                {
                    case "Add Stop":
                        int index = int.Parse(commands[1]);
                        string city = commands[2];
                        if (index >= 0 && index <= route.Length - 1)
                        {
                            route.Insert(index, city);
                        }
                        break;

                    case "Remove Stop":
                        int startIndex = int.Parse(commands[1]);
                        int endIndex = int.Parse(commands[2]);
                        int lenght = 0;
                        if (startIndex >= 0 && startIndex <= route.Length-1 && endIndex >= 0 && endIndex <= route.Length - 1)
                        {
                            if (endIndex > startIndex)
                            {
                                lenght = endIndex - startIndex;
                            }
                            else
                            {
                                lenght = startIndex - endIndex;
                            }
                            route.Remove(startIndex, lenght +1);
                        }
                        break;

                    case "Switch":
                        string oldValue = commands[1];
                        string newValue = commands[2];
                        if (route.ToString().Contains(oldValue))
                        {
                            route.Replace(oldValue, newValue);
                        }
                        break;
                }
                Console.WriteLine(route);

                cmd = Console.ReadLine();
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {route}");

        }
    }
}
