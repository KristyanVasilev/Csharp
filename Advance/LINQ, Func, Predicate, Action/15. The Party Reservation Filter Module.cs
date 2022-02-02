using System;
using System.Collections.Generic;
using System.Linq;

namespace _15._The_Party_Reservation_Filter_Module
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();
            var dict = new Dictionary<string, Predicate<string>>();
            string[] commands = Console.ReadLine().Split(';');

            while (commands[0] != "Print")
            {
                string action = commands[0];
                string predicatAction = commands[1];
                string value = commands[2];
                string key = predicatAction + "_" + value;

                if (action == "Add filter")
                {
                    Predicate<string> predicate = GetPredicate(predicatAction, value);
                    dict.Add(key, predicate);
                }
                else
                {
                    dict.Remove(key);
                }

                commands = Console.ReadLine().Split(';');
            }

            foreach (var (key, predicate) in dict)
            {
                names.RemoveAll(predicate);
            }
            Console.WriteLine(string.Join(" ", names));
        }

        private static Predicate<string> GetPredicate(string predicatAction, string value)
        {
            if (predicatAction == "Starts with")
            {
                return x => x.StartsWith(value);
            }
            else if (predicatAction == "Ends with")
            {
                return x => x.EndsWith(value);
            }
            else if (predicatAction == "Contains")
            {
                return x => x.Contains(value);
            }

            int lenght = int.Parse(value);
            return x => x.Length == lenght;
        }
    }
}

/*You need to implement a filtering module to a party reservation software. First, the Party Reservation Filter Module (PRFM for short) is passed a list with invitations. Next, the PRFM receives a sequence of commands that specify whether you need to add or remove a given filter.
Each PRFM command is in the given format:
"{command;filter type;filter parameter}"
You can receive the following PRFM commands: 
•	"Add filter"
•	"Remove filter"
•	"Print" 
The possible PRFM filter types are: 
•	"Starts with"
•	"Ends with"
•	"Length"
•	"Contains"
All PRFM filter parameters will be a string (or an integer only for the "Length" filter). Each command will be valid e.g. you won’t be asked to remove a non-existent filter. The input will end with a "Print" command, after which you should print all the party-goers that are left after the filtration. See the examples below:*/