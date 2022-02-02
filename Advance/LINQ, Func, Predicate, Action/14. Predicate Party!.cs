using System;
using System.Collections.Generic;
using System.Linq;

namespace _14._Predicate_Party_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();
            string command = Console.ReadLine();
            while (command != "Party!")
            {
                string[] currCmd = command.Split();
                Predicate<string> predicate = GetPredicate(currCmd[1], currCmd[2]);
                if (currCmd[0] == "Remove")
                {
                    names.RemoveAll(predicate);
                }
                else if (currCmd[0] == "Double")
                {
                    List<string> doubledNames = names.FindAll(predicate);
                    if (doubledNames.Any())
                    {
                        int index = names.FindIndex(predicate);
                        names.InsertRange(index, doubledNames);
                    }
                }

                command = Console.ReadLine();
            }
            if (names.Any())
            {
                Console.WriteLine($"{string.Join(", ", names)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        private static Predicate<string> GetPredicate(string command, string param)
        {
            if (command == "StartsWith")
            {
                return x => x.StartsWith(param);
            }
            else if (command == "EndsWith")
            {
                return x => x.EndsWith(param);
            }

            int lenght = int.Parse(param);
            return x => x.Length == lenght;
        }
    }
}
/*Ivan’s parents are on a vacation for the holidays and he is planning an epic party at home. Unfortunately, his organizational skills are next to non-existent, so you are given the task to help him with the reservations.
On the first line, you receive a list of all the people that are coming. On the next lines, until you get the "Party!" command, you may be asked to double or remove all the people that apply to the given criteria. There are three different criteria: 
•	Everyone that has his name starting with a given string
•	Everyone that has a name ending with a given string
•	Everyone that has a name with a given length.
Finally, print all the guests who are going to the party separated by ", " and then add the ending "are going to the party!". If no guests are going to the party print "Nobody is going to the party!". See the examples below:
*/
