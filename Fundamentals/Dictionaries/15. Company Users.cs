using System;
using System.Linq;
using System.Collections.Generic;

namespace _15._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            //"{companyName} -> {employeeId}".
            var company = new SortedDictionary<string, List<string>>();
            string input = Console.ReadLine();

            while (input != "End")
            {
                var cmd = input.Split(" -> ");
                string companyName = cmd[0];
                string employeeID = cmd[1];

                if (!company.ContainsKey(companyName))
                {
                    company.Add(companyName, new List<string>());
                }
                if (!company[companyName].Contains(employeeID))
                {
                    company[companyName].Add(employeeID);
                }

                input = Console.ReadLine();
            }

            foreach (var employer in company)
            {
                Console.WriteLine(employer.Key);

                foreach (var ID in employer.Value)
                {
                    Console.WriteLine($"-- {ID}");
                }
            }
        }
    }
}
