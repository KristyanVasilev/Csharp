using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    public class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>();
            var products = new List<Product>();

            try
            {
                string[] personInput = Console.ReadLine().Split(new char[] {';', '=' }) ;
                for (int i = 0; i < personInput.Length; i+=2)
                {
                    string name = personInput[i];
                    decimal money = decimal.Parse(personInput[i+1]);
                    var person = new Person(name, money);
                    people.Add(person);
                }

                string[] productsInput = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < productsInput.Length; i++)
                {
                    string[] productInfo = productsInput[i].Split('=', StringSplitOptions.RemoveEmptyEntries);
                    string name = productInfo[0];
                    decimal cost = decimal.Parse(productInfo[1]);
                    var product = new Product(name, cost);
                    products.Add(product);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            string[] commands = Console.ReadLine().Split();
            while (commands[0] != "END")
            {
                string person = commands[0];
                string product = commands[1];

                var currPerson = people.FirstOrDefault(x => x.Name == person);
                var currProduct = products.FirstOrDefault(x => x.Name == product);

                if (currPerson == null && currPerson == null)
                {
                    continue;
                }

                if (currPerson.Money - currProduct.Cost > 0)
                {
                    currPerson.AddProduct(currProduct);
                    Console.WriteLine($"{currPerson.Name} bought {currProduct.Name}");
                }
                else
                {
                    Console.WriteLine($"{currPerson.Name} can't afford {currProduct.Name}");
                }
                commands = Console.ReadLine().Split();
            }

            foreach (var person in people)
            {
                if (person.Products.Count > 0)
                {
                    Console.WriteLine($"{person.Name} - {string.Join(", ", person.Products.Select(x => x.Name))}");
                }
                else
                {
                    Console.WriteLine($"{person.Name} - Nothing bought ");
                }
            }
        }
    }
}
