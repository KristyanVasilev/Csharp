using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionariesOrderBy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> countryTowns = new Dictionary<string, List<string>>();

            countryTowns.Add("Bulgaria", new List<string>());
            countryTowns.Add("ZZ", new List<string>());
            countryTowns.Add("USA", new List<string>());
            countryTowns.Add("France", new List<string>());
            countryTowns.Add("AA", new List<string>());

            countryTowns["Bulgaria"].Add("Sofia");
            countryTowns["Bulgaria"].Add("Plovdiv");
            countryTowns["Bulgaria"].Add("Varna");

            countryTowns["USA"].Add("Chicago");
            countryTowns["USA"].Add("New York");

            countryTowns["France"].Add("Paris");
            countryTowns["France"].Add("Mets");

            countryTowns = countryTowns.OrderBy(c => c.Key).ToDictionary(c => c.Key, c => c.Value); //c => c.Value.count.. etc..

            foreach (var country in countryTowns)
            {
                Console.WriteLine($"{country.Key} -> {string.Join(", ",country.Value)}");
            }
        }
    }
}
